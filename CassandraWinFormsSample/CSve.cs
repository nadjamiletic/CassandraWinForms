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
    public partial class CSve : UserControl
    {
        public CSve()
        {
            InitializeComponent();
            //PopuniSve("s", "r", "m");
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PopuniSve()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int n;
            //String oState;

            foreach (CassandraDataLayer.QueryEntities.StanjeStanica rek in CassandraDataLayer.DataProvider.GetPodaci())
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Convert.ToString(rek.stanicaid);
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToString(rek.rekaid);
                dataGridView1.Rows[n].Cells[2].Value = Convert.ToString(rek.mesec);
                dataGridView1.Rows[n].Cells[3].Value = Convert.ToString(rek.dan);
                dataGridView1.Rows[n].Cells[4].Value = Convert.ToString(rek.sat);
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToString(rek.proticaj);
                dataGridView1.Rows[n].Cells[6].Value = Convert.ToString(rek.promenavodostaja);
                dataGridView1.Rows[n].Cells[7].Value = Convert.ToString(rek.vodostaj);
                dataGridView1.Rows[n].Cells[8].Value = Convert.ToString(rek.temperatura);

            }
        }
    }
}
