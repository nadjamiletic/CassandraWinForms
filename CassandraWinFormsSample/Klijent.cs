using System;
using CassandraWinFormsSample.Properties;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;
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
    public partial class Klijent : Form
    {
        public List<string> reke;
        public List<string> stanice;
        public List<string> meseci;
        public Klijent()
        {
            InitializeComponent();
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;

            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();
            button10.Hide();

            this.Width = 1100;
            PopuniSve();
            cSve1.Show();
            cSve1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();
            
            button10.Show();
            cProticaj1.Show();
            cProticaj1.BringToFront();
            this.Width = 840;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            cProticaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();
           
            button10.Show();
            cVodostaj1.Show();
            cVodostaj1.BringToFront();
            this.Width = 840;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();

            button10.Show();
            
            cTemperatura1.Show();
            cTemperatura1.BringToFront();
            this.Width = 840; ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            cProticaj1.Hide();
            cVodostaj1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();

            button10.Show();
            //cpVodostaja1.cbRekaPopuni();
            cpVodostaja1.Show();
            cpVodostaja1.BringToFront();
            this.Width = 840;
        }

        

        private void cbReka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci();
            foreach (StanjeStanica s in podaci)
            {
                if (!reke.Contains(s.rekaid))
                {
                    cbReka.Items.Add(s.rekaid);
                    
                    cbReka.ValueMember.Insert(i,s.rekaid);
                    cbReka.Items.Insert(i,s.rekaid);
                    reke.Add(s.rekaid);
                    i++;
                }
            }
        }

        private void cbStanica_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object o = cbReka.SelectedItem;
            
        }

        private void cbMesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object o = cbReka.SelectedItem;
            Object o1 = cbStanica.SelectedItem;
            List<StanjeStanica> podaci = CassandraDataLayer.DataProvider.GetPodaci(o.ToString(),o1.ToString());
            foreach (StanjeStanica s in podaci)
            {
                if (!stanice.Contains(s.mesec))
                {
                    cbStanica.Items.Add(s.mesec);
                    meseci.Add(s.mesec);
                }
            }
        }

        private void cbReka_Validating(object sender, CancelEventArgs e)
        {
            
        }

        public void PopuniSve()
        {
            cSve1.PopuniSve();
          
        }

        public void PopuniVodostaj(string stanicaid, string rekaid, string mese,int dan)
        {
            cVodostaj1.PopuniVodostaj(stanicaid,  rekaid,  mese,dan);
        }

        public void PopuniTemp(string stanicaid, string rekaid, string mesec,int dan)
        {
            cTemperatura1.PopuniTemp(stanicaid,  rekaid,  mesec,dan);
        }

        public void PopuniProticaj(string stanicaid, string rekaid, string mesec,int dan)
        {
            cProticaj1.PopuniProticaj(stanicaid, rekaid, mesec,dan);
        }

        public void PopuniPVodostaja(string stanicaid, string rekaid, string mesec,int dan)
        {
            cpVodostaja1.PopuniPVodostaja(stanicaid, rekaid, mesec,dan);
        }

        private void cTemperatura1_Load(object sender, EventArgs e)
        {

        }

        private void cSve1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();
            button10.Hide();

            this.Width = 1100;
            PopuniSve();
            cSve1.Show();
            cSve1.BringToFront();

            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            vidiUtiske1.Hide();
            cGrad1.Hide();

            button10.Show();
            ostaviKomentar1.Show();
            ostaviKomentar1.BringToFront();

            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            this.Width = 840;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            cGrad1.Hide();

            button10.Show();
            vidiUtiske1.Show();
            vidiUtiske1.BringToFront();
            vidiUtiske1.popuniLike();
            vidiUtiske1.popuniUtiske();

            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            this.Width = 840;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cProticaj1.Hide();
            cVodostaj1.Hide();
            cpVodostaja1.Hide();
            cTemperatura1.Hide();
            cSve1.Hide();
            ostaviKomentar1.Hide();
            vidiUtiske1.Hide();

            button10.Show();
            cGrad1.Show();
            cGrad1.BringToFront();

            SidePanel.Height = button9.Height;
            SidePanel.Top = button9.Top;
            this.Width = 840;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
