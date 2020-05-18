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
    public partial class Form6 : Form
    {
        double num, num1, sum, sum1, sum2, sumn, sumf, sumper, sumall;

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mea.or.th/upload/download/file_ec1f2126e5fb18435b1ef98566c4ae50.pdf");
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void หน่วย_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void หน่วย_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            หน่วย.Clear();
            หน่วย.Focus();
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = 0;num1 = 0;sum = 0;sum1 = 0;sum2 = 0;sumn = 0;sumf = 0;sumper = 0;sumall = 0;
            double a;
            a = double.Parse(comboBox1.Text);
            num = double.Parse(หน่วย.Text);
            if (num > 100)
            {
                num1 = num - 100;
                sum = 100 * 2.0889;
            }
            else
            {
                sum = num * 2.0889;
            }
            if (num1 >= 1) 
            {
                sum1 = num1 * 3.2405;
            }
            sum2 = sum + sum1;
            sumn = sum2 + 115.16;
            sumf = num * a;
            sumper = sumper = (sumn - sumf) * 7 / 100;
            sumall = sumn + sumper - sumf;
            textBox8.Text = sum.ToString();
            textBox7.Text = sum1.ToString();
            textBox10.Text = sumf.ToString();
            textBox11.Text = sumper.ToString();
            textBox12.Text = sumall.ToString();
            textBox1.Text = "115.16";
        }
    }
}
