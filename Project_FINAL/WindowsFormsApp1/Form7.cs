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
    public partial class Form7 : Form
    {
        double num, sum, sumf, sumper, sumall;

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mea.or.th/upload/download/file_ec89154205bf64d98b7e9011c857b923.pdf");
        }

        private void หน่วย_TextChanged(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            หน่วย.Clear();
            หน่วย.Focus();
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = 0;sum = 0;sumf = 0;sumper = 0;sumall = 0;
            double a;
            a = double.Parse(comboBox1.Text);
            num = double.Parse(หน่วย.Text);
            sum = num * 6.8025;
            sumf = num * a;
            sumper = (sum - sumf) * 7 / 100;
            sumall = sum + sumper - sumf;
            textBox10.Text = sumf.ToString();
            textBox11.Text = sumper.ToString();
            textBox12.Text = sumall.ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
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
        }
    }
}
