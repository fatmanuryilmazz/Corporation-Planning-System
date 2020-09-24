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
    class musteriService
    {
        internal ArrayList musteriGetir()
        {
            return (new musteriDao().musteriOku());

        }

        internal void musteriKaydet(string text1, string text2, string text3, string text4)
        {
            (new musteriDao()).musteriKaydet(new musteri(text1,text2,text3,text4));
        }

        internal void musteriSil(int ıd)
        {
            (new musteriDao()).musteriSil(new musteri(ıd));
        }

        internal void musteriGuncelle(string text1, string text2, string text3, string text4)
        {
            (new musteriDao()).musteriGuncelle(new musteri(text1,text2,text3,text4));
        }
    }
}
