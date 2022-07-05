
namespace FlosProjects
{
    partial class DataUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUser));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDelete = new Guna.UI.WinForms.GunaButton();
            this.txtEdit = new Guna.UI.WinForms.GunaButton();
            this.txtSimpan = new Guna.UI.WinForms.GunaButton();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.GridColor = System.Drawing.Color.White;
            this.dgvUser.Location = new System.Drawing.Point(32, 317);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(661, 118);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(37, 171);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.guna2TextBox2.PlaceholderText = "ID User";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(282, 36);
            this.guna2TextBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.txtEdit);
            this.panel1.Controls.Add(this.txtSimpan);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPasswd);
            this.panel1.Controls.Add(this.txtNoHP);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.txtIdUser);
            this.panel1.Location = new System.Drawing.Point(32, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 153);
            this.panel1.TabIndex = 9;
            // 
            // txtDelete
            // 
            this.txtDelete.AnimationHoverSpeed = 0.07F;
            this.txtDelete.AnimationSpeed = 0.03F;
            this.txtDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtDelete.BorderColor = System.Drawing.Color.Black;
            this.txtDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtDelete.FocusedColor = System.Drawing.Color.Empty;
            this.txtDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.ForeColor = System.Drawing.Color.White;
            this.txtDelete.Image = ((System.Drawing.Image)(resources.GetObject("txtDelete.Image")));
            this.txtDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.txtDelete.Location = new System.Drawing.Point(514, 110);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.txtDelete.OnHoverImage = null;
            this.txtDelete.OnPressedColor = System.Drawing.Color.Black;
            this.txtDelete.Size = new System.Drawing.Size(111, 36);
            this.txtDelete.TabIndex = 25;
            this.txtDelete.Text = "DELETE";
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.AnimationHoverSpeed = 0.07F;
            this.txtEdit.AnimationSpeed = 0.03F;
            this.txtEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtEdit.BorderColor = System.Drawing.Color.Black;
            this.txtEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtEdit.FocusedColor = System.Drawing.Color.Empty;
            this.txtEdit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.ForeColor = System.Drawing.Color.White;
            this.txtEdit.Image = ((System.Drawing.Image)(resources.GetObject("txtEdit.Image")));
            this.txtEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.txtEdit.Location = new System.Drawing.Point(514, 68);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.txtEdit.OnHoverImage = null;
            this.txtEdit.OnPressedColor = System.Drawing.Color.Black;
            this.txtEdit.Size = new System.Drawing.Size(111, 36);
            this.txtEdit.TabIndex = 24;
            this.txtEdit.Text = "EDIT";
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // txtSimpan
            // 
            this.txtSimpan.AnimationHoverSpeed = 0.07F;
            this.txtSimpan.AnimationSpeed = 0.03F;
            this.txtSimpan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtSimpan.BorderColor = System.Drawing.Color.Black;
            this.txtSimpan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtSimpan.FocusedColor = System.Drawing.Color.Empty;
            this.txtSimpan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimpan.ForeColor = System.Drawing.Color.White;
            this.txtSimpan.Image = ((System.Drawing.Image)(resources.GetObject("txtSimpan.Image")));
            this.txtSimpan.ImageSize = new System.Drawing.Size(20, 20);
            this.txtSimpan.Location = new System.Drawing.Point(514, 26);
            this.txtSimpan.Name = "txtSimpan";
            this.txtSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtSimpan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtSimpan.OnHoverForeColor = System.Drawing.Color.White;
            this.txtSimpan.OnHoverImage = null;
            this.txtSimpan.OnPressedColor = System.Drawing.Color.Black;
            this.txtSimpan.Size = new System.Drawing.Size(111, 36);
            this.txtSimpan.TabIndex = 23;
            this.txtSimpan.Text = "SAVE";
            this.txtSimpan.Click += new System.EventHandler(this.txtSimpan_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "De Active"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(269, 151);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(217, 36);
            this.cbStatus.TabIndex = 22;
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FocusedColor = System.Drawing.Color.Empty;
            this.cbLevel.FocusedState.Parent = this.cbLevel;
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.HoverState.Parent = this.cbLevel;
            this.cbLevel.ItemHeight = 30;
            this.cbLevel.Items.AddRange(new object[] {
            "Administrator",
            "Team",
            "User"});
            this.cbLevel.ItemsAppearance.Parent = this.cbLevel;
            this.cbLevel.Location = new System.Drawing.Point(32, 151);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.ShadowDecoration.Parent = this.cbLevel;
            this.cbLevel.Size = new System.Drawing.Size(217, 36);
            this.cbLevel.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(32, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(217, 36);
            this.txtEmail.TabIndex = 19;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtPasswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswd.DefaultText = "";
            this.txtPasswd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswd.DisabledState.Parent = this.txtPasswd;
            this.txtPasswd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswd.FocusedState.Parent = this.txtPasswd;
            this.txtPasswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtPasswd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswd.HoverState.Parent = this.txtPasswd;
            this.txtPasswd.Location = new System.Drawing.Point(269, 109);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '\0';
            this.txtPasswd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtPasswd.PlaceholderText = "Password";
            this.txtPasswd.SelectedText = "";
            this.txtPasswd.ShadowDecoration.Parent = this.txtPasswd;
            this.txtPasswd.Size = new System.Drawing.Size(217, 36);
            this.txtPasswd.TabIndex = 16;
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // txtNoHP
            // 
            this.txtNoHP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNoHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoHP.DefaultText = "";
            this.txtNoHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoHP.DisabledState.Parent = this.txtNoHP;
            this.txtNoHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoHP.FocusedState.Parent = this.txtNoHP;
            this.txtNoHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNoHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoHP.HoverState.Parent = this.txtNoHP;
            this.txtNoHP.Location = new System.Drawing.Point(269, 67);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.PasswordChar = '\0';
            this.txtNoHP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtNoHP.PlaceholderText = "No HP";
            this.txtNoHP.SelectedText = "";
            this.txtNoHP.ShadowDecoration.Parent = this.txtNoHP;
            this.txtNoHP.Size = new System.Drawing.Size(217, 36);
            this.txtNoHP.TabIndex = 15;
            // 
            // txtNama
            // 
            this.txtNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(32, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(217, 36);
            this.txtNama.TabIndex = 13;
            // 
            // txtIdUser
            // 
            this.txtIdUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUser.DefaultText = "";
            this.txtIdUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.DisabledState.Parent = this.txtIdUser;
            this.txtIdUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.FocusedState.Parent = this.txtIdUser;
            this.txtIdUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.HoverState.Parent = this.txtIdUser;
            this.txtIdUser.Location = new System.Drawing.Point(32, 25);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.PasswordChar = '\0';
            this.txtIdUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtIdUser.PlaceholderText = "ID User";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.SelectedText = "";
            this.txtIdUser.ShadowDecoration.Parent = this.txtIdUser;
            this.txtIdUser.Size = new System.Drawing.Size(454, 36);
            this.txtIdUser.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(32, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM USER";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtSearch.Location = new System.Drawing.Point(33, 232);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(489, 30);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(30, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(548, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(111, 36);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 21);
            this.btnBack.TabIndex = 54;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataUser";
            this.Load += new System.EventHandler(this.DataUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton txtSimpan;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbLevel;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswd;
        private Guna.UI2.WinForms.Guna2TextBox txtNoHP;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton txtDelete;
        private Guna.UI.WinForms.GunaButton txtEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
    }
}