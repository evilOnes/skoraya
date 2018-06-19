namespace Skoraya
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chb_showPwd = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.tb_secondName = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // chb_showPwd
            // 
            this.chb_showPwd.AutoSize = true;
            this.chb_showPwd.Location = new System.Drawing.Point(245, 226);
            this.chb_showPwd.Name = "chb_showPwd";
            this.chb_showPwd.Size = new System.Drawing.Size(18, 17);
            this.chb_showPwd.TabIndex = 13;
            this.chb_showPwd.UseVisualStyleBackColor = true;
            this.chb_showPwd.CheckedChanged += new System.EventHandler(this.chb_showPwd_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(159, 305);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 23);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Регистрация";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(18, 305);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Отмена";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(92, 222);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(147, 22);
            this.tb_pwd.TabIndex = 9;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(92, 187);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(147, 22);
            this.tb_log.TabIndex = 8;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(92, 75);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(147, 22);
            this.tb_lastName.TabIndex = 8;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(92, 103);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '*';
            this.tb_name.Size = new System.Drawing.Size(147, 22);
            this.tb_name.TabIndex = 9;
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Location = new System.Drawing.Point(15, 78);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(70, 17);
            this.tb1.TabIndex = 10;
            this.tb1.Text = "Фамилия";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(15, 106);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(35, 17);
            this.l_name.TabIndex = 14;
            this.l_name.Text = "Имя";
            // 
            // tb_secondName
            // 
            this.tb_secondName.Location = new System.Drawing.Point(92, 131);
            this.tb_secondName.Name = "tb_secondName";
            this.tb_secondName.PasswordChar = '*';
            this.tb_secondName.Size = new System.Drawing.Size(147, 22);
            this.tb_secondName.TabIndex = 9;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(15, 134);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(71, 17);
            this.l2.TabIndex = 14;
            this.l2.Text = "Отчество";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_showPwd);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_secondName);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_log);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_showPwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox tb_secondName;
        private System.Windows.Forms.Label l2;
    }
}