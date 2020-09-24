using MySql.Data.MySqlClient;
using projen.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.dal
{
    class urunDao
    {
        internal ArrayList urunOku()
        {
            ArrayList okunanUrunler = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("Select*From urunler", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanUrunler.Add(new urun(Convert.ToInt32(okunan[0]), okunan[1].ToString()));
            }
            return okunanUrunler;
        }


        internal void urunKaydet(urun urun)
        {
            (new MySqlCommand("insert into urunler(urunad)values('" + urun.Ad + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void urunSil(urun urun)
        {
            (new MySqlCommand("delete from urunler where idurunler= " + urun.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
