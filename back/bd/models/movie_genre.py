from sqlalchemy import Column, Integer, ForeignKey
from sqlalchemy.orm import relationship

from .database import base

class movie_genre(base):
    __tablename__ = "movies_genres"

    movie_id = Column(Integer(), ForeignKey('movies.id',onupdate="CASCADE", ondelete="CASCADE"), nullable=False, primary_key=True) #onupdate="CASCADE", ondelete="CASCADE"
    genre_id = Column(Integer(), ForeignKey('genres.id',onupdate="CASCADE", ondelete="CASCADE"), nullable=False, primary_key=True)

    movie = relationship("movie", backref="all_genres")
    genre = relationship("genre", backref="all_movies")

    def __init__(self, movie_id: int, genre_id: int):
        self.movie_id = movie_id
        self.genre_id = genre_id
    def __repr__(self):
        return str((self.movie_id, self.genre_id))