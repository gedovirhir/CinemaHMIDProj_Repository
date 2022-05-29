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
        List<string> argsForTickets = new List<string>();
        public Sessions()
        {
            InitializeComponent();
        }

        public Sessions(MainMenu mainMenuForm) 
        {
            InitializeComponent();

            string jsonLine = default; // Получение результата запроса

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create("http://localhost:8080/seance/get?title&MovieYear&duration&publisher&genre&limit=100&offset&SeanceYear&month&day&hour&hall_n");
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

            for (int i = 0; i < sessionsFromAPI.body.Length; i++) // Запись значений в таблицу
            {
                string[] buff = sessionsFromAPI.body[i].date_time.Split(' ');

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = sessionsFromAPI.body[i].movieTitle;
                dataGridView1.Rows[i].Cells[1].Value = sessionsFromAPI.body[i].hall_n;
                dataGridView1.Rows[i].Cells[2].Value = buff[0];
                dataGridView1.Rows[i].Cells[3].Value = buff[1].Substring(0, buff[1].Length - 3);
            }
        }

        private void button1_Click(object sender, System.EventArgs e) // Нажата кнопка поиска
        {
            dataGridView1.Rows.Clear();

            bool[] notNullInputCheck = { true, true, true, true }; // Проверка, какие поля поиска пустые

            if (ActiveText1.Text == "") notNullInputCheck[0] = false;
            if (ActiveText2.Text == "") notNullInputCheck[1] = false;
            if (ActiveText3.Text == "") notNullInputCheck[2] = false;
            if (ActiveText4.Text == "") notNullInputCheck[3] = false;

            int addCount = 0;
            for (int i = 0; i < sessionsFromAPI.body.Length; i++) // Заполнение таблицы результатом поиска
            {
                string[] buff = sessionsFromAPI.body[i].date_time.Split(' ');
                if (((sessionsFromAPI.body[i].movieTitle == ActiveText1.Text) || !notNullInputCheck[0]) 
                    && ((sessionsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1]) 
                    && ((buff[0] == ActiveText3.Text) || !notNullInputCheck[2]) 
                    && ((buff[1] == (ActiveText4.Text + ":00")) || !notNullInputCheck[3]))
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[addCount].Cells[0].Value = sessionsFromAPI.body[i].movieTitle;
                    dataGridView1.Rows[addCount].Cells[1].Value = sessionsFromAPI.body[i].hall_n;
                    dataGridView1.Rows[addCount].Cells[2].Value = buff[0];
                    dataGridView1.Rows[addCount].Cells[3].Value = buff[1].Substring(0, buff[1].Length - 3);
                    addCount++;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Клик по ячейке таблицы
        {
            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value == null)
            {
                return;
            }
            ToTickets.Visible = true; // Показываем кнопку информации о билетах

            // Получаем данные текущей строки
            string sessionMovieTitle = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sessionHallNum = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sessionDateTime = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()
                + " " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() + ":00";

            argsForTickets.Clear();
            argsForTickets.Add(sessionMovieTitle);
            argsForTickets.Add(sessionHallNum);
            argsForTickets.Add(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());
            argsForTickets.Add(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() + ":00");

            List<string> dateTimeSplited = new List<string>();
            string[] buff = sessionDateTime.Split('-');
            for(int i = 0; i < 3; i++) dateTimeSplited.Add(buff[i]);
            buff = buff[2].Split(' ');
            dateTimeSplited[2] = buff[0];
            dateTimeSplited.Add(buff[1]);

            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create($"http://localhost:8080/ticket/get?title&MovieYear&duration&publisher&genre&SeanceYear={dateTimeSplited[0]}&month={dateTimeSplited[1]}&day={dateTimeSplited[2]}&hour&hall_n={sessionHallNum}&seat_n&seat_type&limit=10000+&offset&row_n&price&sold_status&booking_status");
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
                            if (i.sold_status)
                            {
                                button2.BackColor = Color.Green;
                                button2.Text = i.price.ToString();
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = i.price.ToString();
                            }
                            
                        }
                        if (i.seat_n == 2)
                        {
                            if (i.sold_status)
                            {
                                button3.BackColor = Color.Green;
                                button3.Text = i.price.ToString();
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                button3.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 3)
                        {
                            if (i.sold_status)
                            {
                                button4.BackColor = Color.Green;
                                button4.Text = i.price.ToString();
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 4)
                        {
                            if (i.sold_status)
                            {
                                button5.BackColor = Color.Green;
                                button5.Text = i.price.ToString();
                            }
                            else
                            {
                                button5.BackColor = Color.Red;
                                button5.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 5)
                        {
                            if (i.sold_status)
                            {
                                button6.BackColor = Color.Green;
                                button6.Text = i.price.ToString();
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = i.price.ToString();
                            }
                        }
                    }
                    if (i.row_n == 2)
                    {
                        if (i.seat_n == 1)
                        {
                            if (i.sold_status)
                            {
                                button7.BackColor = Color.Green;
                                button7.Text = i.price.ToString();
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = i.price.ToString();
                            }

                        }
                        if (i.seat_n == 2)
                        {
                            if (i.sold_status)
                            {
                                button8.BackColor = Color.Green;
                                button8.Text = i.price.ToString();
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 3)
                        {
                            if (i.sold_status)
                            {
                                button9.BackColor = Color.Green;
                                button9.Text = i.price.ToString();
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 4)
                        {
                            if (i.sold_status)
                            {
                                button10.BackColor = Color.Green;
                                button10.Text = i.price.ToString();
                            }
                            else
                            {
                                button10.BackColor = Color.Red;
                                button10.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 5)
                        {
                            if (i.sold_status)
                            {
                                button11.BackColor = Color.Green;
                                button11.Text = i.price.ToString();
                            }
                            else
                            {
                                button11.BackColor = Color.Red;
                                button11.Text = i.price.ToString();
                            }
                        }
                    }
                    if (i.row_n == 3)
                    {
                        if (i.seat_n == 1)
                        {
                            if (i.sold_status)
                            {
                                button12.BackColor = Color.Green;
                                button12.Text = i.price.ToString();
                            }
                            else
                            {
                                button12.BackColor = Color.Red;
                                button12.Text = i.price.ToString();
                            }

                        }
                        if (i.seat_n == 2)
                        {
                            if (i.sold_status)
                            {
                                button13.BackColor = Color.Green;
                                button13.Text = i.price.ToString();
                            }
                            else
                            {
                                button13.BackColor = Color.Red;
                                button13.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 3)
                        {
                            if (i.sold_status)
                            {
                                button14.BackColor = Color.Green;
                                button14.Text = i.price.ToString();
                            }
                            else
                            {
                                button14.BackColor = Color.Red;
                                button14.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 4)
                        {
                            if (i.sold_status)
                            {
                                button15.BackColor = Color.Green;
                                button15.Text = i.price.ToString();
                            }
                            else
                            {
                                button15.BackColor = Color.Red;
                                button15.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 5)
                        {
                            if (i.sold_status)
                            {
                                button16.BackColor = Color.Green;
                                button16.Text = i.price.ToString();
                            }
                            else
                            {
                                button16.BackColor = Color.Red;
                                button16.Text = i.price.ToString();
                            }
                        }
                    }
                    if (i.row_n == 4)
                    {
                        if (i.seat_n == 1)
                        {
                            if (i.sold_status)
                            {
                                button17.BackColor = Color.Green;
                                button17.Text = i.price.ToString();
                            }
                            else
                            {
                                button17.BackColor = Color.Red;
                                button17.Text = i.price.ToString();
                            }

                        }
                        if (i.seat_n == 2)
                        {
                            if (i.sold_status)
                            {
                                button18.BackColor = Color.Green;
                                button18.Text = i.price.ToString();
                            }
                            else
                            {
                                button18.BackColor = Color.Red;
                                button18.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 3)
                        {
                            if (i.sold_status)
                            {
                                button19.BackColor = Color.Green;
                                button19.Text = i.price.ToString();
                            }
                            else
                            {
                                button19.BackColor = Color.Red;
                                button19.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 4)
                        {
                            if (i.sold_status)
                            {
                                button20.BackColor = Color.Green;
                                button20.Text = i.price.ToString();
                            }
                            else
                            {
                                button20.BackColor = Color.Red;
                                button20.Text = i.price.ToString();
                            }
                        }
                        if (i.seat_n == 5)
                        {
                            if (i.sold_status)
                            {
                                button21.BackColor = Color.Green;
                                button21.Text = i.price.ToString();
                            }
                            else
                            {
                                button21.BackColor = Color.Red;
                                button21.Text = i.price.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void ToTickets_Click(object sender, System.EventArgs e)
        {
            Tickets newForm = new Tickets(argsForTickets);
            newForm.ShowDialog();
        }

        private void nonActiveText2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
