using System;
using CassandraDataLayer.QueryEntities;
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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Temperatura_Load(object sender, EventArgs e)
        {
           
        }

        public void TemperaturaGrafik(List<StanjeStanica> podaci) {
            foreach (StanjeStanica s in podaci)
            {
                if (s.temperatura < 2)
                {
                    chartTemperatura.Series["Niska"].Points.AddXY(s.sat, s.temperatura);
                   
                }
                else if (s.temperatura < 10)
                {
                    chartTemperatura.Series["Srednja"].Points.AddXY(s.sat, s.temperatura);
                }
                else
                {
                    chartTemperatura.Series["Topla"].Points.AddXY(s.sat, s.temperatura);
                }
            }
        }
    }
}
