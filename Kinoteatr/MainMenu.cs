using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void toSessions_Click(object sender, EventArgs e)
        {
            Sessions newForm = new Sessions(this);
            newForm.ShowDialog();
        }

        private void toEditTickets_Click(object sender, EventArgs e)
        {
            Tickets newForm = new Tickets(this);
            newForm.ShowDialog();
        }

        private void toStatistic_Click(object sender, EventArgs e)
        {
            Statistic newForm = new Statistic(this);
            newForm.ShowDialog();
        }
    }
}
