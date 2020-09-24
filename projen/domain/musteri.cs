using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.domain
{
    public class musteri
    {
        int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        string ad;
        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        string soyad;
        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }
        string adres;
        public string Adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
            }
        }
        string tel;
        

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }
        

        public musteri(int v1, string v2, string v3, string v4, string v5)
        {
            this.Id = v1;
            this.Ad = v2;
            this.Soyad = v3;
            this.Adres = v4;
            this.Tel = v5;
        }


        public musteri(string text1, string text2, string text3, string text4)
        {
            this.Ad = text1;
            this.Soyad = text2;
            this.Adres = text3;
            this.Tel = text4;
        }

        public musteri(int ıd)
        {
            this.Id = ıd;
        }

        public override string ToString()
        {
            return this.Ad;
        }
    }
}
