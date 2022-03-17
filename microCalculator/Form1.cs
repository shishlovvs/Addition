using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microCalculator
{
    public partial class Form1 : Form
    {
        string s;
        double a, b, n;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            n = a + b;
            button1.Text = Convert.ToString(n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
