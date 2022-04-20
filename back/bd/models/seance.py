from sqlalchemy import Column, Integer, DateTime, ForeignKey, func
from datetime import datetime
from .database import base, session
from sqlalchemy.orm import relationship
from sqlalchemy.ext.hybrid import hybrid_method, hybrid_property
import json

class seance(base):
    __tablename__ = "seances"

    id = Column(Integer, primary_key=True, autoincrement=True)
    movie_id = Column(Integer(), ForeignKey('movies.id',onupdate="CASCADE", ondelete="CASCADE"), nullable=False)
    date_time = Column(DateTime, nullable=False)
    hall_n = Column(Integer, nullable=False)
    #Ограничение на hall n, чтобы соответствовало реальности
    movies = relationship("movie", backref="all_seances")
    def __init__(self, movie_id: int, date_time: datetime, hall_n: int):
        self.movie_id = movie_id
        self.date_time = date_time
        self.hall_n = hall_n
    def __repr__(self):
        return json.dumps({
            "id" : self.id,
            "movie_id" : self.movie_id,
            "date_time" : str(self.date_time),
            "hall_n" : self.hall_n
        }, ensure_ascii=False)
    @hybrid_property
    def getYear(self):
        return self.date_time.year
    #@getYear.expression
    #def getYear(cls):
    #    return cls.year
    @hybrid_property
    def getMonth(self):
        return self.date_time.month
    @hybrid_property
    def getDay(self):
        return self.date_time.day
    @hybrid_property
    def getHour(self):
        return self.date_time.hour
    @hybrid_method
    def getDate(self):
        return self.date_time
