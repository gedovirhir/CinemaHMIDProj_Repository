import re
from datetime import date
from turtle import title

PARSE_FUNCTIONS = [
        str.lower,
        str.strip
]
FALSE_COND = [
    lambda s: s == "",
    lambda s: not s, #если передана FALSE\None
    lambda s: not any(map(str.isalpha, s)), #если в тексте нет букв
    lambda s: len(s) > 30 #если длина текста больше 30
]

def textNormalize(text):
    for i in PARSE_FUNCTIONS:
        text = i(text)
    return text
def titleNormalize(text):
    text = textNormalize(text)
    #text = text.capitalize()
    return text
def publishmentNormalize(text):
    text = textNormalize(text)
    #text = text.title()
    return text

def query_constraint_title_normalize(text): #нормализует "название" фильма (чего угодно)
    PARSE_FUNCTIONS = [
        str.lower,
        str.strip
    ]
    NULL_COND = [
        lambda s: not s, #если передана FALSE\None
        lambda s: not any(map(str.isalpha, s)), #если в тексте нет букв
        lambda s: len(s) > 30 #если длина текста больше 30
    ]
    for i in NULL_COND:
        if i(text): return ''
    for i in PARSE_FUNCTIONS:
        text = i(text)
    return text
def query_contraint_if_not_null_to_list(constr):
    if constr and type(constr) != list:
        try:
            return [str(i) for i in constr.split(',')]
        except:
            return [constr]
    return constr
def genresNormalize(constr):
    constr = query_contraint_if_not_null_to_list(constr) #преобразуем возможную строку в массив
    if constr:
        for i in range(len(constr)): #нормализуем каждую строку в массиве
            constr[i] = query_constraint_title_normalize(constr[i])
        while True: #удаляем все 'NULL' значения из массива
            try:
                constr.remove('')
            except ValueError:
                break
    return constr
def yearNormalize(constr):
    if re.match(r'\d\d\d\d', constr): return constr
    return None
def getFiltredMovies_parse(title: str, year: int, duration: int, publisher: str, genres):
    title = titleNormalize(title)
    publisher = publishmentNormalize(publisher)
    genres = genresNormalize(genres)
    #try: 
    #    year = int(year)
    #except:
    #    year = None
    try: 
        duration = int(duration)
    except:
        duration = None
    
    return [title, year, duration, publisher, genres]