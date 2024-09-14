using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect3_fath_motaher_abdoh_saleh_HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = labelsum.Text = labelfactorial.Text = labelsqrt.Text = null;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int n = Convert.ToInt32(textBox1.Text);
                for (int i = 1; i <= n; i++)
                    sum += i;
                labelsum.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("الصندوق فارغ يرجى ادخال قيمة الى الصندوق");
                textBox1.Focus();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            try {
                long f = 1;
                int n = Convert.ToInt32(textBox1.Text);
                for (int i = 1; i <= n; i++)
                    f *= i;
                labelfactorial.Text = f.ToString(); }
              catch (Exception)
            {
                MessageBox.Show("الصندوق فارغ يرجى ادخال قيمة الى الصندوق");
                textBox1.Focus();
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try {
                int n = Convert.ToInt32(textBox1.Text);
                labelsqrt.Text = Convert.ToString(Math.Sqrt(n)); }
            catch (Exception)
            {
                MessageBox.Show("الصندوق فارغ يرجى ادخال قيمة الى الصندوق");
                textBox1.Focus();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = labelsum.Text = labelfactorial.Text = labelsqrt.Text = null;
        }
    }
}
