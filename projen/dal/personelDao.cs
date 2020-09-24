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
    class personelDao
    {
        internal ArrayList personelGetir()
        {
            ArrayList okunanPersoneller = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("Select * from personelekle", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanPersoneller.Add(new personel(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString()));
            }
            return okunanPersoneller;
        }

        internal void personelSil(personel personel)
        {
            (new MySqlCommand("delete from personelekle where idpersonelekle= " + personel.Idpersonel, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void personelGuncelle(personel personel)
        {
            (new MySqlCommand("update personelekle set ad='" + personel.Ad + "',tel='" + personel.Tel + "',adres='" + personel.Adres + "' where idpersonelekle=" + personel.Idpersonel, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void personelKaydet(personel personel)
        {
            (new MySqlCommand("insert into personelekle(bolumNo,ad,tel,adres)values(" +personel.Bolumid + ",'" + personel.Ad + "','" + personel.Tel + "','" + personel.Adres + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

    }
}
