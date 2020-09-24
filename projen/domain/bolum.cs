using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.domain
{
    public class bolum
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
        

        public bolum(int v1, string v2, string v3)
        {
            this.Id = v1;
            this.Ad = v2;
            this.Tel = v3;
        }
        public bolum(string gAd, string gTel)
        {
            this.Ad = gAd;
            this.Tel = gTel;
        }

        public bolum(int gId)
        {
            this.Id = gId;
        }
        

        public override string ToString()
        {
            return this.Ad;
        }
    }
}
