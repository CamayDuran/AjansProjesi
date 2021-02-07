using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneAjansProjesi
{
    public class Firma
    {
        public string Adi { get; set; }
        public float AlinacakPara { get; set; }
        public string Sehir { get; set; }
        public int IsSayisi { get; set; }

        public Firma(float alinacakpara)
        {
            //constructor oluşturduk
            this.AlinacakPara = alinacakpara;

        }



    }
}
