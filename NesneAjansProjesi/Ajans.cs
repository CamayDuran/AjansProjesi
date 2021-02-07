using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAjansProjesi
{
    public class Ajans
    {
        public Musteri musteriler;
        public Firma firma ;
        public MaliDurum maliDurum;
        


        public float GelirGiderHesapla(MaliDurum maliDurum)
        {
            this.maliDurum = maliDurum;
            return (maliDurum.Gelir - maliDurum.Gider);
        }

        public void IsSayisiHesapla(Firma firma)
        {
            this.firma = firma;
            if (firma.IsSayisi >= 3)
            {
                firma.AlinacakPara = firma.AlinacakPara - (firma.AlinacakPara * 20 / 100);
            }

        }
    }
}
