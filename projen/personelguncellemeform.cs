using projen.dal;
using projen.domain;
using projen.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projen
{
    public partial class personelguncellemeform : Form
    {
        
        public personelguncellemeform(personel gPer)
        {
            InitializeComponent();
            
            textBox1.Text = gPer.Ad;
            textBox2.Text = gPer.Tel;
            textBox3.Text = gPer.Adres;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void personelguncellemeform_Load(object sender, EventArgs e)
        {
            (new personelService()).personelguncelle(textBox1.Text, textBox2.Text,textBox3.Text);
        }
    }
}
