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
    public partial class Tickets : Form
    {
        public TicketsList ticketsFromAPI = default;
        public Tickets()
        {
            InitializeComponent();
        }

        public Tickets(MainMenu mainMenuForm)
        {
            InitializeComponent();
            BaseLoad();
        }

        public Tickets(List<string> args)
        {
            InitializeComponent();
            BaseLoad();

            ActiveText1.Text = args[0];
            ActiveText2.Text = args[1];
            ActiveText6.Text = args[2];
            ActiveText7.Text = args[3];

            dataGridView1.Rows.Clear();

            bool[] notNullInputCheck = { true, true, true, true, true, true, true }; // Проверка, какие поля поиска пустые

            if (ActiveText1.Text == "") notNullInputCheck[0] = false;
            if (ActiveText2.Text == "") notNullInputCheck[1] = false;
            if (ActiveText3.Text == "") notNullInputCheck[2] = false;
            if (ActiveText4.Text == "") notNullInputCheck[3] = false;
            if (ActiveText5.Text == "") notNullInputCheck[4] = false;
            if (ActiveText6.Text == "") notNullInputCheck[5] = false;
            if (ActiveText7.Text == "") notNullInputCheck[6] = false;

            int addCount = 0;
            for (int i = 0; i < ticketsFromAPI.body.Length; i++)
            {
                string[] buff = ticketsFromAPI.body[i].date_time.Split(' ');
                if (((ticketsFromAPI.body[i].title == ActiveText1.Text) || !notNullInputCheck[0])
                    && ((ticketsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1])
                    && ((ticketsFromAPI.body[i].row_n.ToString() == ActiveText3.Text) || !notNullInputCheck[2])
                    && ((ticketsFromAPI.body[i].seat_n.ToString() == ActiveText4.Text) || !notNullInputCheck[3])
                    && ((ticketsFromAPI.body[i].price.ToString() == ActiveText5.Text) || !notNullInputCheck[4])
                    && ((buff[0] == ActiveText6.Text) || !notNullInputCheck[5])
                    && ((buff[1] == ActiveText7.Text) || !notNullInputCheck[6]))
                {
                    buff[1] = buff[1].Substring(0, buff[1].Length - 3);
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[addCount].Cells[0].Value = ticketsFromAPI.body[i].title;
                    dataGridView1.Rows[addCount].Cells[1].Value = ticketsFromAPI.body[i].hall_n;
                    dataGridView1.Rows[addCount].Cells[2].Value = ticketsFromAPI.body[i].row_n;
                    dataGridView1.Rows[addCount].Cells[3].Value = ticketsFromAPI.body[i].seat_n;
                    dataGridView1.Rows[addCount].Cells[4].Value = ticketsFromAPI.body[i].price;
                    dataGridView1.Rows[addCount].Cells[5].Value = buff[0];
                    dataGridView1.Rows[addCount].Cells[6].Value = buff[1];
                    addCount++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Нажата кнопка поиска
        {
            dataGridView1.Rows.Clear();

            bool[] notNullInputCheck = { true, true, true, true, true, true, true }; // Проверка, какие поля поиска пустые

            if (ActiveText1.Text == "") notNullInputCheck[0] = false;
            if (ActiveText2.Text == "") notNullInputCheck[1] = false;
            if (ActiveText3.Text == "") notNullInputCheck[2] = false;
            if (ActiveText4.Text == "") notNullInputCheck[3] = false;
            if (ActiveText5.Text == "") notNullInputCheck[4] = false;
            if (ActiveText6.Text == "") notNullInputCheck[5] = false;
            if (ActiveText7.Text == "") notNullInputCheck[6] = false;

            int addCount = 0;
            for (int i = 0; i < ticketsFromAPI.body.Length; i++)
            {
                string[] buff = ticketsFromAPI.body[i].date_time.Split(' ');
                if ( ((ticketsFromAPI.body[i].title == ActiveText1.Text) || !notNullInputCheck[0]) 
                    && ((ticketsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1]) 
                    && ((ticketsFromAPI.body[i].row_n.ToString() == ActiveText3.Text) || !notNullInputCheck[2]) 
                    && ((ticketsFromAPI.body[i].seat_n.ToString() == ActiveText4.Text) || !notNullInputCheck[3])
                    && ((ticketsFromAPI.body[i].price.ToString() == ActiveText5.Text) || !notNullInputCheck[4])
                    && ((buff[0] == ActiveText6.Text) || !notNullInputCheck[5])
                    && ((buff[1] == ActiveText7.Text) || !notNullInputCheck[6]))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[addCount].Cells[0].Value = ticketsFromAPI.body[i].title;
                    dataGridView1.Rows[addCount].Cells[1].Value = ticketsFromAPI.body[i].hall_n;
                    dataGridView1.Rows[addCount].Cells[2].Value = ticketsFromAPI.body[i].row_n;
                    dataGridView1.Rows[addCount].Cells[3].Value = ticketsFromAPI.body[i].seat_n;
                    dataGridView1.Rows[addCount].Cells[4].Value = ticketsFromAPI.body[i].price;
                    dataGridView1.Rows[addCount].Cells[5].Value = buff[0];
                    dataGridView1.Rows[addCount].Cells[6].Value = buff[1];
                    addCount++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaseLoad()
        {
            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create("http://25.46.163.182:8080/ticket/get?title&MovieYear&duration&publisher&genre&SeanceYear&month&day&hour&hall_n&seat_n&seat_type&limit=10000+&offset&row_n&price&sold_status&booking_status");
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

            ticketsFromAPI = JsonConvert.DeserializeObject<TicketsList>(jsonLine);

            for (int i = 0; i < ticketsFromAPI.body.Length; i++)
            {
                string[] buff = ticketsFromAPI.body[i].date_time.Split(' ');
                buff[1] = buff[1].Substring(0, buff[1].Length - 3);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = ticketsFromAPI.body[i].title;
                dataGridView1.Rows[i].Cells[1].Value = ticketsFromAPI.body[i].hall_n;
                dataGridView1.Rows[i].Cells[2].Value = ticketsFromAPI.body[i].row_n;
                dataGridView1.Rows[i].Cells[3].Value = ticketsFromAPI.body[i].seat_n;
                dataGridView1.Rows[i].Cells[4].Value = ticketsFromAPI.body[i].price;
                dataGridView1.Rows[i].Cells[5].Value = buff[0];
                dataGridView1.Rows[i].Cells[6].Value = buff[1];
            }
        }
    }
}
