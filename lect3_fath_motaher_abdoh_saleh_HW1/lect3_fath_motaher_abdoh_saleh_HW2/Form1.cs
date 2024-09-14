using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect3_fath_motaher_abdoh_saleh_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1.Text = num2.Text = num3.Text = op1.Text = op2.Text = result.Text = null;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(num1.Text);
            double number2= Convert.ToDouble(num2.Text);
            double number3 = Convert.ToDouble(num3.Text);
            string operation1 = op1.Text;
            string operation2 = num2.Text;
            result.Text = performancewithpriority(number1, number2, number3, operation1, operation2).ToString();

        }
        private double performanceoperation(double n1, double n2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    {
                        if (n2 != 0)
                            return n1 / n2;
                        else
                        { MessageBox.Show("القسمة على الصفر");
                            return double.NaN;
                        }
                    }
                default:
                    return double.NaN;
            } 
        }
        private double performancewithpriority(double n1, double n2, double n3, string op1, string op2)
        {
            double result;
            if (op1 == "*" || op1 == "/")
            {
                result = performanceoperation(n1, n2, op1);
                result = performanceoperation(result, n3, op2);
            }
            else if (op2 == "*" || op2 == "/")
            {
                result = performanceoperation(n2, n3, op2);
                result = performanceoperation(n1, result, op1);
            }
            else
            {
                result = performanceoperation(n1, n2, op1);
                result = performanceoperation(result, n3, op2);
            }
            return result;
        }
         
}
}
