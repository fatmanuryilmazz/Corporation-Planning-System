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
    public partial class satisForm : Form
    {
        public satisForm()
        {
            InitializeComponent();
        }

        private void satisForm_Load(object sender, EventArgs e)
        {
            satisoku();
        }
        void satisoku()
        {
            listBox1.Items.Clear();
            ArrayList okunanSatislar = ((new satisService()).satisGetir());
            foreach (satis s in okunanSatislar)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new satisService()).satisKaydet(comboBox1,comboBox2,comboBox3,textBox1);
            satisoku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new satisService()).satisSil(((satis)listBox1.SelectedItem).Satisid);
            satisoku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new satisGuncelleFormu((satis)listBox1.SelectedItem)).Show();
        }
    }
}
