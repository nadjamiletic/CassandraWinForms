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
    public partial class Proticaj : Form
    {
        public Proticaj()
        {
            InitializeComponent();
        }

        private void Proticaj_Load(object sender, EventArgs e)
        {
           
        }

        public void ProticajGrafik(List<StanjeStanica> podaci) {
            foreach (StanjeStanica s in podaci)
            {
                if (s.proticaj < 100)
                {
                    chartProticaj.Series["Mali"].Points.AddXY(s.sat, s.proticaj);
                }
                else if (s.proticaj < 500)
                {
                    chartProticaj.Series["Srednji"].Points.AddXY(s.sat, s.proticaj);
                }
                else if (s.proticaj < 1000)
                {
                    chartProticaj.Series["Visok"].Points.AddXY(s.sat, s.proticaj);
                }
                else if (s.proticaj >= 1000)
                {
                    chartProticaj.Series["Veoma visok"].Points.AddXY(s.sat, s.proticaj);
                }
            }
        }
    }
}
