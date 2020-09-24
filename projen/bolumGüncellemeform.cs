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
    public partial class bolumGüncellemeform : Form
    {
        public bolumGüncellemeform(bolum gBol)
        {
            InitializeComponent();
            textBox1.Text = gBol.Ad;
            textBox2.Text = gBol.Tel;
            label3.Text = gBol.Id.ToString();
        }

        private void bolumGüncellemeform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new bolumService()).bolumguncelle(Convert.ToInt32(label3.Text),textBox1.Text,textBox2.Text);
        }
    }
}
