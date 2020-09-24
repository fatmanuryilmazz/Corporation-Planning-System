using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projen.domain;
using projen.service;

namespace projen
{
    public partial class musteriGuncellemeFormu : Form
    {
        private musteri selectedItem;

        public musteriGuncellemeFormu(musteri gMus)
        {
            InitializeComponent();
            textBox1.Text = gMus.Ad;
            textBox2.Text = gMus.Soyad;
            textBox3.Text = gMus.Adres;
            textBox4.Text = gMus.Tel;
        }
        
        private void musteriGuncellemeFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musteriService()).musteriGuncelle(textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text);
        }
    }
}
