using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    public class Ticket
    {
        //"id": 1, "seanceId": 1, "title": "Мистер Нокаут", "date_time": "2022-03-01 08:00:00", "hall_n": 0, "row_n": 0, "seat_n": 0, "seat_type": "d-box", "price": 150
        public uint id, hall_n, seanceId, row_n, seat_n, price;
        public string title, date_time, seat_type;

        public Ticket(uint inputId, uint inputSeanceId, string inputMovieTitle, string inputDateTime, uint inputHallNumber, uint inputRowNumber, uint inputSeatNumber, string inputSeatType, uint inputPrice)
        {
            id = inputId;
            seanceId = inputSeanceId;
            title = inputMovieTitle;
            date_time = inputDateTime;
            hall_n = inputHallNumber;
            row_n = inputRowNumber;
            seat_n = inputSeatNumber;
            seat_type = inputSeatType;
            price = inputPrice;
        }
    }
    public class TicketsList
    {
        public string message;
        public Ticket[] body = new Ticket[999];
    }
}
