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
            MySqlConnection baglanti = new MySqlConnection("Server=---.--.--.-;Database=----------;Uid=--------;Password=-------");
            baglanti.Open();
            return baglanti;
        }
    }
}
