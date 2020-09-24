using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projen
{
    class dbBaglanti
    {
        internal MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=fatmanuryilmazdb;Uid=fatmanuryilmaz;Password=yilmaz.123");
            baglanti.Open();
            return baglanti;
        }
    }
}
