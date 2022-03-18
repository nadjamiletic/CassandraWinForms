using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraWinFormsSample
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }
       
        private void admin_Click(object sender, EventArgs e)
        {
            GlavnaForma n=new GlavnaForma();
            n.Show();
            this.Hide();
            n.FormClosing += Pocetna_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klijent_Click(object sender, EventArgs e)
        {
            Klijent k = new Klijent();
            k.Show();
            this.Hide();
            k.FormClosing += Pocetna_FormClosing;
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
