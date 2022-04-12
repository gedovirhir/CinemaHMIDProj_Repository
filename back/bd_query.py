from msilib.schema import Error
from bd.models.database import session
from bd.models.books import book, CHPT_REG
from bd.models.books_rent import book_rent
from bd.models.librarians import librarian
from bd.models.readers import reader

from parse_tools.bookDataParse import getFiltredBooks_parse
from parse_tools.readerDataParse import getFiltredReaders_parse
from datetime import date, datetime, timedelta
from sqlalchemy import and_, or_
from sqlalchemy.exc import IntegrityError
import json
from re import match

S = session() #подключение к бд

SUC = "success"
ERR = "bigBlackCock"
ERRJS = json.dumps({
    "message" : ERR
})
SUCJS = json.dumps({
    "message" : SUC
})
SQLERR = json.dumps({
                "message" : ERR,
                "body" : "OperationError"
            })
STATUSES = {
    0 : "",
    1 : "Активно",
    2 : "Просрочено",
    3 : "Закрыто"
}
def close():
    S.commit()
    S.close()
def coalesce(*args): #да я быдло
    for i in args:
        if i == 0 or i: return i
    return True
def autLibrarian(email, password):
    try:    
        email = email.strip()
        acc = S.query(librarian).filter(librarian.email == email).all()
        if acc and acc[0].password == password:
            return SUCJS
        return ERRJS
    finally:
        close()
def createRent(readerId: int, bookId: int, rentDate: date = date.today(), dayLimit: int = 14): #YYYY-MM-DD , добавляет запись о аренде читателем книги
    try:    
        if S.query(book).filter(book.id == bookId)[0].getStatus()[0] == "В наличии": #Проверка статуса строкой в запросе БЫДЛО
            S.add(book_rent(readerId, bookId, rentDate, rentDate + timedelta(days=dayLimit)))
            S.commit()
            S.close()
            return json.dumps({
                "message" : SUC,
                "body" : "Книга успешно выдана"
            }, ensure_ascii=False)
        else: #
            return json.dumps({
                "message" : ERR,
                "body" : "Книги нет в наличии"
            }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
def closeRent(rent_id: int):
    try:
        S.query(book_rent).filter(book_rent.id == rent_id)[0].closeRent()
        S.commit()
        S.close
        return SUCJS
    except:
        return SQLERR
    finally:
        close()
def getFiltredRents(reader_id: int = '', book_id: int = '', rentdate: date = '', date_limit: date = '', status: int = 0, limit: int = 20, offset: int = 0):
    boolHelp = lambda func,arg: func(arg) if arg else True 
    try:  
        rents = S.query(book_rent.id).filter(and_(
            boolHelp(book_rent.reader_id.__eq__,reader_id), 
            boolHelp(book_rent.book_id.__eq__,book_id),
            boolHelp(book_rent.rentdate.__eq__,rentdate),
            boolHelp(book_rent.date_limit.__eq__,date_limit),
            boolHelp(book_rent.getStatus.__eq__,STATUSES[status])
        )).limit(limit).offset(offset).all()
        return json.dumps({
                "message" : SUC,
                "body" : [i[0] for i in rents]
            }, ensure_ascii=False)
    finally:
        close()
def getRentsInfoById(rents_id: list):
    try:     
        if type(rents_id) != list: rents_id = [rents_id] #парсинг внутри запроса БЫДЛО
        res = []
        rents = S.query(book_rent).filter(book_rent.id.in_(rents_id))
        for i in rents:
            res.append({
                "reader_id" : i.reader.id,
                "nsp" : f'{i.reader.name} {i.reader.surname[0].title()}.{i.reader.patronymic[0].title()}.',
                "telnumber" : i.reader.telnumber,
                "email" : i.reader.email,
                "unique_number" : i.book.unique_number,
                "title" : i.book.title,
                "rentDate" : str(i.rentdate),
                "date_limit" : str(i.date_limit),
                "status" : i.getStatus
            })
        return json.dumps({
                "message" : SUC,
                "body" : res
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
#РАБОТА С КНИГАМИ
def getFiltredBooks(title: str = "", unique_number: str = "", author: str = "", year: str = "", publishment: str = "", publish_city: str = "", chapter: str = "", limit = 20, offset = 0): #возвращает список должников
    try:
        title, unique_number, author, year, publishment, publish_city, chapter = getFiltredBooks_parse(title,unique_number, author, year, publishment, publish_city, chapter, CHPT_REG)
        filtredBooks = S.query(book.id).filter(and_( #ну а что поделать если ilike не работает
            book.title.ilike(f'%{title}%'), #название
            book.unique_number.ilike(f'{unique_number}%'),
            book.author.ilike(f'%{author}%'), #автор
            book.year.ilike(f'%{year}%'),  #год выпуска
            book.publishment.ilike(f'%{publishment}%'),
            book.publish_city.ilike(f'%{publish_city}%'),
            book.chapter.ilike(f'%{chapter}%')
        )).order_by(book.read_count).limit(limit).offset(offset)
        res = []
        for i in filtredBooks:
            res.append(i.id)
        return json.dumps({
            "message" : SUC,
            "body" : res
        }, ensure_ascii=False)
    finally:
        close()
def getBooksInfoById(books_id: list):
    try:        
        if type(books_id) != list: books_id = [books_id] #парсинг БЫДЛО
        res = []
        books = S.query(book).filter(book.id.in_(books_id))
        for i in books:
            status = i.getStatus()
            res.append({
                "unique_number" : i.unique_number,
                "title" : i.title,
                "author" : i.author,
                "year" : i.year,
                "publishment" : i.publishment,
                "publish_city" : i.publish_city,
                "chapter" : i.chapter,
                "read_count" : i.read_count,
                "status" : status[0],
                "rentdate" : status[1], 
                "date_limit" : status[2]
            })
        return json.dumps({
                "message" : SUC,
                "body" : res
            }, ensure_ascii=False)
    finally:
        close()
def addBook(title: str, unique_number: str, author: str = "", year: str = "", publishment: str = "", publish_city: str = "", chapter: str = ""):
    try:     #БЫДЛО
        check = lambda y: not all(map(lambda x: x.isdigit(),y)) #быдло
        if check(unique_number) or check(year) or not all([title, unique_number]): 
            raise Error
        S.add(book(title, unique_number, author, year, publishment, publish_city, chapter))
        S.commit()
        S.close()
        return SUCJS
    except IntegrityError:
        return json.dumps({
                "message" : ERR,
                "body" : "Такой уникальный номер уже существует или некорректен"
            }, ensure_ascii=False)
    except:
        return json.dumps({
                "message" : ERR,
                "body" : "Введены некорректные данные"
            }, ensure_ascii=False)
def updateBookData(book_id: int, title: str = "", unique_number: str = "", author: str = "", year: str = "", publishment: str = "", publish_city: str = "", chapter: str = ""):
    try:    #также нет парсинга БЫДЛО
        qry = S.query(book).filter(book.id == book_id)
        args = [title,unique_number,author,year,publishment,publish_city,chapter]
        op = [
            lambda x: qry.update({book.title: x}),
            lambda x: qry.update({book.unique_number: x}),
            lambda x: qry.update({book.author: x}),
            lambda x: qry.update({book.year: x}),
            lambda x: qry.update({book.publishment: x}),
            lambda x: qry.update({book.publish_city: x}),
            lambda x: qry.update({book.chapter: x})
        ]
        for i in range(len(args)):
            if args[i]:
                op[i](args[i])
        S.commit()
        S.close()
        return SUCJS
    except:
        return SQLERR
#РАБОТА С ЧИТАТЕЛЯМИ
def getFiltredReaders(name: str = "", surname: str = "", patronymic: str = "", passport: str = "", address: str = "", telnumber: str = "", email: str = "", limit = 20, offset = 0):
    try:    
        name, surname, patronymic, passport, address, telnumber, email = getFiltredReaders_parse(name, surname, patronymic, passport, address, telnumber, email)
        filtredReaders = S.query(reader.id).filter(and_(
            or_(reader.name.ilike(f'%{name}%'),reader.name.ilike(f'%{name.capitalize()}%')),
            or_(reader.surname.ilike(f'%{surname}%'),reader.surname.ilike(f'%{surname.capitalize()}%')),
            or_(reader.patronymic.ilike(f'%{patronymic}%'),reader.patronymic.ilike(f'%{patronymic.capitalize()}%')),
            reader.passport.ilike(f'{passport}%'),
            reader.address.ilike(f'%{address}%'),
            reader.telnumber.ilike(f'%{telnumber}%'),
            reader.email.ilike(f'%{email}%')               
        )).order_by(reader.surname).limit(limit).offset(offset)
        return json.dumps({
            "message" : SUC,
            "body" : [i[0] for i in filtredReaders]    
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
def getReadersInfoById(readers_id: list):
    try:    
        if type(readers_id) != list: readers_id = [readers_id] #парсинг внутри запроса БЫДЛОКОД
        readers = S.query(reader).filter(reader.id.in_(readers_id))
        res = []
        for i in readers:
            res.append({
                "id" : i.id,
                "surname" : i.surname,
                "name" : i.name,
                "patronymic" : i.patronymic,
                "passport" : i.passport,
                "address" : i.address,
                "telnumber" : i.telnumber,
                "email" : i.email,
                "books_count" : len(i.books) 
            })
        return json.dumps({
            "message" : SUC,
            "body" : res    
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
def addReader(name: str, surname: str, patronymic: str, passport: str, address: str, telnumber: str = "", email: str = ""):
    try:
        name, surname, patronymic, passport, address, telnumber, email = getFiltredReaders_parse(name, surname, patronymic, passport, address, telnumber, email)
        #Опять половина парсинга в запросе БЫДЛОКОД
        name, surname, patronymic = name.capitalize(), surname.capitalize(), patronymic.capitalize()
        if not match(r'\S+@\S+', email) or not all([name, surname, patronymic, passport, address, telnumber, email]): #БЫДЛО
            return json.dumps({
                "message" : ERR,
                "body" : "Некорректные данные"
            }, ensure_ascii=False)   
        S.add(reader(name, surname, patronymic, passport, address, telnumber, email))
        S.commit()
        S.close()
    except:
        return SQLERR
def updateReader(reader_id: int, name: str = "", surname: str = "", patronymic: str = "", passport: str = "", address: str = "", telnumber: str = "", email: str = ""):
    try:    
        #Дублирование кода, парсинг внутри запроса, БЫДЛОКОД
        name, surname, patronymic, passport, address, telnumber, email = getFiltredReaders_parse(name, surname, patronymic, passport, address, telnumber, email)
        name, surname, patronymic = name.capitalize(), surname.capitalize(), patronymic.capitalize()
        if email and not match(r'\S+@\S+', email):
            return json.dumps({
                "message" : ERR,
                "body" : "Некорректный email"
            }, ensure_ascii=False)   

        qry = S.query(reader).filter(reader.id == reader_id)
        args = [name,surname,patronymic,passport,address,telnumber,email]
        op = [
            lambda x: qry.update({reader.name: x}),
            lambda x: qry.update({reader.surname: x}),
            lambda x: qry.update({reader.patronymic: x}),
            lambda x: qry.update({reader.passport: x}),
            lambda x: qry.update({reader.address: x}),
            lambda x: qry.update({reader.telnumber: x}),
            lambda x: qry.update({reader.email: x})
        ]
        for i in range(len(args)):
            if args[i]:
                op[i](args[i])
        S.commit()
        S.close()
        return SUCJS
    except:
        return SQLERR

#ВЫВОД СТАТИСТИКИ (ДОЛЖНИКОВ И ЗАДОЛЖЕННЫХ КНИГ)
def getOverdueReaders(): #id list
    try:
        overdue = json.loads(getFiltredRents(status=2))['body']
        readersId = [i[0] for i in S.query(reader.id).join(book_rent).filter(book_rent.id.in_(overdue)).all()]
        return json.dumps({
            "message" : SUC,
            "body" : readersId
        })
    except:
        return SQLERR
    finally:
        close()
def getOverdueBooks():
    try:
        overdue = json.loads(getFiltredRents(status=2))['body']
        booksId = [i[0] for i in S.query(book.id).join(book_rent).filter(book_rent.id.in_(overdue)).all()]
        return json.dumps({
            "message" : SUC,
            "body" : booksId
        })
    except:
        return SQLERR
    finally:
        close()
#print(getPromisersList())
#print(getFiltredRents(status=2))
#print(S.query(book_rent).first().getStatus())
#print(S.query(book_rent).filter(book_rent.getStatus == "Просрочено").all())
#print(getFiltredBooks())
for i in S.query(book).filter(book.id.ilike(1)):
    print(i)