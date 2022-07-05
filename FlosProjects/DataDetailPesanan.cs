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
    public partial class DataDetailPesanan : Form
    {
        private MySqlCommand cmd;
        public DataDetailPesanan()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM detail_pesanan", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvDetailPesanan.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal \n Error" + ex.Message,
               "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Search()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT  * FROM detail_pesanan where  id_barang like '%" + cbBarang.Text + "%' or id_pesanan like '%" + cbPesanan.Text + "%'", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvDetailPesanan.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed \n Error" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ClearData()
        {
            cbBarang.Text = null;
            cbPesanan.Text = null;
            txtKuantitas.Text = "";
        }

        private void DataDetailPesanan_Load(object sender, EventArgs e)
        {
            ClearData();
            ShowData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ShowData();
        }

        private void dgvDetailPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvDetailPesanan.Rows[e.RowIndex];
                cbBarang.Text = row.Cells["id_barang"].Value.ToString();
                cbPesanan.Text = row.Cells["id_pesanan"].Value.ToString();
                txtKuantitas.Text = row.Cells["kuantitas"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbPesanan.Text.Trim() == "" || cbBarang.Text.Trim() == "" || txtKuantitas.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into detail_pesanan(id_pesanan,id_barang,kuantitas) values('" + cbPesanan.Text + "', '" + cbBarang.Text + "', '" + txtKuantitas.Text + "')", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ClearData();
                    ShowData();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
        }

        private void dgvDetailPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvDetailPesanan.Rows[e.RowIndex];
                cbPesanan.Text = row.Cells["id_pesanan"].Value.ToString();
                cbBarang.Text = row.Cells["id_barang"].Value.ToString();
                txtKuantitas.Text = row.Cells["kuantitas"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Pesanan Nomor : " + cbPesanan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from detail_pesanan where id_event='" + cbPesanan.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + cbPesanan.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ShowData();
                    ClearData();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbPesanan.Text.Trim() == "" || cbBarang.Text.Trim() == "" || txtKuantitas.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update detail_pesanan set kuantitas='" + txtKuantitas.Text + "' where id_event='" + cbPesanan.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ShowData();
                    ClearData();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
        }
    }
}

