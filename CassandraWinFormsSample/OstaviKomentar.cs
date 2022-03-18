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
    public partial class OstaviKomentar : UserControl
    {
        public OstaviKomentar()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int l1=0, u1=0;
            if (rlike.Checked)
                l1 = 1;
            if(rulike.Checked)
                u1 = 1;
            CassandraDataLayer.DataProvider.AddKomentar(ime.Text,komentar.Text,l1,u1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
