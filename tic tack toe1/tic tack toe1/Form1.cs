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

namespace tic_tack_toe1
{
    public partial class Form1 : Form
    {
        Random rnd=new Random();
        string t = "";
        int[] array = new int[9];
        Button[] btn = new Button[9];
        public Form1()
        {


            InitializeComponent();
            if (rnd.Next(1,10) >= 5)
            {
                t = "крестикт";
                label1.Text = "ходят x";
            }
            else
            {
                t = "крестasdfикт";
                label1.Text = "ходят 0";
            }
            btn[0] = button9;
            btn[1] = button1;
            btn[2] = button8;
            btn[3] = button6;
            btn[4] = button7;
            btn[5] = button5;
            btn[6] = button4;
            btn[7] = button3;
            btn[8] = button2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (t == "крестикт")
            {
                for(int i = 0;i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text ="x" ;
                        label1.Text= "Ходит нолик" ;
                        t = "e";
                        btn[i].Enabled = false ;
                        array[i]= 1;
                        break;
                    }
                }
            }   
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "o";
                        label1.Text = "Ходит крестик";
                        t= "крестикт";
                        btn[i].Enabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }
            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled= false ;
                }
                 label1.Text ="Выйграли крестики";

            }
            else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
           else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            else if (array[0] == 1 && array[4] == 1 && array[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            else if (array[1] == 1 && array[3] == 1 && array[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            else if (array[0] == 1 && array[3] == 1 && array[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            else if (array[2] == 1 && array[3] == 1 && array[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли крестики";

            }
            if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[3] ==2 && array[4] == 2 && array[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[0] == 2 && array[4] ==2 && array[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[1] == 2 && array[3] == 2&& array[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[0] == 2 && array[3] == 2 && array[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[2] == 2 && array[3] == 2 && array[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }
            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                label1.Text = "Выйграли нолики";

            }


        }

        private void button10_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < btn.Length;i++)
            {
                array[i] = 0;
                btn[i].Text = "";
                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
                if (rnd.Next(1, 10) >= 5)
                {
                    t = "крестикт";
                    label1.Text = "ходят x";
                }
                else
                {
                    t = "крестasdfикт";
                    label1.Text = "ходят 0";
                }
            }
          
        }
    }
}
