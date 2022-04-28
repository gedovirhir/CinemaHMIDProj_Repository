using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    public class Session
    {
        //"id": 1, "movie_id": 1, "movieTitle": "Мистер Нокаут", "date_time": "2022-03-01 08:00:00", "hall_n": 0
        public uint id, movie_id, hall_n;
        public string movieTitle, date_time;

        public Session(uint inputId, uint inputMovieId, uint inputHallNumber, string inputMovieTitle, string inputDateTime)
        {
            id = inputId;
            movie_id = inputMovieId;
            hall_n = inputHallNumber;
            movieTitle = inputMovieTitle;
            date_time = inputDateTime;
        }
    }
    public class SessionsList
    {
        public string message;
        public Session[] body = new Session[999];
    }
}
