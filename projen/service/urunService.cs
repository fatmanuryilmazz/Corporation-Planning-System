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
    class urunService
    {
        internal ArrayList urunGetir()
        {
            return (new urunDao().urunOku());
        }

        internal void urunKaydet(string text)
        {
            (new urunDao()).urunKaydet(new urun(text));
        }

        internal void urunSil(int ıd)
        {
            (new urunDao()).urunSil(new urun(ıd));
        }
    }
}
