using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Kinoteatr
{
    public partial class Sessions : Form
    {
        public SessionsList sessionsFromAPI = default;
        public Sessions()
        {
            InitializeComponent();
        }

        public Sessions(MainMenu mainMenuForm)
        {
            InitializeComponent();

            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create("http://25.46.163.182:8080/seance/get?title&MovieYear&duration&publisher&genre&limit=100&offset&SeanceYear&month&day&hour&hall_n");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
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

            sessionsFromAPI = JsonConvert.DeserializeObject<SessionsList>(jsonLine);

            for (int i = 0; i < sessionsFromAPI.body.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = sessionsFromAPI.body[i].id;
                dataGridView1.Rows[i].Cells[1].Value = sessionsFromAPI.body[i].movie_id;
                dataGridView1.Rows[i].Cells[2].Value = sessionsFromAPI.body[i].movieTitle;
                dataGridView1.Rows[i].Cells[3].Value = sessionsFromAPI.body[i].date_time;
                dataGridView1.Rows[i].Cells[4].Value = sessionsFromAPI.body[i].hall_n;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Clear();

            bool[] notNullInputCheck = { true, true, true };

            if (ActiveText1.Text == "") notNullInputCheck[0] = false;
            if (ActiveText2.Text == "") notNullInputCheck[1] = false;
            if (ActiveText3.Text == "") notNullInputCheck[2] = false;

            int addCount = 0;
            for (int i = 0; i < sessionsFromAPI.body.Length; i++)
            {
                if (((sessionsFromAPI.body[i].movieTitle == ActiveText1.Text) || !notNullInputCheck[0]) && ((sessionsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1]) && ((sessionsFromAPI.body[i].date_time == ActiveText3.Text) || !notNullInputCheck[2]))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[addCount].Cells[0].Value = sessionsFromAPI.body[i].id;
                    dataGridView1.Rows[addCount].Cells[1].Value = sessionsFromAPI.body[i].movie_id;
                    dataGridView1.Rows[addCount].Cells[2].Value = sessionsFromAPI.body[i].movieTitle;
                    dataGridView1.Rows[addCount].Cells[3].Value = sessionsFromAPI.body[i].date_time;
                    dataGridView1.Rows[addCount].Cells[4].Value = sessionsFromAPI.body[i].hall_n;
                    addCount++;
                }
            }

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sessionMovieTitle = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sessionDateTime = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sessionHallNum = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();

            List<string> dateTimeSplited = new List<string>();
            string[] buff = sessionDateTime.Split('-');
            for(int i = 0; i < 3; i++) dateTimeSplited.Add(buff[i]);
            buff = buff[2].Split(' ');
            dateTimeSplited[2] = buff[0];
            dateTimeSplited.Add(buff[1]);


            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create($"http://25.46.163.182:8080/ticket/get?title&MovieYear&duration&publisher&genre&SeanceYear={dateTimeSplited[0]}&month={dateTimeSplited[1]}&day={dateTimeSplited[2]}&hour&hall_n={sessionHallNum}&seat_n&seat_type&limit=10000+&offset&row_n&price&sold_status&booking_status");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
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

            TicketsList ticketsFromAPI = JsonConvert.DeserializeObject<TicketsList>(jsonLine);

            TicketsList currSessionTickets = ticketsFromAPI;
            int currSessionTicketsCount = 0;

            foreach (Ticket i in ticketsFromAPI.body)
            {
                if(i.hall_n == Convert.ToUInt32(sessionHallNum) && i.title == sessionMovieTitle && i.date_time == sessionDateTime)
                {
                    currSessionTickets.body[currSessionTicketsCount] = i;
                    currSessionTicketsCount++;
                    if(i.row_n == 1)
                    {
                        if (i.seat_n == 1)
                        {
                            button2.BackColor = Color.Green;
                            button2.Text = i.price.ToString();
                        }
                        if (i.seat_n == 2)
                        {
                            button3.BackColor = Color.Green;
                            button3.Text = i.price.ToString();
                        }
                        if (i.seat_n == 3)
                        {
                            button4.BackColor = Color.Green;
                            button4.Text = i.price.ToString();
                        }
                        if (i.seat_n == 4)
                        {
                            button5.BackColor = Color.Green;
                            button5.Text = i.price.ToString();
                        }
                        if (i.seat_n == 5)
                        {
                            button6.BackColor = Color.Green;
                            button6.Text = i.price.ToString();
                        }
                    }
                    if (i.row_n == 2)
                    {
                        if (i.seat_n == 1)
                        {
                            button7.BackColor = Color.Green;
                            button7.Text = i.price.ToString();
                        }
                        if (i.seat_n == 2)
                        {
                            button8.BackColor = Color.Green;
                            button8.Text = i.price.ToString();
                        }
                        if (i.seat_n == 3)
                        {
                            button9.BackColor = Color.Green;
                            button9.Text = i.price.ToString();
                        }
                        if (i.seat_n == 4)
                        {
                            button10.BackColor = Color.Green;
                            button10.Text = i.price.ToString();
                        }
                        if (i.seat_n == 5)
                        {
                            button11.BackColor = Color.Green;
                            button11.Text = i.price.ToString();
                        }
                    }
                    if (i.row_n == 3)
                    {
                        if (i.seat_n == 1)
                        {
                            button12.BackColor = Color.Green;
                            button12.Text = i.price.ToString();
                        }
                        if (i.seat_n == 2)
                        {
                            button13.BackColor = Color.Green;
                            button13.Text = i.price.ToString();
                        }
                        if (i.seat_n == 3)
                        {
                            button14.BackColor = Color.Green;
                            button14.Text = i.price.ToString();
                        }
                        if (i.seat_n == 4)
                        {
                            button15.BackColor = Color.Green;
                            button15.Text = i.price.ToString();
                        }
                        if (i.seat_n == 5)
                        {
                            button16.BackColor = Color.Green;
                            button16.Text = i.price.ToString();
                        }
                    }
                    if (i.row_n == 4)
                    {
                        if (i.seat_n == 1)
                        {
                            button17.BackColor = Color.Green;
                            button17.Text = i.price.ToString();
                        }
                        if (i.seat_n == 2)
                        {
                            button18.BackColor = Color.Green;
                            button18.Text = i.price.ToString();
                        }
                        if (i.seat_n == 3)
                        {
                            button19.BackColor = Color.Green;
                            button19.Text = i.price.ToString();
                        }
                        if (i.seat_n == 4)
                        {
                            button20.BackColor = Color.Green;
                            button20.Text = i.price.ToString();
                        }
                        if (i.seat_n == 5)
                        {
                            button21.BackColor = Color.Green;
                            button21.Text = i.price.ToString();
                        }
                    }
                }
            }



        }

        private void ToTickets_Click(object sender, System.EventArgs e)
        {

        }

    }
}
