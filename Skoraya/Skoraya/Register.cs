using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoraya
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string n1 = tb_name.Text,
                n2 = tb_lastName.Text,
                n3 = tb_secondName.Text,
                l = tb_log.Text,
                p = tb_pwd.Text;
            //insert new user

            MessageBox.Show("Пользователь зарегистрирован.");
        }
    }
}
