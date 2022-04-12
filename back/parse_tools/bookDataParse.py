import re
from datetime import date

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
def unique_numberNormalize(text):
    text = textNormalize(text)
    text = text.replace(' ','')
    return text
def authorNormalize(text):
    text = textNormalize(text)
    #text = text.title()
    return text
def yearNormalize(text):
    if not text: return ''
    text = textNormalize(str(text))
    cond = r'\d\d\d\d'
    cond1 = lambda x: 800 < x <= date.today().year
    res = bool(re.match(cond, text)) * cond1(int(text))
    if not res:
        return ''
    return text
def publishmentNormalize(text):
    text = textNormalize(text)
    #text = text.title()
    return text
def chapterNormalize(text, reg): #текст chapter и реестр
    text = textNormalize(text)
    #text = text.capitalize()
    if text not in reg:
        return ''
    return text
def publish_cityNormalize(text):
    text = textNormalize(text)
    #text = text.title()
    return text

def getFiltredBooks_parse(title: str, unique_number: str, author: str, year: str, publishment: str, publish_city: str, chapter: str, reg: set):
    title = titleNormalize(title)
    unique_number = unique_numberNormalize(unique_number)
    author = authorNormalize(author)
    year = yearNormalize(year)
    publishment = publishmentNormalize(publishment)
    publish_city = publish_cityNormalize(publish_city)
    chapter = chapterNormalize(chapter, reg)
    return [title, unique_number, author, year, publishment, publish_city, chapter]