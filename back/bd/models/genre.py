from sqlalchemy import Column, String, Integer
from .database import base

class genre(base):
    __tablename__ = "genres"

    id = Column(Integer, primary_key=True, autoincrement=True)
    title = Column(String, unique=True, nullable=False)

    def __init__(self, title: str):
        self.title = title
    def __repr__(self):
        return self.title