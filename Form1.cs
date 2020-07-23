using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonforclear_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "0";
            this.label1.ResetText();
            this.first_num_label.ResetText();
            this.label_operator.ResetText();
        }

        private void buttonfor0_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void buttonforOne_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void buttonforTwo_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void buttonforThree_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void buttonforFour_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void buttonforFive_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void buttonforSix_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void buttonforSeven_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void buttonforEight_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void buttonforNine_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void buttonforEqual_Click(object sender, EventArgs e)
        {
            
            double fn;
            double sn;
            double r;
            //-----------------
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.label1.Text, out sn);
            r = 0;
            //-----------------
            if (this.label_operator.Text == "+") 
            {
                r = fn + sn;
            }
            //------------------------------
            if (this.label_operator.Text == "-") 
            {
                r = fn - sn;
            }
            //------------------------------
            if (this.label_operator.Text == "*") 
            { 
                r = fn * sn;
            }
            //-----------------------------
            if (this.label_operator.Text == "/") 
            {
                r = fn / sn;
            }
            //-------------------------
            this.label1.Text = r.ToString();
            //--------------------------
            this.first_num_label.ResetText();
            this.label_operator.ResetText();
        }

        private void buttonforPlus_Click(object sender, EventArgs e)
        {
            this.label_operator.Text = "+";
            //If makes it so that they don't replace secondary label with nothing. 
            if (this.label1.Text!="")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void buttonforMinus_Click(object sender, EventArgs e)
        {
            this.label_operator.Text = "-";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void buttonforMultiply_Click(object sender, EventArgs e)
        {
            this.label_operator.Text = "*";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void buttonforDivision_Click(object sender, EventArgs e)
        {
            this.label_operator.Text = "/";
            if (this.label1.Text != "")
            {
                this.first_num_label.Text = this.label1.Text;
            }
            this.label1.ResetText();
        }

        private void first_num_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.first_num_label.Text = this.label1.Text;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text !="")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
        }
    }
}
