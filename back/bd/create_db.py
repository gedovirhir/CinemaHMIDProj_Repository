from models.database import *
from models.database import create_db, session, DB_PATH, DATABASE_NAME
from faker import Faker
from models.books import book
from models.books_rent import book_rent
from models.librarians import librarian
from models.readers import reader

import os 

def create_database(load_fake_data: bool = True):
    create_db()
    if load_fake_data:
        _load_fake_data(session(), 50)
    
def _load_fake_data(session, count):
    fk = Faker("ru_RU")
    books = {
            "title" : ["Записки судебного деятеля", "Моя мама сошла с ума", "Мемуары", "Античная философия", "Психология и политика", "Бог и государство", "Очерк истории Польши", "Вопросы философии и психологии"], 
            "author" : ["Анатолий Федорович Кони", "Елена Афанасьева", "Феликс Юсупов", "Асмус Валентин Фердинандович", "Баженов Николай Николаевич", "Бакунин Михаил Александрович", "Бобржинский Михаил", "Грот Н.Я."],
            "year" : ["2022", "2022", "2022", "1976", "1906", "1917", "1888", "1888", "1889"],
            "chapter" : ["Публицистика", "Публицистика", "Биография", "Русская философия","Русская философия", "Русская философия", "Всеобщая история", "Русская философия"],
            "publishment" : ["", "", "", "Высшая школа", "Тип. Т-ва И.Д. Сытина", "Тип. Издательской Комиссии Московского Совета Солд. Деп.", "Издание Л.Ф. Пантелеева", "Типо-литография Высочайше утвержденного Т-ва И.Н. Кушнерев и Ко"],
            "publish_city" : ["", "", "", "Москва", "Москва", "Сергиев Посад", "Санкт-Петербург", "Москва"]
            }
    bookCount = 7
    for i in range(count):
        pr = fk.simple_profile()
        fullname = pr['name'].split(' ') #ФИО
        readr = reader(fullname[0],fullname[1],fullname[2], str(fk.random_int(1000000000, 9999999999)), pr['address'], fk.phone_number().replace(' ', ''), pr['mail'])

        randInd = fk.random_int(0, bookCount)
        bk = book(books["title"][randInd],str(fk.random_int(1000000,9999999)),books["author"][randInd], books["year"][randInd], books["publishment"][randInd], books["publish_city"][randInd], books["chapter"][randInd])

        session.add(bk)
        session.add(readr)
    
    pr = fk.simple_profile()
    fullname = pr['name'].split(' ')
    librn = librarian(fullname[0], fullname[1], fullname[2], fk.phone_number().replace(' ', ''), pr['mail'], "admin")
    session.add(librn)

    session.commit()
    session.close()


if __name__ == "__main__":
    create_database()