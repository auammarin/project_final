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
    public partial class Form1 : Form
    {
        public static string user2;
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `id` WHERE `username`=@user AND`password`=@pass",class1.GetConnection());
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MySqlCommand check = new MySqlCommand("INSERT INTO `check`(`username`, `date`) VALUES (@user,@date)", class1.GetConnection());
                check.Parameters.Add("@user", MySqlDbType.VarChar).Value = username.Text;
                check.Parameters.Add("@date", MySqlDbType.VarChar).Value = DateTime.Now.ToLongDateString() +" / "+ DateTime.Now.ToShortTimeString();
                class1.openconection();
                check.ExecuteNonQuery();
                class1.closeconection();
                user2 = username.Text;
                MessageBox.Show("Success");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unsuccess");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
