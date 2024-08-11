using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inscription insc = new Inscription();
            insc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestStock gestStock = new GestStock();
            gestStock.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suiv_Demandes sd = new Suiv_Demandes();
            sd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Suivi_Stock stock = new Suivi_Stock();
            stock.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
