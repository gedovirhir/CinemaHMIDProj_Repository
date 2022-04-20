from sqlalchemy import Column, Integer, ForeignKey, Boolean
from sqlalchemy.orm import relationship
from .database import base
from sqlalchemy.ext.hybrid import hybrid_method, hybrid_property
from sqlalchemy.sql import case
from sqlalchemy import and_
import json


class ticket(base):
    __tablename__ = "tickets"

    id = Column(Integer, primary_key=True, autoincrement=True)
    seance_id = Column(Integer(), ForeignKey('seances.id', onupdate="CASCADE", ondelete="CASCADE"), nullable=False)
    seat_id = Column(Integer(), ForeignKey('seats.id', onupdate="CASCADE", ondelete="CASCADE"), nullable=False)
    price = Column(Integer, nullable=False) 
    sold_status = Column(Boolean, nullable=False)
    booking_status = Column(Boolean, nullable=False)

    seance = relationship("seance", backref="all_tickets")
    seat = relationship("seat", backref="all_tickets")

    def __init__(self, seance_id: int, seat_id: int, price: int, sold_status: bool, booking_status: bool): 
        self.seance_id = seance_id
        self.seat_id = seat_id
        self.price = price
        self.sold_status = sold_status
        self.booking_status = booking_status
    def __repr__(self):
        return json.dumps({
            "id" : self.seance_id,
            "seance_id" : self.seance_id,
            "seat_id" : self.seat_id,
            "price" : self.price,
            "sold_status" : self.sold_status,
            "booking_status" : self.booking_status
        }, ensure_ascii=False)
    #@hybrid_property
    #def isActive(self):
    #    return self.status == "Активно"
    #@hybrid_property
    #def isDateLimitOverdue(self):
    #    return self.date_limit < date.today()
    #@hybrid_property
    #def getStatus(self):
    #    if self.isActive:
    #        if self.isDateLimitOverdue:
    #            return "Просрочено"
    #    return self.status
    #@getStatus.expression
    #def getStatus(cls):
    #    return case([
    #        (and_(cls.isDateLimitOverdue,cls.isActive), "Просрочено")
    #    ], else_=cls.status) 
    #def closeRent(self, date = date.today()):
    #    self.status = "Закрыто"
    #    self.date_limit = date
#