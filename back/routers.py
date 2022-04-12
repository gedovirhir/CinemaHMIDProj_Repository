import argparse
import bd_query as back
from bd_query import coalesce, ERRJS, SUCJS

from flask_cors import CORS
from flask import Flask, request
import json
from datetime import date, datetime, timedelta
from re import M, match

app = Flask(__name__)
CORS(app)

@app.route('/aut', methods=['POST'])
def autf():
    r = request.json
    return back.autLibrarian(
        r['email'],
        r['password']
    )
@app.route('/rent/create')
def rentCreate():
    r = request.args
    func = back.createRent
    return func(
        r['readerId'],
        r['bookId'],
        coalesce(r['rentDate'],func.__defaults__[0]),
        coalesce(r['dayLimit'],func.__defaults__[1])
    )
@app.route('/rent/close')
def rentClose():
    r = request.args
    return back.closeRent(
        r['rentId']
    )
@app.route('/rent/get')
def rentGet():
    r = request.args
    rentDate = datetime.strptime(r['rentDate'], "%Y-%m-%d").date() if match(r'\S{4}-\S{1,2}-\S{1,2}', r['rentDate']) else ''
    date_limit = datetime.strptime(r['date_limit'], "%Y-%m-%d").date() if match(r'\S{4}-\S{1,2}-\S{1,2}', r['rentDate']) else ''
    return back.getRentsInfoById(json.loads(back.getFiltredRents(
        r['readerId'],
        r['bookId'],
        rentDate,
        date_limit,
        coalesce(r['status'],back.getFiltredRents.__defaults__[4]),
        coalesce(r['limit'],back.getFiltredRents.__defaults__[5]),
        coalesce(r['offset'],back.getFiltredRents.__defaults__[6])
    ))['body'])
@app.route('/books/get')
def booksGet():
    r=request.args
    return back.getBooksInfoById(json.loads(back.getFiltredBooks(
        r['title'],
        r['unique_number'],
        r['author'],
        r['year'],
        r['publishment'],
        r['publish_city'],
        r['chapter'],
        coalesce(r['limit'],back.getFiltredRents.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredRents.__defaults__[-1])
    ))['body'])
@app.route('/books/add')
def bookAdd():
    r=request.args
    return back.addBook(
        r['title'],
        r['unique_number'],
        r['author'],
        r['year'],
        r['publishment'],
        r['publish_city'],
        r['chapter']
    )
@app.route('/books/update')
def bookUpdate():
    r = request.args
    return back.updateBookData(
        r['bookId'],
        r['title'],
        r['unique_number'],
        r['author'],
        r['year'],
        r['publishment'],
        r['publish_city'],
        r['chapter']
    )
@app.route('/readers/get')
def readersGet(): #name: str = "", surname: str = "", patronymic: str = "", passport: str = "", address: str = "", telnumber: str = "", email: str = ""):
    r = request.args
    return back.getReadersInfoById(json.loads(back.getFiltredReaders(
        r['name'],
        r['surname'],
        r['patronymic'],
        r['passport'],
        r['address'],
        r['telnumber'],
        r['email']
    ))['body'])
@app.route('/readers/add')
def readersAdd():
    r = request.args
    return back.addReader(
        r['name'],
        r['surname'],
        r['patronymic'],
        r['passport'],
        r['address'],
        r['telnumber'],
        r['email']
    )
@app.route('/readers/update')
def readersUpdate():
    r = request.args
    return back.updateReader(
        r['readerId'],
        r['name'],
        r['surname'],
        r['patronymic'],
        r['passport'],
        r['address'],
        r['telnumber'],
        r['email']
    )
@app.route('/rent/getOverdueBooks')
def rentGetBooks():
    r = request.args
    return back.getBooksInfoById(json.loads(back.getOverdueBooks())['body'])
@app.route('/rent/getOverdueReaders')
def rentGetReaderss():
    r = request.args
    return back.getReadersInfoById(json.loads(back.getOverdueReaders())['body'])