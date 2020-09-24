using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.domain
{
    public class Personel
    {
        
        int bolumid;
        public int Bolumid
        {
            get
            {
                return bolumid;
            }

            set
            {
                bolumid = value;
            }
        }
        int idpersonel;

        public int Idpersonel
        {
            get
            {
                return idpersonel;
            }

            set
            {
                idpersonel = value;
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

        public Personel(int idpersonel,int bolumid,string ad, string tel,string adres)
            {

                this.Idpersonel = idpersonel;
                this.Bolumid = bolumid;
                this.Ad = ad;
                this.Tel = tel;
                this.Adres = adres;
            }
        
        
        public override string ToString()
        {
            return this.Ad;
        }
    }
       

    }

