from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy.engine import Engine
from sqlalchemy import event
import psycopg2

DATABASE_NAME = "cinemabd"
DB_PATH = "back/bd/"

engine = create_engine(f'postgresql+psycopg2://postgres:admin@localhost/{DATABASE_NAME}', isolation_level="AUTOCOMMIT")
session = sessionmaker(bind=engine)

base = declarative_base()

#@event.listens_for(Engine, "connect")
#def set_sqlite_pragma(dbapi_connection, connection_record):
#    cursor = dbapi_connection.cursor()
#    cursor.execute("PRAGMA foreign_keys=ON")
#    cursor.close()

def create_db():
    base.metadata.create_all(engine)

