using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projen.domain
{
    class satis
    {
        int satisid;

        public int Satisid
        {
            get
            {
                return satisid;
            }

            set
            {
                satisid = value;
            }
        }

        int musteriid;
        public int Musteriid
        {
            get
            {
                return musteriid;
            }

            set
            {
                musteriid = value;
            }
        }

        int personelid;
        public int Personelid
        {
            get
            {
                return personelid;
            }

            set
            {
                personelid = value;
            }
        }

        int urunid;
        
        public int Urunid
        {
            get
            {
                return urunid;
            }

            set
            {
                urunid = value;
            }
        }
        int adet;
        

        public int Adet
        {
            get
            {
                return adet;
            }

            set
            {
                adet = value;
            }
        }
        
        public satis(int v1, int v2, int v3, int v4, int v5)
        {
            this.Satisid = v1;
            this.Musteriid = v2;
            this.Personelid = v3;
            this.Urunid= v4;
            this.Adet = v5;
        }
       

        public satis(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, TextBox textBox1)
        {
            this.Musteriid = Convert.ToInt32(comboBox1);
            this.Personelid = Convert.ToInt32(comboBox2);
            this.Urunid= Convert.ToInt32(comboBox3);
            this.Adet = Convert.ToInt32(textBox1);
        }

        public satis(int satisid)
        {
            this.Satisid = satisid;
        }

        public satis(int v2, int v3, int v4,int v5) 
        {
            this.Musteriid = v2;
            this.Personelid = v3;
            this.Urunid = v4;
            this.Adet = v4;
        }

        public override string ToString()
        {
            return this.Musteriid + "nolu müşteri" + this.Personelid + "nolu personel tarafından" + this.Urunid + "nolu ürünü" + this.Adet + "adet satın almıştır.";
        }

    }
}
