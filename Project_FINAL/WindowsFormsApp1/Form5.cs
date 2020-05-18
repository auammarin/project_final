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
    public partial class Form5 : Form
    {
        
        double num, num1, sum, sum1, sum2, sumn, sumf, sumper, sumall;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mea.or.th/upload/download/file_54da45f84e6d9b3c6940bd7c2ba99679.pdf");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            textBox1.Focus();
        }

        public Form5()
        {
            InitializeComponent();
            comboBox1.Items.Add(0.0912);
            comboBox1.Items.Add(0.1160);
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;
            label11.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label13.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            radioButton1.Parent = pictureBox1;
            radioButton2.Parent = pictureBox1;
            radioButton3.Parent = pictureBox1;
            label28.Parent = pictureBox1;
            label28.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;num1 = 0;sum = 0;sum1 = 0;sum2 = 0;sumn = 0;sumf = 0;sumper = 0;sumall = 0;
            if (radioButton1.Checked)
            {
                double a;
                a = double.Parse(comboBox1.Text);
                num = double.Parse(textBox1.Text);
                sum = num * 3.4149;
                sumn = sum + 312.24;
                sumf = num * a;
                sumper = (sumn - sumf) * 7 / 100;
                sumall = sumn + sumper - sumf;
                textBox2.Text = "312.24";
                textBox3.Text = sumf.ToString();
                textBox4.Text = sumper.ToString();
                textBox5.Text = sumall.ToString();
            }
            else if (radioButton2.Checked)
            {
                double a;
                a = double.Parse(comboBox1.Text);
                num = double.Parse(textBox1.Text);
                sum = num * 3.5849;
                sumn = sum + 312.24;
                sumf = num * a;
                sumper = (sumn - sumf) * 7 / 100;
                sumall = sumn + sumper - sumf;
                textBox2.Text = "312.24";
                textBox3.Text = sumf.ToString();
                textBox4.Text = sumper.ToString();
                textBox5.Text = sumall.ToString();
            }
            else if (radioButton3.Checked)
            {
                double a;
                a = double.Parse(comboBox1.Text);
                num = double.Parse(textBox1.Text);
                if (num > 10)
                {
                    num1 = num - 10;
                    sum = 10 * 2.8013;
                }
                else
                {
                    sum = num * 2.8013;
                }
                if (num1 >= 1)
                {
                    sum1 = num1 * 3.8919;
                }
                sum2 = sum + sum1 ;
                sumn = sum2 + 20;
                sumf = num * a;
                sumper = (sumn - sumf) * 7 / 100;
                sumall = sumn + sumper - sumf;
                textBox2.Text = "20";
                textBox3.Text = sumf.ToString();
                textBox4.Text = sumper.ToString();
                textBox5.Text = sumall.ToString();
            }
        }
    }
}
