using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class StanjeStanica
    {
        public string stanicaid { get; set; }
        public string rekaid { get; set; }
        public int vodostaj { get; set; }
        public int promenavodostaja { get; set; }
        public int proticaj { get; set; }
        public int temperatura { get; set; }
        public int sat { get; set; }
        public int dan { get; set; }
        public string mesec { get; set; }
    }
}
