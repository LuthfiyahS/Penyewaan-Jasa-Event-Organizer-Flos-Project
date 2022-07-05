using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FlosProjects
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            submenu1();
            submenu2();
        }
        private void submenu1()
        {
            panelMaster.Visible = false;
        }
        private void hide()
        {
            if (panelMaster.Visible == true)
                panelMaster.Visible = false;
        }

        private void show(Panel sub)
        {
            if (sub.Visible == false)
            {
                hide();
                sub.Visible = true;
            }
            else
                sub.Visible = false;
        }

        private Form activeForm = null;
        private void tampilan(Form tampil)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = tampil;
            tampil.TopLevel = false;
            tampil.FormBorderStyle = FormBorderStyle.None;
            tampil.Dock = DockStyle.Fill;
            panelHsl.Controls.Add(tampil);
            panelHsl.Tag = tampil;
            tampil.BringToFront();
            tampil.Show();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            show(panelMaster);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            tampilan(new DataEvent());
        }

        private void submenu2()
        {
            panelTransaksi.Visible = false;
        }
        private void hide2()
        {
            if (panelTransaksi.Visible == true)
                panelTransaksi.Visible = false;
        }

        private void show2(Panel sub)
        {
            if (sub.Visible == false)
            {
                hide2();
                sub.Visible = true;
            }
            else
                sub.Visible = false;
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            show(panelTransaksi);
        }

        private void hidesub()
        {
            if (panelMaster.Visible == true)
                panelMaster.Visible = false;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            tampilan(new DataUser());
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            tampilan(new DataBarang());
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            tampilan(new DataKategori());
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            tampilan(new DataPesanan());
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            tampilan(new DataDetailPesanan());
        }

        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            tampilan(new DataProgressPesanan());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            tampilan(new DataJenisPembayaran());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.user;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void panelMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHsl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
