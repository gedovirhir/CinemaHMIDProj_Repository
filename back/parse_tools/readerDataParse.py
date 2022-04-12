PARSE_FUNCTIONS = [
        str.lower,
        str.strip
]
def textNormalize(text):
    if text:
        for i in PARSE_FUNCTIONS:
            text = i(text)
    return text
def numbersNormalize(text):
    if text:
        text = textNormalize(text).replace(' ','')
    return text
def emailNormalize(text):
    text = text.replace(' ','')
    return text
def getFiltredReaders_parse(name: str = "", surname: str = "", patronymic: str = "", passport: str = "", address: str = "", telnumber: str = "", email: str = ""):
    return [textNormalize(name),textNormalize(surname),textNormalize(patronymic),numbersNormalize(passport),address,numbersNormalize(telnumber), emailNormalize(email)]