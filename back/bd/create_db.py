from faker import Faker
from datetime import datetime, timedelta

from models.database import *
from models.database import create_db, session, DB_PATH, DATABASE_NAME
from models.movie_genre import movie_genre
from models.genre import genre
from models.movie import movie
from models.seance import seance
from models.seat import seat
from models.ticket import ticket
from models.accountant import accountant

import os 

def create_database(load_fake_data: bool = True):
    create_db()
    if load_fake_data:
        _load_fake_data(session())

def genreId(s, title):
    try:    
        qr = s.query(genre.id).filter(genre.title == title).all()
        if qr:
            return qr[0][0]
        else:
            gn = genre(title)
            s.add(gn)
            s.flush()
            idd = gn.id
            return idd
    finally:
        s.commit()
        s.close()
def ceilingForMins(mins, ceil = 5):
    mins = int(mins)
    return mins + (ceil - mins%ceil)
def close():
    session().commit()
    session().close()

def _load_fake_data(s):
    fk = Faker("ru_RU")
    seances_id = []
    row_n = 4
    seat_n = 5
    hall_n = 4
    dbox_n = 2
    #Добавляем сиденья
    for i in range(hall_n):
        for r in range(row_n):
            c = dbox_n
            for n in range(seat_n):
                if c > 0:
                    st = seat(i,r,n,"d-box",True)
                    c -= 1
                else:
                    st = seat(i,r,n,"regular",True)
                s.add(st)
                close()
    #фильмы
    movies = {
            "title" : ['Мистер Нокаут','Плохие парни', 'Я краснею', 'Все везде и сразу', 'Бэтмен', 'Аферист из Tinder', 'Анчартед: На картах не значится',
            'Костюм', 'Этот дом','И просто так', 'Крушение: Дело против Boeing', 'Этерна: Часть первая'], 
            "year" : ['2022', '2022', '2022', '2022','2022','2022','2022',
            '2022', '2022','2022','2022', '2022'],
            "duration" : ['117','100','100','139', '176', '114','115',
            '105', '97', '70', '89', '83'],
            "publisher" : ['','DreamWorks', 'Disney','','Warner Bros.', 'Netflix','Sony',
            '', '','', '', ''],
            "genres" : [["спорт", "драма"], ["мультфильм", "комедия", "приключения", "криминал"],
            ["мультфильм", "фэнтези", "комедия", "приключения"],["фантастика", "фэнтези", "боевик", "комедия"],
            ["боевик", "драма", "криминал", "детектив"],["документальный","криминал"],
            ["боевик","приключения"],["драма","криминал"],["мультфильм","драма","комедия","фэнтези"],
            ["документальный"],["документальный"],["фэнтези", "драма", "приключения"]],
            "mov_id" : []
            }
    movieCount = 12
    #добавляем фильмы, жанры и их отношения
    for i in range(movieCount):
        #обрабатываем жанры
        gen_id = []
        for title in movies['genres'][i]:
            gen_id.append(genreId(s,title))
        m = movie(movies['title'][i],movies['year'][i],movies['duration'][i],movies['publisher'][i])
        s.add(m)
        close()
        s.flush()
        m.addGenres(gen_id, s)
        movies['mov_id'].append(m.id)
    #добавляем сеансы
    #sd = (2022, 3, 1) #startdate
    #st = (8, 0) #starttime
    sdt = datetime(2022, 3, 1, 8, 0) #startdatetime
    rentalday = 3
    seancecount = 2
    movperday = int(movieCount/rentalday) #4

    seances_id = []
    for i in range(rentalday):
        for h in range(hall_n):
            dt = sdt + timedelta(days=i)
            num = lambda x: (x+h) % (movperday) #чередование фильмов между залами, чтобы в нескольких залах не шли одни и те же фильмы
            movs = [(movies['mov_id'][i*movperday + num(k)],i*movperday + num(k)) for k in range(movperday)] #(id фильма, индекс в массиве)
            for _ in range(seancecount):
                for m in movs:
                    sc = seance(m[0], dt, h)
                    s.add(sc)
                    close()
                    s.flush()
                    seances_id.append((sc.id, sc.hall_n))
                    dt += timedelta(minutes=ceilingForMins(movies['duration'][m[1]])+20)
    #добавляем билеты
    for i in seances_id:       
        allSeats = s.query(seat.id, seat.seat_type).filter(seat.hall_n == i[1]).all()
        for st in allSeats:
            if st[1] == "regular":
                price = 250
            elif st[1] == "d-box":
                price = 150
            stat = bool(fk.random_int(0,1))
            tck = ticket(i[0], st[0], price, stat, False)
            s.add(tck)
            close()
    #аккаунт бухгалтера
    acc = accountant("Дыбичев","Никита","Леонидович","+76453482849","myemail@email","admin")
    s.add(acc)
    close()
    s.close()

if __name__ == "__main__":
    create_database()