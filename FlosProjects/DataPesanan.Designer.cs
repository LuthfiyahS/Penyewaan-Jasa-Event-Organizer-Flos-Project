
namespace FlosProjects
{
    partial class DataPesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTgl = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPembayaran = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtKota = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLokasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbEvent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPemilikHajat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.txtIdPesanan = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(31, 220);
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
            this.txtSearch.Location = new System.Drawing.Point(34, 233);
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
            this.label2.Location = new System.Drawing.Point(259, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM PESANAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(261, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA PESANAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(33, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(33, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTgl);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbPembayaran);
            this.panel1.Controls.Add(this.txtKota);
            this.panel1.Controls.Add(this.txtLokasi);
            this.panel1.Controls.Add(this.cbEvent);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.txtPemilikHajat);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.txtIdPesanan);
            this.panel1.Location = new System.Drawing.Point(33, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 153);
            this.panel1.TabIndex = 31;
            // 
            // txtTgl
            // 
            this.txtTgl.BaseColor = System.Drawing.Color.White;
            this.txtTgl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtTgl.BorderSize = 1;
            this.txtTgl.CustomFormat = null;
            this.txtTgl.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtTgl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtTgl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgl.ForeColor = System.Drawing.Color.Black;
            this.txtTgl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTgl.Location = new System.Drawing.Point(269, 100);
            this.txtTgl.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTgl.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtTgl.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTgl.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTgl.OnPressedColor = System.Drawing.Color.Black;
            this.txtTgl.Size = new System.Drawing.Size(217, 36);
            this.txtTgl.TabIndex = 37;
            this.txtTgl.Text = "15/11/2021";
            this.txtTgl.Value = new System.DateTime(2021, 11, 15, 20, 48, 34, 138);
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
            "UnPaid",
            "Down Payment(DP) 10%",
            "Down Payment(DP) 25%",
            "Down Payment(DP) 50%",
            "Paid"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(269, 184);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(217, 36);
            this.cbStatus.TabIndex = 36;
            // 
            // cbPembayaran
            // 
            this.cbPembayaran.BackColor = System.Drawing.Color.Transparent;
            this.cbPembayaran.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbPembayaran.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPembayaran.FocusedColor = System.Drawing.Color.Empty;
            this.cbPembayaran.FocusedState.Parent = this.cbPembayaran;
            this.cbPembayaran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbPembayaran.FormattingEnabled = true;
            this.cbPembayaran.HoverState.Parent = this.cbPembayaran;
            this.cbPembayaran.ItemHeight = 30;
            this.cbPembayaran.Items.AddRange(new object[] {
            "PAY0001",
            "PAY0002",
            "PAY0003",
            "PAY0004",
            "PAY0005"});
            this.cbPembayaran.ItemsAppearance.Parent = this.cbPembayaran;
            this.cbPembayaran.Location = new System.Drawing.Point(32, 184);
            this.cbPembayaran.Name = "cbPembayaran";
            this.cbPembayaran.ShadowDecoration.Parent = this.cbPembayaran;
            this.cbPembayaran.Size = new System.Drawing.Size(217, 36);
            this.cbPembayaran.TabIndex = 35;
            // 
            // txtKota
            // 
            this.txtKota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtKota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKota.DefaultText = "";
            this.txtKota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKota.DisabledState.Parent = this.txtKota;
            this.txtKota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKota.FocusedState.Parent = this.txtKota;
            this.txtKota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtKota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKota.HoverState.Parent = this.txtKota;
            this.txtKota.Location = new System.Drawing.Point(269, 142);
            this.txtKota.Name = "txtKota";
            this.txtKota.PasswordChar = '\0';
            this.txtKota.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtKota.PlaceholderText = "Kota";
            this.txtKota.SelectedText = "";
            this.txtKota.ShadowDecoration.Parent = this.txtKota;
            this.txtKota.Size = new System.Drawing.Size(217, 36);
            this.txtKota.TabIndex = 31;
            // 
            // txtLokasi
            // 
            this.txtLokasi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtLokasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLokasi.DefaultText = "";
            this.txtLokasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLokasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLokasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasi.DisabledState.Parent = this.txtLokasi;
            this.txtLokasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasi.FocusedState.Parent = this.txtLokasi;
            this.txtLokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtLokasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasi.HoverState.Parent = this.txtLokasi;
            this.txtLokasi.Location = new System.Drawing.Point(32, 142);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.PasswordChar = '\0';
            this.txtLokasi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtLokasi.PlaceholderText = "Lokasi Acara";
            this.txtLokasi.SelectedText = "";
            this.txtLokasi.ShadowDecoration.Parent = this.txtLokasi;
            this.txtLokasi.Size = new System.Drawing.Size(217, 36);
            this.txtLokasi.TabIndex = 30;
            // 
            // cbEvent
            // 
            this.cbEvent.BackColor = System.Drawing.Color.Transparent;
            this.cbEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvent.FocusedColor = System.Drawing.Color.Empty;
            this.cbEvent.FocusedState.Parent = this.cbEvent;
            this.cbEvent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.HoverState.Parent = this.cbEvent;
            this.cbEvent.ItemHeight = 30;
            this.cbEvent.Items.AddRange(new object[] {
            "Wedding",
            "Engagement",
            "Birthday Party"});
            this.cbEvent.ItemsAppearance.Parent = this.cbEvent;
            this.cbEvent.Location = new System.Drawing.Point(269, 59);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.ShadowDecoration.Parent = this.cbEvent;
            this.cbEvent.Size = new System.Drawing.Size(217, 36);
            this.cbEvent.TabIndex = 29;
            // 
            // cbUser
            // 
            this.cbUser.BackColor = System.Drawing.Color.Transparent;
            this.cbUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FocusedColor = System.Drawing.Color.Empty;
            this.cbUser.FocusedState.Parent = this.cbUser;
            this.cbUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbUser.FormattingEnabled = true;
            this.cbUser.HoverState.Parent = this.cbUser;
            this.cbUser.ItemHeight = 30;
            this.cbUser.Items.AddRange(new object[] {
            "USR0001",
            "USR0002",
            "USR0003",
            "USR0004",
            "USR0005",
            "USR0006"});
            this.cbUser.ItemsAppearance.Parent = this.cbUser;
            this.cbUser.Location = new System.Drawing.Point(32, 59);
            this.cbUser.Name = "cbUser";
            this.cbUser.ShadowDecoration.Parent = this.cbUser;
            this.cbUser.Size = new System.Drawing.Size(217, 36);
            this.cbUser.TabIndex = 28;
            // 
            // txtPemilikHajat
            // 
            this.txtPemilikHajat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtPemilikHajat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPemilikHajat.DefaultText = "";
            this.txtPemilikHajat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPemilikHajat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPemilikHajat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPemilikHajat.DisabledState.Parent = this.txtPemilikHajat;
            this.txtPemilikHajat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPemilikHajat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPemilikHajat.FocusedState.Parent = this.txtPemilikHajat;
            this.txtPemilikHajat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtPemilikHajat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPemilikHajat.HoverState.Parent = this.txtPemilikHajat;
            this.txtPemilikHajat.Location = new System.Drawing.Point(32, 100);
            this.txtPemilikHajat.Name = "txtPemilikHajat";
            this.txtPemilikHajat.PasswordChar = '\0';
            this.txtPemilikHajat.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtPemilikHajat.PlaceholderText = "Pemilik Hajat";
            this.txtPemilikHajat.SelectedText = "";
            this.txtPemilikHajat.ShadowDecoration.Parent = this.txtPemilikHajat;
            this.txtPemilikHajat.Size = new System.Drawing.Size(217, 36);
            this.txtPemilikHajat.TabIndex = 26;
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
            this.btnDelete.Location = new System.Drawing.Point(514, 101);
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
            this.btnEdit.Location = new System.Drawing.Point(514, 59);
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
            this.btnSimpan.Location = new System.Drawing.Point(514, 17);
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
            // txtIdPesanan
            // 
            this.txtIdPesanan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdPesanan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPesanan.DefaultText = "";
            this.txtIdPesanan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPesanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPesanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPesanan.DisabledState.Parent = this.txtIdPesanan;
            this.txtIdPesanan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPesanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPesanan.FocusedState.Parent = this.txtIdPesanan;
            this.txtIdPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIdPesanan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPesanan.HoverState.Parent = this.txtIdPesanan;
            this.txtIdPesanan.Location = new System.Drawing.Point(32, 17);
            this.txtIdPesanan.Name = "txtIdPesanan";
            this.txtIdPesanan.PasswordChar = '\0';
            this.txtIdPesanan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtIdPesanan.PlaceholderText = "ID Pesanan";
            this.txtIdPesanan.ReadOnly = true;
            this.txtIdPesanan.SelectedText = "";
            this.txtIdPesanan.ShadowDecoration.Parent = this.txtIdPesanan;
            this.txtIdPesanan.Size = new System.Drawing.Size(454, 36);
            this.txtIdPesanan.TabIndex = 12;
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.GridColor = System.Drawing.Color.White;
            this.dgvPesanan.Location = new System.Drawing.Point(33, 318);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.Size = new System.Drawing.Size(661, 118);
            this.dgvPesanan.TabIndex = 29;
            this.dgvPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellClick);
            this.dgvPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellContentClick);
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
            this.guna2TextBox2.Location = new System.Drawing.Point(38, 172);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.guna2TextBox2.PlaceholderText = "ID User";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(282, 36);
            this.guna2TextBox2.TabIndex = 30;
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
            this.btnRefresh.Location = new System.Drawing.Point(549, 227);
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
            // btnBack
            // 
            this.btnBack.Image = global::FlosProjects.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 21);
            this.btnBack.TabIndex = 48;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataPesanan
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
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPesanan";
            this.Load += new System.EventHandler(this.DataPesanan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbEvent;
        private Guna.UI2.WinForms.Guna2ComboBox cbUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPemilikHajat;
        private Guna.UI2.WinForms.Guna2TextBox txtKota;
        private Guna.UI2.WinForms.Guna2TextBox txtLokasi;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPesanan;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbPembayaran;
        private Guna.UI.WinForms.GunaDateTimePicker txtTgl;
        private System.Windows.Forms.PictureBox btnBack;
    }
}