using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        float a, b, c;
        int count;
        bool znak;
        float np;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 3;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 9;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 4; 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            
                a = float.Parse(tb1.Text);
                tb1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
           
               
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            np = float.Parse(tb1.Text);
            if (np == 0)
            {
                tb1.Text = tb1.Text + " на ноль делить нельзя ";
            }
            else
            {
                calculate();
                label1.Text = "";
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            //clear
            tb1.Text = " ";
        }

        private void Drob_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ",";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(tb1.Text);
                    tb1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
