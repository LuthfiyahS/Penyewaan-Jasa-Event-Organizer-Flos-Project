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
    public partial class DataJenisPembayaran : Form
    {
        private MySqlCommand cmd;
        public DataJenisPembayaran()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                ("SELECT id_pembayaran,nama_pembayaran,nama_akun,no_akun FROM jenis_pembayaran", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvJenis.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed \n Error" + ex.Message,
               "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Search()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                    ("SELECT id_pembayaran,nama_pembayaran,nama_akun,no_akun FROM jenis_pembayaran where  id_pembayaran like '%" + txtSearch.Text + "%' or nama_pembayaran like '%" + txtSearch.Text + "%' or nama_akun like '%" + txtSearch.Text + "%'", Koneksi.conn);

                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvJenis.DataSource = data;
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
            txtIdJenis.Text = "";
            txtNama.Text = "";
            txtNamaAkun.Text = "";
            txtNoAkun.Text = "";
        }


        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select id_pembayaran from jenis_pembayaran where id_pembayaran in(select max(id_pembayaran) from jenis_pembayaran) order by id_pembayaran desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_pembayaran"].ToString().Length - 4, 4)) + 1;
                string idurut = "0000" + itung;
                urut = "PAY" + idurut.Substring(idurut.Length - 4, 4);
            }
            else
            {
                urut = "PAY0001";
            }
            dr.Close();
            txtIdJenis.Text = urut;
            Koneksi.conn.Close();
        }
        private void DataJenisPembayaran_Load(object sender, EventArgs e)
        {
            ShowData();
            ClearData();
            IdOtomatis();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
            ClearData();
            IdOtomatis();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdJenis.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtNamaAkun.Text.Trim() == "" || txtNoAkun.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into jenis_pembayaran(id_pembayaran,nama_pembayaran,nama_akun,no_akun) values('" + txtIdJenis.Text + "', '" + txtNama.Text + "'" + txtNamaAkun.Text + "', '" + txtNoAkun.Text + "')", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ShowData();
                    ClearData();
                    IdOtomatis();
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

        private void dgvJenis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvJenis.Rows[e.RowIndex];
                txtIdJenis.Text = row.Cells["id_pembayaran"].Value.ToString();
                txtNama.Text = row.Cells["nama_pembayaran"].Value.ToString();
                txtNamaAkun.Text = row.Cells["nama_akun"].Value.ToString();
                txtNoAkun.Text = row.Cells["no_Akun"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdJenis.Text.Trim() == "" || txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update jenis_pembayaran set nama_pembayaran='" + txtIdJenis.Text + "' where id_pembayaran='" + txtIdJenis.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ShowData();
                    ClearData();
                    IdOtomatis();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Jenis Event : " + txtNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from jenis_pembayaran where id_pembayaran='" + txtIdJenis.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + txtNama.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ShowData();
                    ClearData();
                    IdOtomatis();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
