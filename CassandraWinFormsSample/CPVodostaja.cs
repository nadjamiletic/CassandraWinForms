using System;
using CassandraDataLayer.QueryEntities;
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
    public partial class CPVodostaja : UserControl
    {
        public CPVodostaja()
        {
            InitializeComponent();
            cbRekaPopuni();
            //PopuniPVodostaja("s", "r", "m");
        }

        public void PopuniPVodostaja(string stanicaid, string rekaid, string mesec,int dan)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int n;
            //String oState;

            foreach (CassandraDataLayer.QueryEntities.StanjeStanica rek in CassandraDataLayer.DataProvider.GetPodaci(stanicaid, rekaid, mesec,dan))
            {
                n = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[n].Cells[0].Value = Convert.ToString(rek.sat);
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToString(rek.promenavodostaja);
             

            }
        }
        public void PopuniDan(string r, string s, string m)
        {

            List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci(r, s, m);
            List<int> d = new List<int>();
            foreach (StanjeStanica s1 in podaci)
            {
                d.Add(s1.dan);
            }

            List<int> filter = d.Distinct().ToList();

            foreach (int s2 in filter)
            {
                cmbDan.Items.Add(s2);
            }
        }

        public void cbRekaPopuni()
        {

            List<String> d = new List<string>();
            // List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci();

            List<CassandraDataLayer.QueryEntities.Reka> reke = CassandraDataLayer.DataProvider.GetReke();

            foreach (CassandraDataLayer.QueryEntities.Reka s in reke)
            {
                d.Add(s.rekaid);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                cbReka.Items.Add(s);
            }
        }
        public string VratiReku()
        {
            return cbReka.SelectedItem.ToString();
        }

        public void cbStanicaPopuni(string r)
        {

            List<String> d = new List<string>();
            foreach (CassandraDataLayer.QueryEntities.Reka s in CassandraDataLayer.DataProvider.GetReku(r))
            {
                d.Add(s.stanicaid);
            }

            //List<string> filter = d.Distinct().ToList();

            foreach (string s in d)
            {
                cbStanica.Items.Add(s);
            }
        }
        public void PopuniMesec(string r, string s)
        {

            List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci(r, s);
            List<String> d = new List<string>();
            foreach (StanjeStanica s1 in podaci)
            {
                d.Add(s1.mesec);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s2 in filter)
            {
                cbMesec.Items.Add(s2);
            }
        }

        private void cbReka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStanica.Items.Clear();
            cbStanicaPopuni(cbReka.Text);
        }

        private void cbStanica_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMesec.Items.Clear();
            PopuniMesec(cbStanica.Text, cbReka.Text);
        }

        private void cbMesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDan.Items.Clear();
            PopuniDan(cbStanica.Text, cbReka.Text, cbMesec.Text);
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PVodostajaGrafik g = new PVodostajaGrafik();
            g.VodostajGrafik(CassandraDataLayer.DataProvider.GetPodaci(cbStanica.Text, cbReka.Text, cbMesec.Text, int.Parse(cmbDan.Text)));
            g.Show();
            
        }

        private void cmbDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniPVodostaja(cbStanica.Text, cbReka.Text, cbMesec.Text, int.Parse(cmbDan.Text));
        }
    }
}
