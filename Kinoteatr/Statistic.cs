using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Kinoteatr
{
    public partial class Statistic : Form
    {
        public SessionStatisticList sessionsFromAPI = default;
        public MovieStatisticList moviesFromAPI = default;
        public Statistic()
        {
            InitializeComponent();
        }

        public Statistic(MainMenu mainMenuForm)
        {
            InitializeComponent();

            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request1 = WebRequest.Create("http://25.46.163.182:8080/stat/getSeance?title&MovieYear&duration&publisher&genre&limit=100&offset&SeanceYear&month&day&hour&hall_n");
            WebResponse response1 = request1.GetResponse();
            using (Stream stream = response1.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        jsonLine += line;
                    }
                }
            }

            sessionsFromAPI = JsonConvert.DeserializeObject<SessionStatisticList>(jsonLine);

            for (int i = 0; i < sessionsFromAPI.body.Length; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = sessionsFromAPI.body[i].title;
                dataGridView2.Rows[i].Cells[1].Value = sessionsFromAPI.body[i].datetime;
                dataGridView2.Rows[i].Cells[2].Value = sessionsFromAPI.body[i].hall_n;
                dataGridView2.Rows[i].Cells[3].Value = sessionsFromAPI.body[i].profit;
                dataGridView2.Rows[i].Cells[4].Value = sessionsFromAPI.body[i].regularSeatsProfit;
                dataGridView2.Rows[i].Cells[5].Value = sessionsFromAPI.body[i].dboxSeatsProfit;
                dataGridView2.Rows[i].Cells[6].Value = sessionsFromAPI.body[i].ticketSoldet;
                dataGridView2.Rows[i].Cells[7].Value = sessionsFromAPI.body[i].regularTicketSoldet;
                dataGridView2.Rows[i].Cells[8].Value = sessionsFromAPI.body[i].dboxTicketSoldet;
            }

            jsonLine = "";

            WebRequest request2 = WebRequest.Create("http://25.46.163.182:8080/stat/getMovie?title=&year=&duration=&publisher=&genre=&limit&offset");
            WebResponse response2 = request2.GetResponse();
            using (Stream stream = response2.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        jsonLine += line;
                    }
                }
            }

            moviesFromAPI = JsonConvert.DeserializeObject<MovieStatisticList>(jsonLine);

            for (int i = 0; i < moviesFromAPI.body.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = moviesFromAPI.body[i].title;
                dataGridView1.Rows[i].Cells[1].Value = moviesFromAPI.body[i].profit;
                dataGridView1.Rows[i].Cells[2].Value = moviesFromAPI.body[i].regularSeatsProfit;
                dataGridView1.Rows[i].Cells[3].Value = moviesFromAPI.body[i].dboxSeatsProfit;
                dataGridView1.Rows[i].Cells[4].Value = moviesFromAPI.body[i].ticketSoldet;
                dataGridView1.Rows[i].Cells[5].Value = moviesFromAPI.body[i].regularTicketSoldet;
                dataGridView1.Rows[i].Cells[6].Value = moviesFromAPI.body[i].dboxTicketSoldet;
            }
        }
    }
}
