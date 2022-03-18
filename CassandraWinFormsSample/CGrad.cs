using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraWinFormsSample
{
    public partial class CGrad : UserControl
    {
        public CGrad()
        {
            InitializeComponent();
            cbGradPopuni();
        }

        public void cbGradPopuni()
        {

            List<String> d = new List<string>();
            // List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci();

            List<CassandraDataLayer.QueryEntities.Grad> gradovi = CassandraDataLayer.DataProvider.GetGradove();

            foreach (CassandraDataLayer.QueryEntities.Grad s in gradovi)
            {
                d.Add(s.gradid);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                cmbGrad.Items.Add(s);
            }
        }
        public string VratiGrad()
        {
            return cmbGrad.SelectedItem.ToString();
        }

        public void PopuniGrad(string gradid)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int n;
            //String oState;

            foreach (CassandraDataLayer.QueryEntities.Grad grad in CassandraDataLayer.DataProvider.GetGradove(gradid))
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Convert.ToString(grad.stanica);
               


            }
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniGrad(cmbGrad.Text);
        }
    }
}
