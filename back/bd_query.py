from bd.models.database import session
from bd.models.genre import genre
from bd.models.movie_genre import movie_genre
from bd.models.movie import movie
from bd.models.seance import seance
from bd.models.seat import seat
from bd.models.ticket import ticket
from bd.models.accountant import accountant

from parse_tools.moviesDataParse import getFiltredMovies_parse
from parse_tools.moviesDataParse import query_contraint_if_not_null_to_list as toList
from datetime import date, datetime, timedelta
from sqlalchemy import and_, or_, func, extract
from sqlalchemy.exc import IntegrityError
import json
from re import match
from math import ceil

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
def close():
    S.commit()
    S.close()
def coalesce(*args): #да я быдло
    for i in args:
        if i == 0 or i: return i
    return True
def boolHelp(func, arg):
    return func(arg) if arg else True
def autAccountant(email, password):
    try:    
        email = email.strip()
        acc = S.query(accountant).filter(accountant.email == email).all()
        if acc and acc[0].password == password:
            return SUCJS
        return ERRJS
    finally:
        close()
"""
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
"""
#РАБОТА С КНИГАМИ
def getFiltredMovies(title: str = "", year: int = None, duration: int = None, publisher: str = "", genres: str = '', limit = 20, offset = 0): #возвращает список должников
    try:
        limit, offset = int(limit), int(offset)
        title, year, duration, publisher, genres = getFiltredMovies_parse(title, year, duration, publisher, genres)
        filtredMovs = S.query(movie).join(movie_genre).join(genre).filter(and_(
            movie.title.ilike(f'%{title}%'), #название
            boolHelp(movie.year.__eq__,year),  #год выпуска
            boolHelp(movie.duration.__eq__, duration),
            movie.publisher.ilike(f'%{publisher}%')
        )).limit(limit).offset(offset)
        res = []
        for i in filtredMovs:
            if set(genres).issubset(set(i.getGenres)): #
                res.append(i.id)
        return json.dumps({
            "message" : SUC,
            "body" : res
        }, ensure_ascii=False)
    finally:
        close()
def getMoviesInfoById(movie_id: list):
    try:
        movie_id = toList(movie_id)
        filtredMovie = S.query(movie).filter(movie.id.in_(movie_id))
        res = []
        for i in filtredMovie:
            res.append({
                "id" : i.id,
                "title" : i.title,
                "year" : i.year,
                "duration" : i.duration,
                "publisher" : i.publisher,
                "genres" : i.getGenres
            })
        return json.dumps({
                "message" : SUC,
                "body" : res
            }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()

"""
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
"""
#РАБОТА С ЧИТАТЕЛЯМИ #movie_id: int, date_time: datetime, hall_n: int
def getFiltredSeances(movieId: list = [], year: int = None, month: int = None, day: int = None, hour: int = None,  hall_n: int = None, limit = 20, offset = 0):
    try:
        limit, offset = int(limit), int(offset)
        if movieId and type(movieId) != list: movieId = [movieId]    
        filtredSeances = S.query(seance.id).filter(and_(
            boolHelp(seance.movie_id.in_,movieId),
            boolHelp(extract('year', seance.date_time).__eq__, year),
            boolHelp(extract('month', seance.date_time).__eq__, month),
            boolHelp(extract('day', seance.date_time).__eq__, day),
            boolHelp(extract('hour', seance.date_time).__eq__, hour),
            boolHelp(seance.hall_n.__eq__, hall_n)
        )).limit(limit).offset(offset).all()
        return json.dumps({
            "message" : SUC,
            "body" : [i[0] for i in filtredSeances]    
        }, ensure_ascii=False)
    finally:
        close()
def getSeancesInfoById(seancesId: list):
    try:    
        if seancesId and type(seancesId) != list: seancesId = [seancesId] #парсинг внутри запроса БЫДЛОКОД
        seances = S.query(seance).filter(seance.id.in_(seancesId))
        res = []
        for i in seances:
            res.append({
                "id" : i.id,
                "movie_id" : i.movie_id,
                "movieTitle" : i.movies.title,
                "date_time" : str(i.date_time),
                "hall_n" : i.hall_n
            })
        return json.dumps({
            "message" : SUC,
            "body" : res    
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
"""
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
"""
def getFiltredTickets(seance_id: int, seat_id: int, price: int, sold_status: bool, booking_status: bool, limit = 20, offset = 0): #  seance_id: int, seat_id: int, price: int, sold_status: bool, booking_status: bool
    try: 
        limit, offset = int(limit), int(offset)
        filtredTickets = S.query(ticket.id).filter(and_(
            boolHelp(ticket.seance_id.in_,seance_id),
            boolHelp(ticket.seat_id.in_,seat_id),
            boolHelp(ticket.price.__eq__,price),
            boolHelp(ticket.sold_status.__eq__,sold_status),
            boolHelp(ticket.booking_status.__eq__,booking_status)
        )).limit(limit).offset(offset)
        return json.dumps({
            "message" : SUC,
            "body" : [i[0] for i in filtredTickets]    
        }, ensure_ascii=False)
    finally:
        close()
def getTicketsInfoById(tickets_id: list):
    try:    
        tickets = S.query(ticket).filter(ticket.id.in_(tickets_id))
        res = []
        for i in tickets:
            res.append({
                "id" : i.id,
                "seanceId" : i.seance_id,
                "title" : i.seance.movies.title,
                "date_time" : str(i.seance.date_time),
                "hall_n" : i.seat.hall_n,
                "row_n" : i.seat.row_n,
                "seat_n" : i.seat.seat_n,
                "seat_type" : i.seat.seat_type,
                "price" : i.price,
                "sold_status" : i.sold_status
            })
        return json.dumps({
            "message" : SUC,
            "body" : res  
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()
#ВЫВОД СТАТИСТИКИ (ДОЛЖНИКОВ И ЗАДОЛЖЕННЫХ КНИГ)
"""
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
"""
def getFiltredSeats(hall_n: int = None, row_n: int = None, seat_n: int = None, seat_type: int = None,limit = 20, offset = 0):
    try: 
        limit, offset = int(limit), int(offset)
        filtredSeats = S.query(seat.id).filter(and_(
            boolHelp(seat.hall_n.__eq__, hall_n),
            boolHelp(seat.row_n.__eq__, row_n),
            boolHelp(seat.seat_n.__eq__, seat_n),
            boolHelp(seat.seat_type.__eq__, seat_type)
        )).limit(limit).offset(offset)
        return json.dumps({
            "message" : SUC,
            "body" : [i[0] for i in filtredSeats]    
        }, ensure_ascii=False)
    
    finally:
        close()
def getSeatsInfoById(seats_id: list):
    try:
        seats_id = toList(seats_id)
        seats = S.query(ticket).filter(ticket.id.in_(seats_id))
        res = []
        for i in seats:
            res.append({
                "id" : i.id, 
                "hall_n" : i.hall_n,
                "row_n" : i.row_n,
                "seat_n" : i.seat_n,
                "seat_type" : i.seat_type
            })
        return json.dumps({
            "message" : SUC,
            "body" : res    
        }, ensure_ascii=False)
    except:
        return SQLERR
    finally:
        close()

def seance_getProfit(seance_id: int, seat_type: str = None):
    seanceTickets = S.query(func.sum(ticket.price)).join(seat).filter(and_(
        ticket.seance_id == seance_id, 
        boolHelp(seat.seat_type.__eq__, seat_type), 
        ticket.sold_status == True)).all()
    return seanceTickets[0][0] if seanceTickets[0][0] else 0
def seance_ticketCount(seance_id: int, seat_type: str = None):
    return S.query(ticket).join(seat).filter(and_(
        ticket.seance_id == seance_id, 
        boolHelp(seat.seat_type.__eq__, seat_type))).count()
def seance_ticketSoldet(seance_id: int, seat_type: str = None):
    return S.query(ticket).join(seat).filter(and_(
        ticket.seance_id == seance_id, 
        ticket.sold_status == True, 
        boolHelp(seat.seat_type.__eq__, seat_type))).count()
def seance_soldetPropotion(seance_id: int, seat_type: str = None):
    allTickets = seance_ticketCount(seance_id, seat_type)
    soldetTickets = seance_ticketSoldet(seance_id, seat_type)
    try:
        return round(soldetTickets/allTickets, 2) * 100
    except ZeroDivisionError:
        return 0

def movie_getProfit(movie_id: int, seat_type: str = None):
    try:
        movie_id = int(movie_id)
        movieTickets = S.query(func.sum(ticket.price)).join(seat).join(seance).filter(and_(
            seance.movie_id == movie_id,
            boolHelp(seat.seat_type.__eq__, seat_type), 
            ticket.sold_status == True)).all()
        

        return movieTickets[0][0] if movieTickets[0][0] else 0
    except:
        return SQLERR
    finally:
        close()
def movie_ticketCount(movie_id: int, seat_type: str = None):
    try:    
        return S.query(ticket).join(seat).join(seance).filter(and_(
            seance.movie_id == movie_id, 
            boolHelp(seat.seat_type.__eq__, seat_type))).count()
    except:
        return SQLERR
    finally:
        close()
def movie_ticketSoldet(movie_id: int, seat_type: str = None):
    try:    
        return S.query(ticket).join(seat).join(seance).filter(and_(
            seance.movie_id == movie_id, 
            ticket.sold_status == True, 
            boolHelp(seat.seat_type.__eq__, seat_type))).count()
    except:
        return SQLERR
    finally:
        close()
def movie_soldetPropotion(movie_id: int, seat_type: str = None):
    soldetTickets = movie_ticketSoldet(int(movie_id), seat_type)
    allTickets = movie_ticketCount(int(movie_id), seat_type)
    if allTickets == 0: return 0
    try:
        return round(soldetTickets/allTickets, 2) * 100
    except ZeroDivisionError:
        return 0

def getMovieStat(movie_id: list, limit = 5):
    movie_id = toList(movie_id)
    res = []
    for i in movie_id:
        if limit == 0: break
        mov = json.loads(getMoviesInfoById(i))['body'][0]
        title = mov['title']
        res.append({
            "title" : title,
            "profit" : movie_getProfit(i),
            "regularSeatsProfit" :  movie_getProfit(i, "regular"),
            "dboxSeatsProfit" :  movie_getProfit(i, "d-box"),
            "ticketSoldet" : ceil(movie_soldetPropotion(i)),
            "regularTicketSoldet" : ceil(movie_soldetPropotion(i, "regular")),
            "dboxTicketSoldet" : ceil(movie_soldetPropotion(i, "d-box"))
        })
    return json.dumps({
            "message" : SUC,
            "body" : res    
        }, ensure_ascii=False)
def getSeanceStat(seance_id: list, limit = 5):
    seance_id = toList(seance_id)
    res = []
    for i in seance_id:
        if limit == 0: break
        seanc = json.loads(getSeancesInfoById(i))['body'][0]
        res.append({
            "title" : seanc['movieTitle'],
            "datetime" : seanc["date_time"],
            "hall_n" : seanc["hall_n"],
            "profit" : seance_getProfit(i),
            "regularSeatsProfit" :  seance_getProfit(i, "regular"),
            "dboxSeatsProfit" :  seance_getProfit(i, "d-box"),
            "ticketSoldet" : ceil(seance_soldetPropotion(i)),
            "regularTicketSoldet" : ceil(seance_soldetPropotion(i, "regular")),
            "dboxTicketSoldet" : ceil(seance_soldetPropotion(i, "d-box"))
        })
    return json.dumps({
            "message" : SUC,
            "body" : res    
        }, ensure_ascii=False)
#S.query(ticket).filter(ticket.id == 2).update({ticket.sold_status : False})
#close()