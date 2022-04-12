from sqlalchemy.orm import relationship
from sqlalchemy import Column, String, Integer
from .database import base 

class reader(base):
    __tablename__ = "readers"

    id = Column(Integer, primary_key=True, autoincrement=True)
    name = Column(String, nullable=False)
    surname = Column(String, nullable=False)
    patronymic = Column(String, nullable=False)
    address = Column(String, nullable=False)
    passport = Column(String, unique=True, nullable=False) 
    telnumber = Column(String, unique=True)
    email = Column(String, unique=True)

    books = relationship("book_rent")

    def __init__(self, name: str, surname: str, patronymic: str, passport: str, address: str, telnumber: str, email: str):
        self.name = name
        self.surname = surname
        self.patronymic = patronymic
        self.passport = passport
        self.address = address
        self.telnumber = telnumber
        self.email = email
    def __repr__(self) -> str:
        return f" 'id' : {self.id}, 'name' : {self.name}, 'surname' : {self.surname}, 'patronymic' : {self.patronymic}, 'passport' : {self.passport}, 'address' : {self.address}, 'telnumber' : {self.telnumber}, 'email' : {self.email}"
