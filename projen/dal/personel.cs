namespace projen.dal
{
    public class personel
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
        
        

        public personel(int bolumid, string ad, string tel, string adres)
        {
            this.Bolumid = bolumid;
            this.Ad = ad;
            this.Tel = tel;
            this.Adres = adres;
        }
        
        public personel(string text1, string text2, string text3)
        {
            this.Ad = text1;
            this.Adres = text2;
            this.Tel = text3;
        }
        
        public personel(int ıdpersonel)
        {
            this.Idpersonel = ıdpersonel;
        }

        public override string ToString()
        {
            return this.Ad;
        }
    }
}