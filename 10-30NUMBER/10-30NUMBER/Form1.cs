using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_30NUMBER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] numsInString = textBox1.Text.Split(' ');
            List<double> numbers = new List<double>();
            foreach (string s in numsInString)
            {
                numbers.Add(double.Parse(s));
            }


            foreach (double x in numbers)
            {
                if (x >= 10 && x <= 30)
                {
                    label1.Text += $"{x}  ";
                }
            }
        }
    }
}
