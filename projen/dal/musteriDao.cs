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
    class musteriDao
    {
        internal ArrayList musteriOku()
        {
            ArrayList okunanMusteriler = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("Select*From musteri", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanMusteriler.Add(new musteri(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString(),okunan[4].ToString()));
            }
            return okunanMusteriler;
        }

        internal void musteriSil(musteri musteri)
        {
            (new MySqlCommand("delete from musteri where idmusteri= " + musteri.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void musteriGuncelle(musteri musteri)
        {
            (new MySqlCommand("update musteri set ad='" + musteri.Ad + "',soyad='" + musteri.Soyad + "',adres='" + musteri.Adres+ "',tel='" + musteri.Tel + "' where idmusteri=" + musteri.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void musteriKaydet(musteri musteri)
        {
            (new MySqlCommand("insert into musteri(ad,soyad,adres,tel)values('" +musteri.Ad+ "','" + musteri.Soyad + "','" + musteri.Adres + "','" + musteri.Tel + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
