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
    public partial class PVodostajaGrafik : Form
    {
        public PVodostajaGrafik()
        {
            InitializeComponent();
        }

        public void VodostajGrafik(List<StanjeStanica> podaci)
        {
            foreach (StanjeStanica s in podaci)
            {

                pVodostaja.Series["Promena vodostaja"].Points.AddXY(s.sat, s.promenavodostaja);
                
                
            }
        }
    }
}
