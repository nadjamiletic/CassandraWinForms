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
    public partial class Grad : Form
    {
        public Grad()
        {
            InitializeComponent();
        }

        
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            DataProvider.AddGrad(txtNaziv.Text, txtDrzava.Text, txtStanica.Text);
        }

        private void btnVrati1_Click_1(object sender, EventArgs e)
        {
            List<CassandraDataLayer.QueryEntities.Grad> gradovi = DataProvider.GetGradove(txtNaziv1.Text);

            foreach (CassandraDataLayer.QueryEntities.Grad r in gradovi)
            {
                txtJedanGrad.Text += "Drzava " + r.drzava.ToString() + Environment.NewLine + "Stanica " + r.stanica.ToString() + Environment.NewLine;

            }
        }

        private void btnVratiSve_Click_1(object sender, EventArgs e)
        {
            List<CassandraDataLayer.QueryEntities.Grad> gradovi = DataProvider.GetGradove();

            foreach (CassandraDataLayer.QueryEntities.Grad r in gradovi)
            {
                textBox2.Text += "Grad " + r.gradid.ToString() + Environment.NewLine + "Drzava " + r.drzava.ToString() + Environment.NewLine + "Stanica " + r.stanica.ToString() + Environment.NewLine;

            }
        }
    }
}
