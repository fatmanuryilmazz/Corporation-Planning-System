using projen.dal;
using projen.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.service
{
    class personelService
    {
        internal ArrayList personelGetir()
        {
            return (new personelDao()).personelGetir();
        }

        internal void personelekle(int gBolumid, string gAd, string gTel, string gAdres)
        {
            (new personelDao()).personelKaydet(new personel(gBolumid,gAd,gTel,gAdres));
        }

        
        internal void personelSil(int ıdpersonel)
        {
            (new personelDao()).personelSil(new personel(ıdpersonel));
        }

        internal void personelguncelle(string text1, string text2, string text3)
        {
            (new personelDao()).personelGuncelle(new personel(text1,text2,text3));
        }
    }
}
