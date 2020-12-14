using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mamalia
{
    class sapi : mamalia
    {
        mamalia mamals = new mamalia();
        herbivora hb = new herbivora();
        public bool daratan = false;
        public bool lautan;

        string makanan;
        public string makan()
        {
            hb.rumput = "rumput";
            makanan = hb.rumput;
            mamals.darat = true;
            daratan = mamals.darat;
            if (daratan == true)
            {
                return makanan;
            }
            return makanan;
        }
    }
}
