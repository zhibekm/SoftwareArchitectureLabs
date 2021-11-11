using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char sign = Convert.ToChar(textBox3.Text);
            if (sign == '+')
            {
                int ans = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Text = textBox2.Text);
                textBox4.Text = ans.ToString();
            }
            else if (sign == '-')
            {
                int ans = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Text = textBox2.Text);
                textBox4.Text = ans.ToString();
            }
            else if (sign == '*')
            {
                int ans = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(Text = textBox2.Text);
                textBox4.Text = ans.ToString();
            }
            else
            {
                int ans = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(Text = textBox2.Text);
                textBox4.Text = ans.ToString();
            }
        }
    }
}
