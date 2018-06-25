using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace ModuleTytyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sign=true;
        int Num;
        int Step;
        int Mod;

        private void button1_Click(object sender, EventArgs e)
        {
            sign = true;
            Step = Convert.ToInt32(textBox2.Text);
            Mod = Convert.ToInt32(textBox3.Text);

            Num = Convert.ToInt32(textBox1.Text);

            Class1 l = new Class1(Num, Step, Mod, sign);
            label1.Text = l.ModeleRes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && textBox1.Text.Length == 0)
                return;
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8 || textBox1.Text.Length>8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8 || textBox2.Text.Length > 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8 || textBox3.Text.Length > 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
