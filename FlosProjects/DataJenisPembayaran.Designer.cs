
namespace FlosProjects
{
    partial class DataJenisPembayaran
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
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.txtNamaAkun = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNoAkun = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdJenis = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvJenis = new System.Windows.Forms.DataGridView();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::FlosProjects.Properties.Resources.trash_can;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(515, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(111, 36);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.AnimationHoverSpeed = 0.07F;
            this.btnSimpan.AnimationSpeed = 0.03F;
            this.btnSimpan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnSimpan.BorderColor = System.Drawing.Color.Black;
            this.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSimpan.FocusedColor = System.Drawing.Color.Empty;
            this.btnSimpan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Image = global::FlosProjects.Properties.Resources.add__3_;
            this.btnSimpan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSimpan.Location = new System.Drawing.Point(515, 21);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.btnSimpan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSimpan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSimpan.OnHoverImage = null;
            this.btnSimpan.OnPressedColor = System.Drawing.Color.Black;
            this.btnSimpan.Size = new System.Drawing.Size(111, 36);
            this.btnSimpan.TabIndex = 23;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
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
            this.btnRefresh.Image = global::FlosProjects.Properties.Resources.refresh;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(548, 224);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(111, 36);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::FlosProjects.Properties.Resources.edit;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(515, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(111, 36);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNamaAkun
            // 
            this.txtNamaAkun.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNamaAkun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaAkun.DefaultText = "";
            this.txtNamaAkun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaAkun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaAkun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaAkun.DisabledState.Parent = this.txtNamaAkun;
            this.txtNamaAkun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaAkun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaAkun.FocusedState.Parent = this.txtNamaAkun;
            this.txtNamaAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNamaAkun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaAkun.HoverState.Parent = this.txtNamaAkun;
            this.txtNamaAkun.Location = new System.Drawing.Point(33, 104);
            this.txtNamaAkun.Name = "txtNamaAkun";
            this.txtNamaAkun.PasswordChar = '\0';
            this.txtNamaAkun.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtNamaAkun.PlaceholderText = "Nama Akun";
            this.txtNamaAkun.SelectedText = "";
            this.txtNamaAkun.ShadowDecoration.Parent = this.txtNamaAkun;
            this.txtNamaAkun.Size = new System.Drawing.Size(217, 36);
            this.txtNamaAkun.TabIndex = 19;
            // 
            // txtNoAkun
            // 
            this.txtNoAkun.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNoAkun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoAkun.DefaultText = "";
            this.txtNoAkun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoAkun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoAkun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoAkun.DisabledState.Parent = this.txtNoAkun;
            this.txtNoAkun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoAkun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoAkun.FocusedState.Parent = this.txtNoAkun;
            this.txtNoAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtNoAkun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoAkun.HoverState.Parent = this.txtNoAkun;
            this.txtNoAkun.Location = new System.Drawing.Point(270, 104);
            this.txtNoAkun.Name = "txtNoAkun";
            this.txtNoAkun.PasswordChar = '\0';
            this.txtNoAkun.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtNoAkun.PlaceholderText = "No Akun";
            this.txtNoAkun.SelectedText = "";
            this.txtNoAkun.ShadowDecoration.Parent = this.txtNoAkun;
            this.txtNoAkun.Size = new System.Drawing.Size(217, 36);
            this.txtNoAkun.TabIndex = 16;
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
            this.txtNama.Location = new System.Drawing.Point(33, 62);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtNama.PlaceholderText = "Jenis Pembayaran";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(455, 36);
            this.txtNama.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(30, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtSearch.Location = new System.Drawing.Point(33, 230);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(489, 30);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM JENIS PEMBAYARAN";
            // 
            // txtIdJenis
            // 
            this.txtIdJenis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdJenis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdJenis.DefaultText = "";
            this.txtIdJenis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdJenis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdJenis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJenis.DisabledState.Parent = this.txtIdJenis;
            this.txtIdJenis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJenis.FocusedState.Parent = this.txtIdJenis;
            this.txtIdJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdJenis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJenis.HoverState.Parent = this.txtIdJenis;
            this.txtIdJenis.Location = new System.Drawing.Point(33, 20);
            this.txtIdJenis.Name = "txtIdJenis";
            this.txtIdJenis.PasswordChar = '\0';
            this.txtIdJenis.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtIdJenis.PlaceholderText = "ID Jenis Pembayaran";
            this.txtIdJenis.ReadOnly = true;
            this.txtIdJenis.SelectedText = "";
            this.txtIdJenis.ShadowDecoration.Parent = this.txtIdJenis;
            this.txtIdJenis.Size = new System.Drawing.Size(454, 36);
            this.txtIdJenis.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA JENIS PEMBAYARAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(32, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.txtNamaAkun);
            this.panel1.Controls.Add(this.txtNoAkun);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.txtIdJenis);
            this.panel1.Location = new System.Drawing.Point(32, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 153);
            this.panel1.TabIndex = 31;
            // 
            // dgvJenis
            // 
            this.dgvJenis.BackgroundColor = System.Drawing.Color.White;
            this.dgvJenis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJenis.GridColor = System.Drawing.Color.White;
            this.dgvJenis.Location = new System.Drawing.Point(32, 315);
            this.dgvJenis.Name = "dgvJenis";
            this.dgvJenis.Size = new System.Drawing.Size(661, 118);
            this.dgvJenis.TabIndex = 29;
            this.dgvJenis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenis_CellClick);
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
            this.guna2TextBox2.Location = new System.Drawing.Point(37, 169);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.guna2TextBox2.PlaceholderText = "ID User";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(282, 36);
            this.guna2TextBox2.TabIndex = 30;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::FlosProjects.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 21);
            this.btnBack.TabIndex = 46;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataJenisPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvJenis);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataJenisPembayaran";
            this.Text = "DataJenisPembayaran";
            this.Load += new System.EventHandler(this.DataJenisPembayaran_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaAkun;
        private Guna.UI2.WinForms.Guna2TextBox txtNoAkun;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIdJenis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvJenis;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.PictureBox btnBack;
    }
}