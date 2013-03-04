using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzz
{
    // Write a program that prints the numbers from 1 to 100. 
    // But for multiples of three print “Fizz” instead of the number 
    // and for the multiples of five print “Buzz”. For numbers which 
    // are multiples of both three and five print “FizzBuzz”.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DoFizzBuzz();
        }

        private void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string s = "";
                if (i % 3 == 0)
                    s += "Fizz";
                if (i % 5 == 0)
                    s += "Buzz";

                if (string.IsNullOrEmpty(s))
                    s = i.ToString();

                txtOut.Text += s + System.Environment.NewLine;
            }

            MessageBox.Show(txtOut.Text);
        }
    }
}
