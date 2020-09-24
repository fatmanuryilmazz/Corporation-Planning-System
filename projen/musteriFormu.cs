using projen.domain;
using projen.service;
using System;
using System.Collections;
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
    public partial class musteriFormu : Form
    {
        public musteriFormu()
        {
            InitializeComponent();
        }

        private void musteriFormu_Load(object sender, EventArgs e)
        {
            musterioku();
        }
        void musterioku()
        {
            listBox1.Items.Clear();
            ArrayList okunanMusteriler = ((new musteriService()).musteriGetir());
            foreach (musteri m in okunanMusteriler)
            {
                listBox1.Items.Add(m);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musteriService()).musteriKaydet(textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text);
            musterioku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new musteriService()).musteriSil(((musteri)listBox1.SelectedItem).Id);
            musterioku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new musteriGuncellemeFormu((musteri)listBox1.SelectedItem)).Show();
        }
    }
}
