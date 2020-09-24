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
    class bolumService
    {
        public ArrayList bolumGetir()
        {
          return (new bolumDao().bolumOku());
        }

        internal void bolumKaydet(string gAd, string gTel)
        {
            (new bolumDao()).bolumKaydet(new bolum(gAd,gTel));
        }

        internal void bolumSil(int gId)
        {
            (new bolumDao()).bolumSil(new bolum(gId));
        }

        internal void bolumguncelle(int gId, string gAd, string gTel)
        {
            (new bolumDao()).bolumGuncelle(new bolum(gId,gAd,gTel));
        }
        
    }
}
