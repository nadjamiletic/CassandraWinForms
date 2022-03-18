using System;
using CassandraDataLayer.QueryEntities;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class VodostajForma : Form
    {
        
        public VodostajForma()
        {
            InitializeComponent();
            
        }

        private void VodostajForma_Load(object sender, EventArgs e)
        {
          
        }

        public void VodostajGrafik(List<StanjeStanica> podaci)
        {
            foreach (StanjeStanica s in podaci)
            {
                if (s.vodostaj < 0)
                {
                    chartVodostaj.Series["Ispod nivoa"].Points.AddXY(s.sat, s.vodostaj);
                }
                else if (s.vodostaj < 30)
                {
                    chartVodostaj.Series["Nizak"].Points.AddXY(s.sat, s.vodostaj);
                }
                else if (s.vodostaj < 100)
                {
                    chartVodostaj.Series["Srednji"].Points.AddXY(s.sat, s.vodostaj);
                }
                else if (s.vodostaj >= 100)
                {
                    chartVodostaj.Series["Visok"].Points.AddXY(s.sat, s.vodostaj);
                }
            }
        }
    }
}
