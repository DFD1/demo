using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private double a=0;
        private double b=0;
        private String opr="";
       private bool oprPress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if(oprPress)
            {
                lbl.Text = ((Button)sender).Text;
            }
            else {
                lbl.Text += ((Button)sender).Text;
                lbl.Text = double.Parse(lbl.Text).ToString();
            }
            oprPress = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
        }
        private void btnEqu_Click(object sender, EventArgs e)
        {
            b = double.Parse(lbl.Text);
            switch(opr)
                {
                case "+": lbl.Text = (a + b).ToString();
                    break;
                case "-":lbl.Text = (a - b).ToString();
                    break;
                case "x":lbl.Text = (a * b).ToString();
                    break;
                case "/":
                    try {
                        lbl.Text = (a / b).ToString();
                    }
                    catch
                        {
                        MessageBox.Show("");      
                    }
                    
                    break;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            a =double.Parse( lbl.Text);
            opr = ((Button)sender).Text;
            oprPress = true;
        }
    
    }
}
