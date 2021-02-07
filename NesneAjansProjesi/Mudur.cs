using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAjansProjesi
{
    public class Mudur:Ajans
    {
         private string kategori { get; set; }
         public float maas { get; private set; }

        public Mudur(float maas)
        {
            //constructor oluşturduk
            this.maas = maas;
        }
    }
}
