using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cash = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int water, ticket, tea, pop ,sum;
            pop = Convert.ToInt32(textBox1.Text);
            tea = Convert.ToInt32(textBox2.Text);
            water = Convert.ToInt32(textBox3.Text);
            ticket = Convert.ToInt32(textBox4.Text);

            sum = pop * 100 + tea * 40 + ticket * 200 + water * 20;
            crp.Text = sum.ToString() +"TL";
            cash = cash + sum;

            tillP.Text = cash.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
