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

            string jsonLine = default;

            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("utf-8");

            WebRequest request = WebRequest.Create("http://25.46.163.182:8080/ticket/get?title&MovieYear&duration&publisher&genre&SeanceYear&month&day&hour&hall_n&seat_n&seat_type&limit&offset&row_n&price&sold_status&booking_status");
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
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = ticketsFromAPI.body[i].id;
                dataGridView1.Rows[i].Cells[1].Value = ticketsFromAPI.body[i].seanceId;
                dataGridView1.Rows[i].Cells[2].Value = ticketsFromAPI.body[i].title;
                dataGridView1.Rows[i].Cells[3].Value = ticketsFromAPI.body[i].hall_n;
                dataGridView1.Rows[i].Cells[4].Value = ticketsFromAPI.body[i].row_n;
                dataGridView1.Rows[i].Cells[5].Value = ticketsFromAPI.body[i].seat_n;
                dataGridView1.Rows[i].Cells[6].Value = ticketsFromAPI.body[i].price;
                dataGridView1.Rows[i].Cells[7].Value = ticketsFromAPI.body[i].date_time;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            bool[] notNullInputCheck = { true, true, true, true, true, true };

            if (ActiveText1.Text == "") notNullInputCheck[0] = false;
            if (ActiveText2.Text == "") notNullInputCheck[1] = false;
            if (ActiveText3.Text == "") notNullInputCheck[2] = false;
            if (ActiveText4.Text == "") notNullInputCheck[3] = false;
            if (ActiveText5.Text == "") notNullInputCheck[4] = false;
            if (ActiveText6.Text == "") notNullInputCheck[5] = false;

            int addCount = 0;
            for (int i = 0; i < ticketsFromAPI.body.Length; i++)
            {
                if ( ((ticketsFromAPI.body[i].title == ActiveText1.Text) || !notNullInputCheck[0]) 
                    && ((ticketsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1]) 
                    && ((ticketsFromAPI.body[i].row_n.ToString() == ActiveText3.Text) || !notNullInputCheck[2]) 
                    && ((ticketsFromAPI.body[i].seat_n.ToString() == ActiveText4.Text) || !notNullInputCheck[3])
                    && ((ticketsFromAPI.body[i].price.ToString() == ActiveText5.Text) || !notNullInputCheck[4])
                    && ((ticketsFromAPI.body[i].date_time.ToString() == ActiveText6.Text) || !notNullInputCheck[5]) )
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[addCount].Cells[0].Value = ticketsFromAPI.body[i].id;
                    dataGridView1.Rows[addCount].Cells[1].Value = ticketsFromAPI.body[i].seanceId;
                    dataGridView1.Rows[addCount].Cells[2].Value = ticketsFromAPI.body[i].title;
                    dataGridView1.Rows[addCount].Cells[3].Value = ticketsFromAPI.body[i].hall_n;
                    dataGridView1.Rows[addCount].Cells[4].Value = ticketsFromAPI.body[i].row_n;
                    dataGridView1.Rows[addCount].Cells[5].Value = ticketsFromAPI.body[i].seat_n;
                    dataGridView1.Rows[addCount].Cells[6].Value = ticketsFromAPI.body[i].price;
                    dataGridView1.Rows[addCount].Cells[7].Value = ticketsFromAPI.body[i].date_time;
                    addCount++;
                }
            }
        }
    }
}
