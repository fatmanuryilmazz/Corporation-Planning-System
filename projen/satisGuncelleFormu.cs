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
    public partial class satisGuncelleFormu : Form
    {
        public satisGuncelleFormu(satis gSatis)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = gSatis.Musteriid;
            comboBox2.SelectedIndex = gSatis.Personelid;
            comboBox3.SelectedIndex = gSatis.Urunid;
            textBox1.Text = gSatis.Adet.ToString();
        }

        private void satisGuncelleFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new satisService()).satisguncelle(Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(comboBox2.SelectedItem), Convert.ToInt32(comboBox3.SelectedItem),Convert.ToInt32( textBox1.Text));
        }
    }
}
