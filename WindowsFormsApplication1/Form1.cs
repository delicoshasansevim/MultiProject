using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{ 
    public partial class Form1 : Form
    {
        // global area
        string reg1 = String.Empty;
        string reg2 = String.Empty;
        byte status =1;

        string op = String.Empty;


        public Form1()
        {
            InitializeComponent();

            this.button1.Click += new EventHandler(ButtonZ_Click);
            this.button2.Click += new EventHandler(ButtonZ_Click);
            this.button3.Click += new EventHandler(ButtonZ_Click);
            this.button4.Click += new EventHandler(ButtonZ_Click);
            this.button5.Click += new EventHandler(ButtonZ_Click);
            this.button6.Click += new EventHandler(ButtonZ_Click);
            this.button7.Click += new EventHandler(ButtonZ_Click);
            this.button8.Click += new EventHandler(ButtonZ_Click);
            this.button9.Click += new EventHandler(ButtonZ_Click);
            this.button10.Click += new EventHandler(ButtonZ_Click);
            this.button11.Click += new EventHandler(ButtonZ_Click);


            this.button12.Click += new EventHandler(ButtonOp_Click);
            this.button13.Click += new EventHandler(ButtonOp_Click);
            this.button14.Click += new EventHandler(ButtonOp_Click);
            this.button15.Click += new EventHandler(ButtonOp_Click);
            


        }


        private void ButtonZ_Click(object Sender, EventArgs e)
        { 
            var cmd = (Button)Sender;

            switch(status)
            {

                case 1: reg1 = cmd.Text;
                    label1.Text = reg1;
                    break;

                    case 2: reg2 = cmd.Text;
                    label1.Text = reg1 + op + reg2;
                    break;
          
                default:break;
            }
        }



        Button void ButtonOp_Click(object Sender, EventArgs e)
        {
            
        }


    } // end of class
} // end of namespace
