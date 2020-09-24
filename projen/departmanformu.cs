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
    public partial class departmanformu : Form
    {
        public departmanformu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new personelform()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new urunForm()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new satısformu()).Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            (new musteriFormu()).Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
