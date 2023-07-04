import pandas as pd
import random
import time
import os
from unidecode import unidecode

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

def email(fl,df) :
    data = []
    for x in df.iloc:
        n = unidecode(str(x).split(', ')[0].lower())
        while len(n) < fl :
            n += str(random.randint(1,9))
        data.append(n[0:fl] + "@gmail.com")

    return data

def rc(tf,df) :
    data = []
    for x in df.iloc:
        data.append(tf.sample(n=1).values[0])

    return data

def cr(c) :
    return random.choice(c)

def un(u) :
    return random.choice(u) + str(random.randint(0,99))

def tn() :
    return "(88)9" + str(random.randint(1000,9999)) + "-" + str(random.randint(1000,9999))

def aluno(ui,f,l):
    data = []
    for x in range(0,50) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(20000,60000),ui,name(f,l),"rua algum lugar",e[0],e[1],random.randint(1,10)])
        ui+=1
    return pd.DataFrame(data, columns=["Matricula", "Usuario_CodUsuario","Nome", "Endereco", "DataIngresso", "DataConclusaoPrevista", "Cursos_CodCurso"])

def professor(ui,f,l):
    data = []
    for x in range(0,20) :
        e = random_date("2019-1-1", "2023-1-1", random.random())
        data.append([random.randint(10000,30000),ui,name(f,l),"rua algum lugar",tn(),random.choice(["20h","40h","DE"]),e[0],random.randint(1,10)])
        ui+=1
    return pd.DataFrame(data, columns=["MatSiape", "Usuario_CodUsuario", "Nome", "Endereco", "TelefoneCelular", "RegimeTrabalho", "DataContratacao", "Cursos_CodCurso"])

def funcionario(ui,f,l) :
    data = []
    for x in range(0,30) :
        data.append([random.randint(20000,60000),ui,name(f,l),"rua algum lugar"])
        ui+=1
    return pd.DataFrame(data, columns=["Matricula", "Usuario_CodUsuario", "Nome", "endereco"])

def usuario(a,p,f,u):
    data = []
    for x in range(0,a) :
        data.append([un(u),"admin",0,"Professor","usuario"])
    for x in range(0,p) :
        data.append([un(u),"admin",0,"Aluno","usuario"])
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
                y = str(y).replace("'","")
                insert += "'"+ unidecode(y) +"'" + ","
        insert=insert[:-1] + "),\n"

    insert=insert[:-2] + ";\n"
    f = open(dir_path + "\\generated\\" + tabela + ".sql", "w")
    f.write(insert)
    f.close()