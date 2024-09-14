using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxprograme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = null;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=0, y=0, z=0;
            if(textBox1.Text.Trim()==null &&textBox2.Text.Trim()==null)
            {
                MessageBox.Show("ادخل للصندوقين الفارغين");
                textBox1.Focus();
                return;
                    }
            else if(textBox1.Text.Trim()==null)
            {
                MessageBox.Show("ادخل للصندوق الاول فارغ");
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text.Trim() == null)
            {
                MessageBox.Show("ادخل للصندوق الثاني فارغ");
                textBox2.Focus();
                return;
            }
            else if (textBox1.Text.Trim() != null && textBox2.Text.Trim() != null)
            {
                string op = comboBox1.Text;
              switch(op)
                    {
                    case "+":
                        x = Convert.ToInt32(textBox1.Text);
                        y = Convert.ToInt32(textBox2.Text);
                        z = x + y;
                        break;
                    case "-":
                        x = Convert.ToInt32(textBox1.Text);
                        y = Convert.ToInt32(textBox2.Text);
                        z = x - y;
                    break;
                    case "*":
                        x = Convert.ToInt32(textBox1.Text);
                        y = Convert.ToInt32(textBox2.Text);
                        z = x * y;
                        break;
                    case "/":
                        {
                            x = Convert.ToInt32(textBox1.Text);
                            y = Convert.ToInt32(textBox2.Text);
                            if (y != 0)
                            {
                                z = x / y;
                            }
                            else
                            {
                                MessageBox.Show("القسمة على الصفر");
                                return;
                            }
                            break;
                        }
                    default:
                        MessageBox.Show("العملية المدخلة خاطئة");
                        break;
                }
                if(z!=0)
                textBox3.Text = z.ToString();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
