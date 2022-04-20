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
    return back.autAccountant(
        r['email'],
        r['password']
    )
@app.route('/movie/get')
def rentGet():
    r = request.args
    return back.getMoviesInfoById(json.loads(back.getFiltredMovies(
        r['title'],
        r['year'],
        r['duration'],
        r['publisher'],
        r['genre'],
        coalesce(r['limit'],back.getFiltredMovies.__defaults__[5]),
        coalesce(r['offset'],back.getFiltredMovies.__defaults__[6])
    ))['body'])
@app.route('/seance/get')
def booksGet():
    r=request.args
    movie_id = json.loads(back.getFiltredMovies(
        r['title'],
        r['MovieYear'],
        r['duration'],
        r['publisher'],
        r['genre'],
        coalesce(r['limit'],back.getFiltredMovies.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredMovies.__defaults__[-1])
    ))['body']
    return back.getSeancesInfoById(json.loads(back.getFiltredSeances(
        movie_id,
        r['SeanceYear'],
        r['month'],
        r['day'],
        r['hour'],
        r['hall_n'],
        coalesce(r['limit'],back.getFiltredSeances.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredSeances.__defaults__[-1])
    ))['body'])
@app.route('/ticket/get')
def readersGet():
    r = request.args
    movie_id = json.loads(back.getFiltredMovies(
        r['title'],
        r['MovieYear'],
        r['duration'],
        r['publisher'],
        r['genre'],
        coalesce(r['limit'],back.getFiltredMovies.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredMovies.__defaults__[-1])
    ))['body']
    seance_id = json.loads(back.getFiltredSeances(
        movie_id,
        r['SeanceYear'],
        r['month'],
        r['day'],
        r['hour'],
        r['hall_n'],
        coalesce(r['limit'],back.getFiltredSeances.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredSeances.__defaults__[-1])
    ))['body']
    seat_id = json.loads(back.getFiltredSeats( #hall_n: int = None, row_n: int = None, seat_n: int = None, seat_type
        r['hall_n'],
        r['row_n'],
        r['seat_n'],
        r['seat_type'],
        coalesce(r['limit'],back.getFiltredSeats.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredSeats.__defaults__[-1])
    ))['body']
    return back.getTicketsInfoById(json.loads(back.getFiltredTickets(
        seance_id,
        seat_id,
        r['price'],
        r['sold_status'],
        r['booking_status'],
        coalesce(r['limit'],back.getFiltredTickets.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredTickets.__defaults__[-1])
    ))['body'])
@app.route('/stat/getMovie') ###########
def statGetMovie():
    r = request.args
    movie_id = json.loads(back.getFiltredMovies(
        r['title'],
        r['year'],
        r['duration'],
        r['publisher'],
        r['genre'],
        coalesce(r['limit'],back.getFiltredMovies.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredMovies.__defaults__[-1])
    ))['body']
    return back.getMovieStat(
        movie_id,
    )
@app.route('/stat/getSeance')
def statGetSeance():
    r = request.args
    movie_id = json.loads(back.getFiltredSeances(
        r['title'],
        r['MovieYear'],
        r['duration'],
        r['publisher'],
        r['genre'],
        coalesce(r['limit'],back.getFiltredSeances.__defaults__[-2]),
        coalesce(r['offset'],back.getFiltredSeances.__defaults__[-1])
    ))['body']
    seance_id = json.loads(back.getFiltredSeances(
        movie_id,
        r['SeanceYear'],
        r['month'],
        r['day'],
        r['hour'],
        r['hall_n']
    ))['body']
    return back.getSeanceStat()(
        seance_id
    )