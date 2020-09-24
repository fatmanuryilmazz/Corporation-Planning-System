using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projen.domain
{
    public class urun
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
        
        public urun(int v1, string v2)
        {
            this.Id = v1;
            this.Ad = v2;
        }

        public urun(string text)
        {
            this.Ad = text;
        }

        public urun(int ıd)
        {
            this.Id = ıd;
        }

        public override string ToString()
        {
            return this.Ad;
        }

    }
}
