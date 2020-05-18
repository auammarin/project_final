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
    public partial class Form3 : Form
    {
        double num, num1, num2, num3, num4, num5, num6, sum, sum1, sum2, sum3, sum4, sum5, sum6, sum7, sumn, sumf, sumper, sumall;

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mea.or.th/upload/download/file_0cbe47e5f271ef298469220a52ae00d8.pdf");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void รีเซ็ต_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox13.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            textBox1.Focus();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
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
            label15.Parent = pictureBox1;
            label16.Parent = pictureBox1;
            label17.Parent = pictureBox1;
            label18.Parent = pictureBox1;
            label19.Parent = pictureBox1;
            label20.Parent = pictureBox1;
            label21.Parent = pictureBox1;
            label22.Parent = pictureBox1;
            label23.Parent = pictureBox1;
            label24.Parent = pictureBox1;
            label25.Parent = pictureBox1;
            label26.Parent = pictureBox1;
            label27.Parent = pictureBox1;
            label28.Parent = pictureBox1;
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
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            label22.BackColor = Color.Transparent;
            label23.BackColor = Color.Transparent;
            label24.BackColor = Color.Transparent;
            label25.BackColor = Color.Transparent;
            label26.BackColor = Color.Transparent;
            label27.BackColor = Color.Transparent;
            label28.BackColor = Color.Transparent;


        }

        private void คำนวณ_Click(object sender, EventArgs e)
        {
            sum = 0;sum1 = 0;sum2 = 0;sum3 = 0;sum4 = 0;sum5 = 0;sum6 = 0;sum7 = 0;sumn = 0;sumf = 0;sumper = 0;sumall = 0;
            num = 0;num1 = 0;num2 = 0;num3 = 0;num4 = 0;num5 = 0;num6 = 0;
            double a;
            a = double.Parse(comboBox1.Text);
            num = double.Parse(textBox1.Text);
            if (num > 15)
            {
                num1 = num - 15;
                sum = 15 * 2.3488;
            }
            else
            {
                sum = num * 2.3488;
            }
            if (num1 > 10)
            {
                num2 = num1 - 10;
                sum1 = 10 * 2.9882;
            }
            else
            {
                sum1 = num1 * 2.9882;
            }
            if (num2 > 10)
            {
                num3 = num2 - 10;
                sum2 = 10 * 3.2405;
            }
            else
            {
                sum2 = num2 * 3.2405;
            }
            if (num3 > 65)
            {
                num4 = num3 - 65;
                sum3 = 65 * 3.6237;
            }
            else
            {
                sum3 = num3 * 3.6237;
            }
            if (num4 > 50)
            {
                num5 = num4 - 50;
                sum4 = 50 * 3.7171;
            }
            else
            {
                sum4 = num4 * 3.7171;
            }
            if (num5 > 250)
            {
                num6 = num5 - 250;
                sum5 = 250 * 4.2218;
            }
            else
            {
                sum5 = num5 * 4.2218;
            }
            if (num6 > 1)
            {
                sum6 = num6 * 4.4217;
            }
            sum7 = sum + sum1 + sum2 + sum3 + sum4 + sum5 + sum6;
            sumn = sum7 + 8.19;
            sumf = num * a;
            sumper = (sumn - sumf) * 7 / 100;
            sumall = sumn + sumper - sumf;
            textBox8.Text = sum.ToString();
            textBox7.Text = sum1.ToString();
            textBox6.Text = sum2.ToString();
            textBox5.Text = sum3.ToString();
            textBox4.Text = sum4.ToString();
            textBox3.Text = sum5.ToString();
            textBox2.Text = sum6.ToString();
            textBox13.Text = "8.19";
            textBox10.Text = sumf.ToString();
            textBox11.Text = sumper.ToString();
            textBox12.Text = sumall.ToString();
        }
    }
}
