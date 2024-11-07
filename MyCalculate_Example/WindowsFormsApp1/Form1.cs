using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value , (int)txtNumber2.Value);
                MessageBox.Show("Sum Is = " + sum);
            }

        }
        bool ValidateInputs()
        {
            bool isValid = true;
            if(txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if(txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return isValid;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum Is = " + sum);
            }

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum Is = " + sum);
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum Is = " + sum);
            }

        }
    }
}
