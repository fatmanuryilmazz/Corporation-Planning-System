using projen.dal;
using projen.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projen.service
{
    class satisService
    {
        internal ArrayList satisGetir()
        {
            return (new satisDao().satisOku());
        }

        internal void satisKaydet(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, TextBox textBox1)
        {
            (new satisDao()).satisKaydet(new satis(comboBox1,comboBox2,comboBox3,textBox1));
        }

        internal void satisSil(int satisid)
        {
            (new satisDao()).satisSil(new satis(satisid));
        }

        internal void satisguncelle(int v2, int v3, int v4, int v5)
        {
            (new satisDao()).satisGuncelle(new satis(v2,v3,v4,v5));
        }
    }
}
