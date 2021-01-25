using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention:isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdet)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi);

        }
    }
}
