from .database import base, session, DB_PATH
from .movie_genre import movie_genre

from sqlalchemy import Column, String, Integer
from sqlalchemy.orm import relationship
from sqlalchemy.ext.hybrid import hybrid_method, hybrid_property
import json
from datetime import date

class movie(base):
    __tablename__ = "movies"

    id = Column(Integer, primary_key=True, autoincrement=True)
    title = Column(String, nullable=False)
    year = Column(String, nullable=False)
    duration = Column(Integer, nullable=False)
    publisher = Column(String, nullable=True)

    #all_genres = relationship("movie_genre", backref="movie")

    def __init__(self, title: str, year: str, duration: int, publisher: str = ''):
        self.title = title
        self.year = year
        self.duration = duration
        self.publisher = publisher
    def __repr__(self):
        res = {
            "id" : self.id,
            "title" : self.title,
            "year" : self.year,
            "duration" : self.duration,
            "publisher" : self.publisher,
            "genres" : self.getGenres
        }
        return json.dumps(res, ensure_ascii=False)
    def addGenres(self, genres_id: list, s):
        for i in genres_id:
            s.add(movie_genre(self.id, i))
            s.commit()
    @hybrid_property
    def getGenres(self):
        return [i.genre.title for i in self.all_genres]