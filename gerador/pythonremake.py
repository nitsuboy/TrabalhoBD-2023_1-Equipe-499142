import pandas as pd
import random
import time
import os

dir_path = os.path.dirname(os.path.realpath(__file__))
    
def str_time_prop(start, end, time_format, prop):

    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ctime = time.mktime(time.strptime("1975", '%Y'))

    ptime = stime + prop * (etime - stime)

    return [time.strftime(time_format, time.localtime(ptime)),time.strftime(time_format, time.localtime(ptime + ctime))]


def random_date(start, end, prop):
    return str_time_prop(start, end, '%Y-%m-%d', prop)

#random_date("2017/1/1", "2023/1/1", random.random())

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
    f = open(dir_path + "\\dados_gerados\\" + tabela + ".sql", "x")
    f.write(insert)

def listagem(filepath):
    lista = []

    file = open(filepath)
    for n in file:
        lista.append(n.replace("\n",""))

    return lista



firtnames = listagem(dir_path + "\\data\\first-names.txt")
lastnames = listagem(dir_path + "\\data\\middle-names.txt")
username = listagem(dir_path + "\\data\\usernames.txt")
cursos = listagem(dir_path + "\\data\\cursos.txt")

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

def tn() :
    return "(88)9" + str(random.randint(0000,9999)) + "-" + str(random.randint(0000,9999))

def aluno():
    data = []
    dataf = []
    for x in range(0,50) :
        mat = random.randint(20000,60000)
        for y in range(0,random.randint(1,3)) :
            dataf.append([mat,tn()])
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([mat,name(),"rua algum lugar",e[0],e[1],random.randint(1,10),x+1])
    populante("Alunos_Telefones",pd.DataFrame(dataf, columns=["Alunos_Matricula", "NumTelefone"]))
    return pd.DataFrame(data, columns=["Matricula","Nome", "Endereco", "DataIngresso", "DataConclusaoPrevista", "Cursos_CodCurso", "Usuario_CodUsuario"])

def professor():
    data = []
    for x in range(0,20) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(10000,30000),name(),"rua algum lugar",tn(),random.choice(["20h","40h","DE"]),e[0],random.randint(1,10),x+51])

    return pd.DataFrame(data, columns=["MatSiape", "Nome", "Endereco", "TelefoneCelular", "RegimeTrabalho", "DataContratacao", "Cursos_CodCurso", "Usuario_CodUsuario"])

def funcionario() :
    data = []
    dataf = []
    for x in range(0,30) :
        mat = random.randint(10000,30000)
        for y in range(0,random.randint(1,3)) :
            dataf.append([mat,tn()])
        data.append([mat,name(),"rua algum lugar",x+71])
    populante("Funcionarios_Telefones",pd.DataFrame(dataf, columns=["Funcionarios_Matricula", "NumTelefone"]))
    return pd.DataFrame(data, columns=["Matricula", "Nome", "endereco", "Usuario_CodUsuario"])

def usuario():
    data = []
    for x in range(0,50) :
        data.append([un(),"admin",0,"Aluno","usuario"])
    for x in range(0,20) :
        data.append([un(),"admin",0,"Professor","usuario"])
    for x in range(0,30) :
        data.append([un(),"admin",0,"Funcionario","usuario"])

    return pd.DataFrame(data, columns=["NomeUsuario", "Senha", "QntLivros", "TipoUsuario", "NivelDeAcesso"])

populante("Alunos",aluno())
populante("Usuarios",usuario())
populante("Professores",professor())
populante("Funcionarios",funcionario())