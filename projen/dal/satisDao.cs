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
    class satisDao
    {
        internal ArrayList satisOku()
        {
            ArrayList okunanSatislar = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("Select*From satisekle", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanSatislar.Add(new satis(Convert.ToInt32(okunan[0]), Convert.ToInt32(okunan[1]), Convert.ToInt32(okunan[2]), Convert.ToInt32(okunan[3]), Convert.ToInt32(okunan[4])));
            }
            return okunanSatislar;
        }
        internal void satisKaydet(satis satis)
        {
            (new MySqlCommand("insert into satisekle(idmusteri,idpersonelekle,idurun,adet)values('" + satis.Musteriid + "','" + satis.Personelid + "','" + satis.Urunid + "','" + satis.Adet + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void satisSil(satis satis)
        {
            (new MySqlCommand("delete from satisekle where idsatisekle= " + satis.Satisid, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void satisGuncelle(satis satis)
        {
            (new MySqlCommand("update satisekle set idmusteri='" +satis.Musteriid+ "',idpersonelekle='" + satis.Personelid+ "',idurun='" + satis.Urunid + "',adet='" + satis.Adet + "' where idsatisekle=" + satis.Satisid, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        
        
    }
}
