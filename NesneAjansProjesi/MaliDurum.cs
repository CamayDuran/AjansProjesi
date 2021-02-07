using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAjansProjesi
{
    public class MaliDurum
    {
        public float Gelir { get; set; }
        public float Gider { get; set; }
        public DateTime Tarih { get; set; }

        public MaliDurum()
        {
            //constructor oluşturduk
            Gider = 18000;

        }
        public MaliDurum(float gelir)
        {
            //constructor oluşturduk
            Gider = 18000;
            this.Gelir = gelir;

        }
    }
}
