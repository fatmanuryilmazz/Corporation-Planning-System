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
    public partial class urunForm : Form
    {
        public urunForm()
        {
            InitializeComponent();
        }

       

        private void urunForm_Load(object sender, EventArgs e)
        {
            urunoku();
        }
           void urunoku()
           {
            listBox1.Items.Clear();
              ArrayList okunanUrunler = ((new urunService()).urunGetir());
              foreach (urun u in okunanUrunler)
                {
                   listBox1.Items.Add(u);
                }
           }
        private void button1_Click(object sender, EventArgs e)
        {
            (new urunService()).urunKaydet(textBox1.Text);
            urunoku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new urunService()).urunSil(((urun)listBox1.SelectedItem).Id);
            urunoku();
        }
    }
}
