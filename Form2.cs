using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_working_with_matrices
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int columnNum;
        public int rowNum;
        public int notNullEl;
        public int maxEl;
        public Type matrixType;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|| textBox2.Text == ""|| textBox3.Text == ""
                || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Не все данные заполнены");
            }
            else if(int.Parse(textBox1.Text)* int.Parse(textBox2.Text)< int.Parse(textBox3.Text)
                || int.Parse(textBox4.Text) > 100)
            {
                MessageBox.Show("Введены неверные данные");
            }
            else
            {
                rowNum = int.Parse(textBox1.Text);
                columnNum = int.Parse(textBox2.Text);
                notNullEl = int.Parse(textBox3.Text);
                maxEl = int.Parse(textBox4.Text);
                if (comboBox1.Text == "Int")
                {
                    matrixType = typeof(Int32);
                }
                else if (comboBox1.Text == "Double")
                {
                    matrixType = typeof(Double);
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
