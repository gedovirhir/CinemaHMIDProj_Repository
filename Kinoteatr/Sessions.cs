using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
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
                if( ( (sessionsFromAPI.body[i].movieTitle == ActiveText1.Text) || !notNullInputCheck[0] ) && ( (sessionsFromAPI.body[i].hall_n.ToString() == ActiveText2.Text) || !notNullInputCheck[1] ) && ( (sessionsFromAPI.body[i].date_time == ActiveText3.Text) || !notNullInputCheck[2] ) )
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
    }
}
