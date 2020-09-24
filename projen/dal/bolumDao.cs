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
    class bolumDao
    {
        

        public ArrayList bolumOku()
        {
            ArrayList okunanBolumler = new ArrayList();
            MySqlCommand komutum=new MySqlCommand("Select*From bolumler",(new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while(okunan.Read())
            {
                okunanBolumler.Add(new bolum(Convert.ToInt32(okunan[0]),okunan[1].ToString(),okunan[2].ToString()));
            }
            return okunanBolumler;
        }
        
        internal void bolumKaydet(bolum bolum)
        {
            (new MySqlCommand("insert into bolumler(bolumad,bolumtel)values('" + bolum.Ad + "','" + bolum.Tel + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void bolumSil(bolum bolum)
        {
            (new MySqlCommand("delete from bolumler where bolumid= "+ bolum.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
        internal void bolumGuncelle(bolum bolum)
        {
            (new MySqlCommand("update bolumler set bolumad='"+bolum.Ad+"',bolumtel='"+bolum.Tel+"' where bolumid="+bolum.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
            
        }
    }
}
