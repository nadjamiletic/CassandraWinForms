using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
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
    public partial class Stanica : Form
    {
        public Stanica()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataProvider.AddPodaci(txtStanica.Text,txtReka.Text,txtMesec.Text, Int32.Parse(txtVodostaj.Text.ToString()), Int32.Parse(txtPromena.Text.ToString()), Int32.Parse(txtProticaj.Text.ToString()), Int32.Parse(txtTemp.Text.ToString()), Int32.Parse(txtSat.Text),Int32.Parse(txtDan.Text));
        }

        private void Stanica_Load(object sender, EventArgs e)
        {

        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            List<CassandraDataLayer.QueryEntities.StanjeStanica> vod = DataProvider.GetPodaci(txtStanica1.Text);

            foreach (CassandraDataLayer.QueryEntities.StanjeStanica r in vod)
            {
                textBox1.Text += "Reka " + r.rekaid.ToString() + Environment.NewLine + "Mesec " + r.mesec + Environment.NewLine + "Vodostaj " + r.vodostaj.ToString() + Environment.NewLine + "Promena vodostaja " + r.promenavodostaja.ToString() + Environment.NewLine + "Proticaj " + r.proticaj.ToString() + Environment.NewLine + "Temperatura " + r.temperatura.ToString() + Environment.NewLine + "Sat " + r.sat.ToString() + Environment.NewLine + "Dan " + r.dan.ToString() + Environment.NewLine;

            }
        }
    }
}
