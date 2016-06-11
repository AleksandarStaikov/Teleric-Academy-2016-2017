using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AleksandarStaikov_11b_TP4_02
{
    public partial class Form1 : Form
    {
        int principal;
        int years;
        double interestRate;
        decimal amount;
        string output = "Year\tAmount on Deposit" + Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            principal = int.Parse(textBox1.Text);
            interestRate = double.Parse(textBox2.Text);
            years = (int)numericUpDown1.Value;

            for (int i = 1; i <= years; i++)
            {
                amount = (decimal)(principal * Math.Pow((1 + interestRate / 100), i));
                output += i + "\t" + string.Format("{0:F2}лв.", amount) + Environment.NewLine;
            }

            textBox3.Text = output;
        }
    }
}
