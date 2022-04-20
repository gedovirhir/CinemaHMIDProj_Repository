from sqlalchemy.orm import relationship
from sqlalchemy import Column, String, Integer, Boolean, CheckConstraint, ForeignKey
from .database import base 
import json

SEATS_TYPES=["regular", "d-box"]
class seat(base):
    __tablename__ = "seats"

    id = Column(Integer, primary_key=True, autoincrement=True)
    hall_n = Column(Integer, nullable=False)
    row_n = Column(Integer, nullable=False)
    seat_n = Column(Integer, nullable=False)
    seat_type = Column(String, nullable=False)
    status = Column(Boolean, nullable=False)
    #movie_id = Column(Integer, ForeignKey('movies.id'), nullable=True)
    
    __table_args__ = (
        CheckConstraint(f'seat_type IN {str(SEATS_TYPES).replace("[","(").replace("]",")")}'), #############################
    )
    def __init__(self, hall_n: int, row_n: int, seat_n: int, seat_type: str, status: bool):
        self.hall_n = hall_n
        self.row_n = row_n
        self.seat_n = seat_n
        self.seat_type = seat_type
        self.status = status
        #self.movie_id = movieid
    def __repr__(self) -> str:
        return json.dumps({
            "id" : self.id,
            "hall_n" : self.hall_n,
            "row_n" : self.row_n,
            "seat_n" : self.seat_n,
            "seat_type" : self.seat_type,
            "status" : self.status
        }, ensure_ascii=False)