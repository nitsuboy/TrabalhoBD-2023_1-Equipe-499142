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

def name(f,l) :
    return random.choice(f) + " " + random.choice(l)

def cr(c) :
    return random.choice(c)

def un(u) :
    return random.choice(u) + str(random.randint(0,99))

def tn() :
    return "(88)9" + str(random.randint(1000,9999)) + "-" + str(random.randint(1000,9999))

def aluno(ui,f,l):
    data = []
    for x in range(0,50) :
        mat = random.randint(20000,60000)
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([mat,name(f,l),"rua algum lugar",e[0],e[1],random.randint(1,10),ui])
        ui+=1
    return pd.DataFrame(data, columns=["Matricula","Nome", "Endereco", "DataIngresso", "DataConclusaoPrevista", "Cursos_CodCurso", "Usuario_CodUsuario"])

def professor(ui,f,l):
    data = []
    for x in range(0,20) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(10000,30000),name(f,l),"rua algum lugar",tn(),random.choice(["20h","40h","DE"]),e[0],random.randint(1,10),ui])
        ui+=1
    return pd.DataFrame(data, columns=["MatSiape", "Nome", "Endereco", "TelefoneCelular", "RegimeTrabalho", "DataContratacao", "Cursos_CodCurso", "Usuario_CodUsuario"])

def funcionario(ui,f,l) :
    data = []
    for x in range(0,30) :
        mat = random.randint(10000,30000)
        data.append([mat,name(f,l),"rua algum lugar",ui])
        ui+=1
    return pd.DataFrame(data, columns=["Matricula", "Nome", "endereco", "Usuario_CodUsuario"])

def usuario(a,p,f,u):
    data = []
    for x in range(0,a) :
        data.append([un(u),"admin",0,"Aluno","usuario"])
    for x in range(0,p) :
        data.append([un(u),"admin",0,"Professor","usuario"])
    for x in range(0,f) :
        data.append([un(u),"admin",0,"Funcionario","usuario"])

    return pd.DataFrame(data, columns=["NomeUsuario", "Senha", "QntLivros", "TipoUsuario", "NivelDeAcesso"])

def telefones(n,df):
    data = []
    for index, row in df.iterrows():
        data.append([row['Matricula'],tn()])
    return pd.DataFrame(data, columns=[n, "NumTelefone"])

def to_sqlmod(tabela,df):
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