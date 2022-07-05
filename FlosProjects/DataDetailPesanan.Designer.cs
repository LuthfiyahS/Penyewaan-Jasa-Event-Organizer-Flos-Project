
namespace FlosProjects
{
    partial class DataDetailPesanan
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
            this.cbBarang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPesanan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtKuantitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.dgvDetailPesanan = new System.Windows.Forms.DataGridView();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPesanan)).BeginInit();
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
            this.label1.TabIndex = 44;
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
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FORM DETAIL PESANAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATA DETAIL PESANAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(33, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 35);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(33, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 35);
            this.panel3.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbBarang);
            this.panel1.Controls.Add(this.cbPesanan);
            this.panel1.Controls.Add(this.txtKuantitas);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Location = new System.Drawing.Point(33, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 153);
            this.panel1.TabIndex = 39;
            // 
            // cbBarang
            // 
            this.cbBarang.BackColor = System.Drawing.Color.Transparent;
            this.cbBarang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarang.FocusedColor = System.Drawing.Color.Empty;
            this.cbBarang.FocusedState.Parent = this.cbBarang;
            this.cbBarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.HoverState.Parent = this.cbBarang;
            this.cbBarang.ItemHeight = 30;
            this.cbBarang.Items.AddRange(new object[] {
            "BRG0001",
            "BRG0002",
            "BRG0003",
            "BRG0004",
            "BRG0005"});
            this.cbBarang.ItemsAppearance.Parent = this.cbBarang;
            this.cbBarang.Location = new System.Drawing.Point(269, 16);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.ShadowDecoration.Parent = this.cbBarang;
            this.cbBarang.Size = new System.Drawing.Size(217, 36);
            this.cbBarang.TabIndex = 29;
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
            this.cbPesanan.Location = new System.Drawing.Point(32, 16);
            this.cbPesanan.Name = "cbPesanan";
            this.cbPesanan.ShadowDecoration.Parent = this.cbPesanan;
            this.cbPesanan.Size = new System.Drawing.Size(217, 36);
            this.cbPesanan.TabIndex = 28;
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtKuantitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKuantitas.DefaultText = "";
            this.txtKuantitas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKuantitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKuantitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.DisabledState.Parent = this.txtKuantitas;
            this.txtKuantitas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.FocusedState.Parent = this.txtKuantitas;
            this.txtKuantitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(64)))), ((int)(((byte)(40)))));
            this.txtKuantitas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.HoverState.Parent = this.txtKuantitas;
            this.txtKuantitas.Location = new System.Drawing.Point(32, 57);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.PasswordChar = '\0';
            this.txtKuantitas.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(119)))));
            this.txtKuantitas.PlaceholderText = "Kuantitas";
            this.txtKuantitas.SelectedText = "";
            this.txtKuantitas.ShadowDecoration.Parent = this.txtKuantitas;
            this.txtKuantitas.Size = new System.Drawing.Size(454, 36);
            this.txtKuantitas.TabIndex = 26;
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
            // dgvDetailPesanan
            // 
            this.dgvDetailPesanan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPesanan.GridColor = System.Drawing.Color.White;
            this.dgvDetailPesanan.Location = new System.Drawing.Point(33, 318);
            this.dgvDetailPesanan.Name = "dgvDetailPesanan";
            this.dgvDetailPesanan.Size = new System.Drawing.Size(661, 118);
            this.dgvDetailPesanan.TabIndex = 37;
            this.dgvDetailPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailPesanan_CellClick);
            this.dgvDetailPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailPesanan_CellContentClick);
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
            this.guna2TextBox2.TabIndex = 38;
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
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::FlosProjects.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 21);
            this.btnBack.TabIndex = 45;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataDetailPesanan
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
            this.Controls.Add(this.dgvDetailPesanan);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataDetailPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataDetailPesanan";
            this.Load += new System.EventHandler(this.DataDetailPesanan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPesanan)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ComboBox cbBarang;
        private Guna.UI2.WinForms.Guna2ComboBox cbPesanan;
        private Guna.UI2.WinForms.Guna2TextBox txtKuantitas;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private System.Windows.Forms.DataGridView dgvDetailPesanan;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private System.Windows.Forms.PictureBox btnBack;
    }
}