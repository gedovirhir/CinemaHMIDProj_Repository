from sqlalchemy import Column, String, Integer
from .database import base

class librarian(base):
    __tablename__ = "librarians"

    id = Column(Integer, primary_key=True, autoincrement=True)
    name = Column(String, nullable=False)
    surname = Column(String, nullable=False)
    patronymic = Column(String, nullable=False)
    telnumber = Column(String, nullable=False)
    email = Column(String, nullable=False)
    password = Column(String, nullable=False)

    def __init__(self, name: str, surname: str, patronymic: str, telnumber: str, email: str, password: str):
        self.name = name
        self.surname = surname
        self.patronymic = patronymic
        self.telnumber = telnumber
        self.email = email
        self.password = password
    def __repr__(self) -> str:
        return str({
            "name" : self.name,
            "surname" : self.surname,
            "patronymic" : self.patronymic,
            "telnumber" : self.telnumber,
            "email" : self.email,
            "password" : self.password,
        })
