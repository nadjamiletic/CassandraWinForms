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
    public partial class VidiUtiske : UserControl
    {
        public VidiUtiske()
        {
            InitializeComponent();
        }
        
        public void popuniLike()
        {
            int l = 0;
            int u = 0;
            foreach (Komentar k in CassandraDataLayer.DataProvider.GetKomentare())
            {
                if (k.brlike == 1)
                    l++;
                else if (k.brunlike == 1)
                    u++;

                
            }
            likes.Text = l.ToString();
            unlike.Text = u.ToString();
        }
        public List<string> lista;
        public void popuniUtiske() {
            foreach (Komentar k in CassandraDataLayer.DataProvider.GetKomentare())
            {
                //lista.Add("Autor: "+k.autor+"\n"+k.sadrzaj);
                listBox1.Items.Add("Autor:");
                listBox1.Items.Add(k.autor);
                listBox1.Items.Add("Komentar:");
                listBox1.Items.Add(k.sadrzaj);
            }
            //listBox1.Items.Add(lista);
        }
    }

    
}
