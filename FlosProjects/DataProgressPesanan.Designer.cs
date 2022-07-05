
namespace FlosProjects
{
    partial class DataProgressPesanan
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
            this.txtLokasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTgl = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtIDProgress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbKegiatan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPesanan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHasil = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.dgvProgressPesanan = new System.Windows.Forms.DataGridView();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgressPesanan)).BeginInit();
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
            this.label1.TabIndex = 52;
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
            this.txtSearch.TabIndex = 50;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM PROGRES PESANAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA PROGRES PESANAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(33, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(33, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLokasi);
            this.panel1.Controls.Add(this.txtTgl);
            this.panel1.Controls.Add(this.txtIDProgress);
            this.panel1.Controls.Add(this.cbKegiatan);
            this.panel1.Controls.Add(this.cbPesanan);
            this.panel1.Controls.Add(this.txtHasil);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Location = new System.Drawing.Point(33, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 153);
            this.panel1.TabIndex = 47;
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
            this.txtLokasi.Location = new System.Drawing.Point(32, 99);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.PasswordChar = '\0';
            this.txtLokasi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtLokasi.PlaceholderText = "Lokasi";
            this.txtLokasi.SelectedText = "";
            this.txtLokasi.ShadowDecoration.Parent = this.txtLokasi;
            this.txtLokasi.Size = new System.Drawing.Size(454, 36);
            this.txtLokasi.TabIndex = 39;
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
            this.txtTgl.Location = new System.Drawing.Point(32, 57);
            this.txtTgl.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTgl.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtTgl.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTgl.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTgl.OnPressedColor = System.Drawing.Color.Black;
            this.txtTgl.Size = new System.Drawing.Size(217, 36);
            this.txtTgl.TabIndex = 38;
            this.txtTgl.Text = "15/11/2021";
            this.txtTgl.Value = new System.DateTime(2021, 11, 15, 20, 48, 34, 138);
            // 
            // txtIDProgress
            // 
            this.txtIDProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIDProgress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProgress.DefaultText = "";
            this.txtIDProgress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProgress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProgress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProgress.DisabledState.Parent = this.txtIDProgress;
            this.txtIDProgress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProgress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProgress.FocusedState.Parent = this.txtIDProgress;
            this.txtIDProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtIDProgress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProgress.HoverState.Parent = this.txtIDProgress;
            this.txtIDProgress.Location = new System.Drawing.Point(32, 16);
            this.txtIDProgress.Name = "txtIDProgress";
            this.txtIDProgress.PasswordChar = '\0';
            this.txtIDProgress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtIDProgress.PlaceholderText = "ID Progress";
            this.txtIDProgress.SelectedText = "";
            this.txtIDProgress.ShadowDecoration.Parent = this.txtIDProgress;
            this.txtIDProgress.Size = new System.Drawing.Size(217, 36);
            this.txtIDProgress.TabIndex = 31;
            // 
            // cbKegiatan
            // 
            this.cbKegiatan.BackColor = System.Drawing.Color.Transparent;
            this.cbKegiatan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbKegiatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKegiatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKegiatan.FocusedColor = System.Drawing.Color.Empty;
            this.cbKegiatan.FocusedState.Parent = this.cbKegiatan;
            this.cbKegiatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKegiatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbKegiatan.FormattingEnabled = true;
            this.cbKegiatan.HoverState.Parent = this.cbKegiatan;
            this.cbKegiatan.ItemHeight = 30;
            this.cbKegiatan.Items.AddRange(new object[] {
            "Meeting",
            "Call",
            "Submit Document",
            "Other"});
            this.cbKegiatan.ItemsAppearance.Parent = this.cbKegiatan;
            this.cbKegiatan.Location = new System.Drawing.Point(269, 58);
            this.cbKegiatan.Name = "cbKegiatan";
            this.cbKegiatan.ShadowDecoration.Parent = this.cbKegiatan;
            this.cbKegiatan.Size = new System.Drawing.Size(217, 36);
            this.cbKegiatan.TabIndex = 30;
            // 
            // cbPesanan
            // 
            this.cbPesanan.BackColor = System.Drawing.Color.Transparent;
            this.cbPesanan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbPesanan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPesanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesanan.FocusedColor = System.Drawing.Color.Empty;
            this.cbPesanan.FocusedState.Parent = this.cbPesanan;
            this.cbPesanan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbPesanan.FormattingEnabled = true;
            this.cbPesanan.HoverState.Parent = this.cbPesanan;
            this.cbPesanan.ItemHeight = 30;
            this.cbPesanan.Items.AddRange(new object[] {
            "BOOK0001",
            "BOOK0002"});
            this.cbPesanan.ItemsAppearance.Parent = this.cbPesanan;
            this.cbPesanan.Location = new System.Drawing.Point(269, 16);
            this.cbPesanan.Name = "cbPesanan";
            this.cbPesanan.ShadowDecoration.Parent = this.cbPesanan;
            this.cbPesanan.Size = new System.Drawing.Size(217, 36);
            this.cbPesanan.TabIndex = 29;
            // 
            // txtHasil
            // 
            this.txtHasil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtHasil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHasil.DefaultText = "";
            this.txtHasil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHasil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHasil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHasil.DisabledState.Parent = this.txtHasil;
            this.txtHasil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHasil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHasil.FocusedState.Parent = this.txtHasil;
            this.txtHasil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtHasil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHasil.HoverState.Parent = this.txtHasil;
            this.txtHasil.Location = new System.Drawing.Point(32, 141);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.PasswordChar = '\0';
            this.txtHasil.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtHasil.PlaceholderText = "Hasil";
            this.txtHasil.SelectedText = "";
            this.txtHasil.ShadowDecoration.Parent = this.txtHasil;
            this.txtHasil.Size = new System.Drawing.Size(454, 71);
            this.txtHasil.TabIndex = 26;
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
            this.btnDelete.Location = new System.Drawing.Point(514, 99);
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
            this.btnEdit.Location = new System.Drawing.Point(514, 57);
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
            this.btnSimpan.Location = new System.Drawing.Point(514, 15);
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
            // dgvProgressPesanan
            // 
            this.dgvProgressPesanan.BackgroundColor = System.Drawing.Color.White;
            this.dgvProgressPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProgressPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgressPesanan.GridColor = System.Drawing.Color.White;
            this.dgvProgressPesanan.Location = new System.Drawing.Point(33, 318);
            this.dgvProgressPesanan.Name = "dgvProgressPesanan";
            this.dgvProgressPesanan.Size = new System.Drawing.Size(661, 118);
            this.dgvProgressPesanan.TabIndex = 45;
            this.dgvProgressPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgressPesanan_CellClick);
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
            this.guna2TextBox2.TabIndex = 46;
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
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::FlosProjects.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 21);
            this.btnBack.TabIndex = 53;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataProgressPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProgressPesanan);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataProgressPesanan";
            this.Text = "DataProgressPesanan";
            this.Load += new System.EventHandler(this.DataProgressPesanan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgressPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProgress;
        private Guna.UI2.WinForms.Guna2ComboBox cbKegiatan;
        private Guna.UI2.WinForms.Guna2ComboBox cbPesanan;
        private Guna.UI2.WinForms.Guna2TextBox txtHasil;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private System.Windows.Forms.DataGridView dgvProgressPesanan;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaDateTimePicker txtTgl;
        private Guna.UI2.WinForms.Guna2TextBox txtLokasi;
        private System.Windows.Forms.PictureBox btnBack;
    }
}