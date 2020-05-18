using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            MySqlCommand command = new MySqlCommand("INSERT INTO `id`(`firstname`, `lastname`, `sex`, `date`, `username`, `password`) VALUES (@F, @L, @S, @D, @U, @P)",class1.GetConnection());
            command.Parameters.Add("@F", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@D", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@U", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = textBox6.Text;
            class1.openconection();
            if (textBox6.Text.Equals(textBox7.Text))
            {
                if (CUN())
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Save successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("username have been used");
                }
            }
            else
            {
                MessageBox.Show("password  not match");
            }
            class1.closeconection();
        }
        public bool CUN()
        {
            Class1 class1 = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `id` WHERE `username`=@user ", class1.GetConnection());
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBox5.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
