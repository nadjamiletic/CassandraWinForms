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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {
            Grad g = new Grad();
            g.Show();
            this.Hide();
            g.FormClosing += GlavnaForma_FormClosing;
        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reka g = new Reka();
            g.Show();
            this.Hide();
            g.FormClosing += GlavnaForma_FormClosing;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stanica g = new Stanica();
            g.Show();
            this.Hide();
            g.FormClosing += GlavnaForma_FormClosing;
        }

       

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
