using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAjansProjesi
{
    public class Musteri
    {
        public string Adi { get; set; }
        public bool Musaitlik { get; set; }
        public string IsAdi { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int IzinGunu { get; set; }
        public int EkIzınGunu { get; set; }

        public Musteri(int izingunu)
        {
            //constructor oluşturduk
            this.IzinGunu = izingunu;
        }
        public Musteri(int izingunu, int ekizingunu)
        {
            //constructor oluşturduk
            this.IzinGunu = izingunu;
            this.EkIzınGunu = ekizingunu;
        }
    }
}
