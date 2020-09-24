using MySql.Data.MySqlClient;
using projen.dal;
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
using static projen.domain.Personel;

namespace projen
{
    public partial class personelform : Form
    {
        public personelform()
        {
            InitializeComponent();
        }

        private void personelform_Load(object sender, EventArgs e)
        {
            MySqlCommand komutum = new MySqlCommand("Select*From bolumler", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                comboBox1.Items.Add(new bolum(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString()));
            }
            
            personeloku();
        }
        void personeloku()
        {
            listBox1.Items.Clear();
            ArrayList okunanPersoneller = ((new personelService()).personelGetir());
            foreach (personel p in okunanPersoneller)
            {
                listBox1.Items.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new personelService()).personelekle(comboBox1.SelectedIndex, textBox1.Text, textBox2.Text, textBox3.Text);
            personeloku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new personelService()).personelSil(((personel)listBox1.SelectedItem).Idpersonel);
            personeloku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new personelguncellemeform((personel)listBox1.SelectedItem)).Show();
        }
    }
}
