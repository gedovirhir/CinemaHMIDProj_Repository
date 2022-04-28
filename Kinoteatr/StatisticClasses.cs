using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    public class SessionStatistic
    {
        //"title": "Мистер Нокаут", "datetime": "2022-03-01 08:00:00", "hall_n": 0, "profit": 1800, 
        //"regularSeatsProfit": 1500, "dboxSeatsProfit": 300, "ticketSoldet": 40, "regularTicketSoldet": 50, "dboxTicketSoldet": 25
        public uint hall_n, profit, regularSeatsProfit, dboxSeatsProfit, ticketSoldet, 
            regularTicketSoldet, dboxTicketSoldet;
        public string title, datetime;

        public SessionStatistic(uint inputHallNumber, uint inputProfit, uint regularSeatsProfitInput, 
            uint dboxSeatsProfitInput, uint ticketSoldetInput, uint regularTicketSoldetInput, 
            uint dboxTicketSoldetInput, string titleInput, string datetimeInput)
        {
            hall_n = inputHallNumber;
            profit = inputProfit;
            regularSeatsProfit = regularSeatsProfitInput;
            dboxSeatsProfit = dboxSeatsProfitInput;
            ticketSoldet = ticketSoldetInput;
            regularTicketSoldet = regularTicketSoldetInput;
            dboxTicketSoldet = dboxTicketSoldetInput;
            title = titleInput;
            datetime = datetimeInput;
        }
    }
    public class SessionStatisticList
    {
        public string message;
        public SessionStatistic[] body = new SessionStatistic[999];
    }

    public class MovieStatistic
    {
        //"title": "Мистер Нокаут", "profit": 45850, "regularSeatsProfit": 45850, "dboxSeatsProfit": 45850, 
        //"ticketSoldet": 40, "regularTicketSoldet": 50, "dboxTicketSoldet": 25
        public uint profit, regularSeatsProfit, dboxSeatsProfit, ticketSoldet, regularTicketSoldet, dboxTicketSoldet;
        public string title;

        public MovieStatistic(uint inputProfit, uint regularSeatsProfitInput,
            uint dboxSeatsProfitInput, uint ticketSoldetInput, uint regularTicketSoldetInput,
            uint dboxTicketSoldetInput, string titleInput)
        {
            profit = inputProfit;
            regularSeatsProfit = regularSeatsProfitInput;
            dboxSeatsProfit = dboxSeatsProfitInput;
            ticketSoldet = ticketSoldetInput;
            regularTicketSoldet = regularTicketSoldetInput;
            dboxTicketSoldet = dboxTicketSoldetInput;
            title = titleInput;
        }
    }
    public class MovieStatisticList
    {
        public string message;
        public MovieStatistic[] body = new MovieStatistic[999];
    }
}
