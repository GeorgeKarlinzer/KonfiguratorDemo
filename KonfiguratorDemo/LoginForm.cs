using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace KonfiguratorDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string pass = passField.Text;

            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L AND `pass` = @P", dB.GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.Dispose();
             
            if(table.Rows.Count > 0)
            {
                MainForm main = new MainForm();
                main.Show();
                Hide();
            }
            else
                MessageBox.Show("Logowanie nie powiodło się");
        }
    }
}
