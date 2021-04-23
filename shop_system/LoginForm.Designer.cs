
namespace shop_system
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnpassword = new System.Windows.Forms.TextBox();
            this.btnusername = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_abount = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnpassword
            // 
            this.btnpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnpassword.Location = new System.Drawing.Point(565, 438);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.PasswordChar = '*';
            this.btnpassword.Size = new System.Drawing.Size(283, 23);
            this.btnpassword.TabIndex = 37;
            // 
            // btnusername
            // 
            this.btnusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnusername.Location = new System.Drawing.Point(565, 373);
            this.btnusername.Name = "btnusername";
            this.btnusername.Size = new System.Drawing.Size(283, 23);
            this.btnusername.TabIndex = 36;
            // 
            // login
            // 
            this.login.FlatAppearance.BorderSize = 3;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login.ForeColor = System.Drawing.Color.Crimson;
            this.login.Location = new System.Drawing.Point(565, 567);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(283, 32);
            this.login.TabIndex = 35;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "USER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(558, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Please Login Here";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_exit.ForeColor = System.Drawing.Color.Yellow;
            this.btn_exit.Location = new System.Drawing.Point(999, 694);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(283, 32);
            this.btn_exit.TabIndex = 38;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(580, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 67);
            this.label4.TabIndex = 39;
            this.label4.Text = "NAGINA";
            // 
            // btn_abount
            // 
            this.btn_abount.BackColor = System.Drawing.Color.Red;
            this.btn_abount.FlatAppearance.BorderSize = 3;
            this.btn_abount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_abount.ForeColor = System.Drawing.Color.Yellow;
            this.btn_abount.Location = new System.Drawing.Point(146, 694);
            this.btn_abount.Name = "btn_abount";
            this.btn_abount.Size = new System.Drawing.Size(283, 32);
            this.btn_abount.TabIndex = 40;
            this.btn_abount.Text = "ABOUT";
            this.btn_abount.UseVisualStyleBackColor = false;
            this.btn_abount.Click += new System.EventHandler(this.btn_abount_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "employee"});
            this.comboBox1.Location = new System.Drawing.Point(565, 506);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_abount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnpassword);
            this.Controls.Add(this.btnusername);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnpassword;
        private System.Windows.Forms.TextBox btnusername;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_abount;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}