from sqlalchemy import Column, Integer, Date, ForeignKey, String
from sqlalchemy.orm import relationship
from .database import base
from datetime import date
from sqlalchemy.ext.hybrid import hybrid_method, hybrid_property
from sqlalchemy.sql import case
from sqlalchemy import and_


class book_rent(base):
    __tablename__ = "book_rent"

    id = Column(Integer, primary_key=True, autoincrement=True)
    reader_id = Column(Integer(), ForeignKey('readers.id', onupdate="CASCADE", ondelete="CASCADE"), nullable=False)
    book_id = Column(Integer(), ForeignKey('books.id', onupdate="CASCADE", ondelete="CASCADE"), nullable=False)
    rentdate = Column(Date, nullable=False) #год месяц день 
    date_limit = Column(Date, nullable=False)
    status = Column(String, nullable=False)

    reader = relationship("reader") # ,backref="book_rent") чтобы узнать арендованные читателем книги reader.book_rented
    book = relationship("book") # , backref="reader_tenant") чтобы узнать арендатора книпи book.reader_tenant

    def __init__(self, reader_id: int, book_id: int, rentdate: str, date_limit: str): 
        self.reader_id = reader_id
        self.book_id = book_id
        self.rentdate = rentdate
        self.date_limit = date_limit
        self.status = "Активно"
    
    def __repr__(self):
        return str({
            "id" : self.id,
            "reader_id" : self.reader_id,
            "book_id" : self.book_id,
            "rentdate" : self.rentdate,
            "date_limit" : self.date_limit, 
            "status" : self.getStatus
        })
    @hybrid_property
    def isActive(self):
        return self.status == "Активно"
    @hybrid_property
    def isDateLimitOverdue(self):
        return self.date_limit < date.today()
    @hybrid_property
    def getStatus(self):
        if self.isActive:
            if self.isDateLimitOverdue:
                return "Просрочено"
        return self.status
    @getStatus.expression
    def getStatus(cls):
        return case([
            (and_(cls.isDateLimitOverdue,cls.isActive), "Просрочено")
        ], else_=cls.status) 
    def closeRent(self, date = date.today()):
        self.status = "Закрыто"
        self.date_limit = date
