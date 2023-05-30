import pandas as pd
import random
import pyperclip
import time
    
def str_time_prop(start, end, time_format, prop):

    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ctime = time.mktime(time.strptime("1975", '%Y'))

    ptime = stime + prop * (etime - stime)

    return [time.strftime(time_format, time.localtime(ptime)),time.strftime(time_format, time.localtime(ptime + ctime))]


def random_date(start, end, prop):
    return str_time_prop(start, end, '%Y-%m-%d', prop)

#random_date("2017/1/1", "2023/1/1", random.random())

def listagem(filepath):
    lista = []

    file = open(filepath)
    for n in file:
        lista.append(n.replace("\n",""))

    return lista

firtnames = listagem("data\\first-names.txt")
lastnames = listagem("data\\middle-names.txt")
username = listagem("data\\usernames.txt")
cursos = listagem("data\\cursos.txt")

def fn() :
    return random.choice(firtnames)

def ln() :
    return random.choice(lastnames)

def name() :
    return random.choice(firtnames) + " " + random.choice(lastnames)

def cr() :
    return random.choice(cursos)

def un() :
    return random.choice(username) + str(random.randint(0,99))

#aluno
def aluno():
    data = []
    for x in range(0,50) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(20000,60000),name(),"rua algum lugar",e[0],random.randint(1,10),x+1])

    return pd.DataFrame(data, columns=["Matricula","Nome", "Endereco", "DataIngresso", "DataConclusaoPrevista", "Cursos_CodCurso", "Usuario_CodUsuario"])

def professor():
    data = []
    for x in range(0,50) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(10000,30000),name(),"rua algum lugar",e[0],e[1],random.randint(1,10),x+1])

    return pd.DataFrame(data, columns=["MatSiape", "Nome", "Endereco", "TelefoneCelular", "RegimeTrabalho", "DataContratacao", "Cursos_CodCurso", "Usuario_CodUsuario"])

#usuario
def usuario():
    data = []
    for x in range(0,50) :
        data.append([un(),"admin",0,"aluno","usuario"])

    return pd.DataFrame(data, columns=["NomeUsuario", "Senha", "QntLivros", "TipoUsuario", "NivelDeAcesso"])


def populante(tabela,df):
    insert = "INSERT INTO " + tabela + "("
    for x in df.columns:
        insert += x + ","
    insert=insert[:-1] + ") VALUES \n"

    for x in df.iloc:
        insert+="("
        for y in x:
            if isinstance(y, int):
                insert += str(y) + ","
            else: 
                insert += "'"+str(y)+"'" + ","
        insert=insert[:-1] + "),\n"

    insert=insert[:-2]
    f = open(tabela + ".sql", "x")
    f.write(insert)


populante("alunos",aluno())
populante("usuarios",usuario())