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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bolumoku();
        }
            void bolumoku()
            {
            listBox1.Items.Clear();
                ArrayList okunanBolumler = ((new bolumService()).bolumGetir());
                foreach (bolum b in okunanBolumler)
                {
                    listBox1.Items.Add(b);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            (new bolumService()).bolumKaydet(textBox1.Text,textBox2.Text);
            bolumoku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new bolumService()).bolumSil(((bolum)listBox1.SelectedItem).Id);
            bolumoku();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new bolumGüncellemeform((bolum)listBox1.SelectedItem)).Show(); 
        }
    }
}
