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

namespace Skoraya
{
    public partial class Auth : Form
    {


        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            tb_log.Text = "user";
            tb_pwd.Text = "user";
        }

        private void chb_showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showPwd.Checked)
                tb_pwd.PasswordChar = '\0';
            else
                tb_pwd.PasswordChar = '*';
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            Hide();
            //bool res = false;
            //MySqlConnection c = new MySqlConnection("Server=localhost; Database=storage_GSM; User id = root; password=;");
            //MySqlCommand cmd = c.CreateCommand();
            //MySqlDataReader r;
            //c.Open();

            //cmd.CommandText = "select login, idType from user where pwd = '" + tb_pwd.Text + "'";
            //r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    if (tb_log.Text == r[0].ToString() && r[1].ToString() == "1")
            //        res = true;
            //}
            //r.Close();
            //c.Close();

            //if (res)
            //{
            //    Main f = new Main();
            //    Hide();
            //    f.Show();
            //}
            //else
            //    MessageBox.Show("Проверьте данные еще раз. Что-то тут не так");

        }


    }
}
