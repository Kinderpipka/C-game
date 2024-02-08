using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_2
{
    
    public partial class Form1 : Form
    {
        double first_num;
        char user_action=' ';
        bool equal=false;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            string btn= ((Button)sender).Text;
            
            if (label1.Text == "0"|| equal)
            {
                label1.Text = btn;
                equal = false;
            }
            else
            {
                label1.Text+= btn;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            math_action('/');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            math_action('*');
        }
      

        private void button15_Click(object sender, EventArgs e)
        {
            math_action('-');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            math_action('+');
        }
        private void math_action(char sd)
        {
            

            first_num = Convert.ToDouble(label1.Text);
            user_action = sd;
            label1.Text = "0";
        }
        private void button19_Click(object sender, EventArgs e)
        {
           if (user_action == ' ')
            
                return ;
            

            double res=0;
            double second = Convert.ToDouble(label1.Text);
            switch (user_action)
            {
                case '+':
                    res=first_num+second; break;
                case '-':
                    res = first_num - second; break;
                case '*':
                    res = first_num * second; break;
                case '%':
                    res = first_num * second/100; break;
                case '/':
                    if (second == 0) 
                    {
                        res = 0;
                        MessageBox.Show("нельзя делить на 0"); 
                    }
                    else
                    res = first_num / second;
                    
                    break;
            }
            equal = true;
            label1.Text=Convert.ToString(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            first_num = 0;
            user_action = ' ';
            equal = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(label1.Text);
            num *= -1;
            label1.Text=Convert.ToString(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            math_action('%');
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (!label1.Text.Contains(","))
                label1.Text = label1.Text + ",";
        }
    }
}
