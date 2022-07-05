
namespace FlosProjects
{
    partial class Login
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
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.txtUsername = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPasswd = new Guna.UI.WinForms.GunaLineTextBox();
            this.uname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::FlosProjects.Properties.Resources.login__1_;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(571, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 15;
            this.btnLogin.Size = new System.Drawing.Size(103, 37);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtUsername.Location = new System.Drawing.Point(404, 179);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(270, 28);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.White;
            this.txtPasswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswd.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.txtPasswd.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtPasswd.Location = new System.Drawing.Point(404, 235);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.SelectedText = "";
            this.txtPasswd.Size = new System.Drawing.Size(270, 28);
            this.txtPasswd.TabIndex = 4;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.BackColor = System.Drawing.Color.Transparent;
            this.uname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(401, 163);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(67, 17);
            this.uname.TabIndex = 5;
            this.uname.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::FlosProjects.Properties.Resources.close_button;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaButton1.Location = new System.Drawing.Point(711, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(39, 37);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlosProjects.Properties.Resources.Login_Flos_Project;
            this.ClientSize = new System.Drawing.Size(749, 402);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaLineTextBox txtUsername;
        private Guna.UI.WinForms.GunaLineTextBox txtPasswd;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}

