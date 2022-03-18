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
    public partial class Reka : Form
    {
        public Reka()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataProvider.AddReka(txtReka.Text, txtGrad.Text, txtStanica.Text);
        }

        private void btnVratiSve_Click(object sender, EventArgs e)
        {
            List<CassandraDataLayer.QueryEntities.Reka> reke = DataProvider.GetReke();

            foreach (CassandraDataLayer.QueryEntities.Reka r in reke)
            {
                txtSve.Text += "Reka " + r.rekaid.ToString() + Environment.NewLine + "Grad " + r.gradid.ToString() + Environment.NewLine + "Stanica " + r.stanicaid.ToString() + Environment.NewLine;

            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
           
            List<CassandraDataLayer.QueryEntities.Reka> reke = DataProvider.GetReku(txtReka1.Text);

            foreach (CassandraDataLayer.QueryEntities.Reka r in reke)
            {
                txtPodatak.Text += "Grad " + r.gradid.ToString() + Environment.NewLine + "Stanica " + r.stanicaid.ToString() + Environment.NewLine;

            }
        }
    }
}
