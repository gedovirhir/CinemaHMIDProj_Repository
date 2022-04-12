from enum import unique
from sqlalchemy import Column, String, Integer
from .database import base, DB_PATH
from sqlalchemy.orm import relationship
import json
from datetime import date, datetime, timedelta

CHPT_REG = None #реестр всех уникальных разделов
with open(f"{DB_PATH}chapterReg.txt", "r") as reg:
    CHPT_REG = set(reg.read().split(','))

class book(base):
    __tablename__ = "books"

    id = Column(Integer, primary_key=True, autoincrement=True)
    title = Column(String, nullable=False)
    unique_number = Column(String, nullable=False, unique=True)
    author = Column(String, nullable=True)
    year = Column(Integer, nullable=True) #год издания
    publishment = Column(String, nullable=True) #издательство
    publish_city = Column(String, nullable=True) #город издательства
    chapter = Column(String, nullable=True) #раздел
    read_count = Column(Integer, nullable=False, server_default="0") #количество прочтений

    readers = relationship("book_rent")

    def __init__(self, title: str, unique_number: str, author: str = None, year: int = None, publishment: str = None, publish_city: str = None,  chapter: str = None, read_count: int = 0):
        self.title = title
        self.unique_number = unique_number
        self.author = author
        self.year = year
        self.publishment = publishment
        self.publish_city = publish_city
        self.read_count = read_count
        self.chapter = chapter

        with open(f"{DB_PATH}chapterReg.txt", "a") as reg:
            if chapter not in CHPT_REG:
                CHPT_REG.add(chapter)
                reg.write(',' + chapter)

    def __repr__(self):
        return json.dumps({
            "id" : self.id,
            "title" : self.title,
            "unique_number" : self.unique_number,
            "author" : self.author,
            "year" : self.year,
            "publishment" : self.publishment,
            "publish_city" : self.publish_city,
            "read_count" : self.read_count,
            "chapter" : self.chapter
        }, ensure_ascii=False)
    def getStatus(self) -> str:
        if not self.readers or self.readers[-1].getStatus == "Закрыто":
            return ("В наличии", '', '')
        elif self.readers[-1] == "Просрочено":
            return ("Аренда просрочена", str(self.readers[-1].rentdate), str(self.readers[-1].date_limit))
        return ("В аренде", str(self.readers[-1].rentdate), str(self.readers[-1].date_limit))
    #def updateTitle(self, new):
    #    self.title = new
    #def updateAuthor(self, new):
    #    self.author = new
    #def updateYear(self, new):
    #    self.year = new
    #def updatePublishment(self, new):
    #    self.publishment = new
    #def updatePublish_city(self, new):
    #    self.publish_city = new
    #def updateChapter(self, new):
    #    self.chapter = new
    #def updateRead_count(self, new):
    #    self.read_count = new
    
