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
    public partial class DataProgressPesanan : Form
    {
        private MySqlCommand cmd;
        public DataProgressPesanan()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                ("SELECT * FROM progress_pesanan", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvProgressPesanan.DataSource = data;
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
                    ("SELECT  * FROM progress_pesanan where  id_pesanan like '%" + txtSearch.Text + "%' or tgl_kegiatan like '%" + txtSearch.Text + "%'", Koneksi.conn);

                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvProgressPesanan.DataSource = data;
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
            txtIDProgress.Text = "";
            cbPesanan.Text = null;
            txtTgl.Text = "";
            cbKegiatan.Text = null;
            txtLokasi.Text = "";
            txtHasil.Text = "";
        }
        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;

            cmd = new MySqlCommand("select id_progress from progress_pesanan where id_progress in(select max(id_progress) from progress_pesanan) order by id_progress desc", Koneksi.conn);
                        Koneksi.conn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_progress"].ToString().Length - 4, 4)) + 1;
                string idurut = "0000" + itung;
                urut = "SHP" + idurut.Substring(idurut.Length - 4, 4);
            }
            else
            {
                urut = "SHP0001";
            }
            dr.Close();
            txtIDProgress.Text = urut;
            Koneksi.conn.Close();

        }

        private void DataProgressPesanan_Load(object sender, EventArgs e)
        {
            ShowData();
            ClearData();
            IdOtomatis();
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
            ShowData();
            ClearData();
            IdOtomatis();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(txtTgl.Text);
            string tanggal = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            if (txtIDProgress.Text.Trim() == "" || cbPesanan.Text.Trim() == "" || txtTgl.Text.Trim() == "" ||
                cbKegiatan.Text.Trim() == "" || txtLokasi.Text.Trim() == "" || txtHasil.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into progress_pesanan(id_progress,tgl_kegiatan,jenis_kegiatan,hasil,lokasi,id_pesanan) values('" + txtIDProgress.Text + "', '" + tanggal + "', '" + cbKegiatan.Text + "', '" + txtHasil.Text + "', '" + txtLokasi.Text + "', '" + cbPesanan.Text + "')", Koneksi.conn); ;
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

        private void dgvProgressPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvProgressPesanan.Rows[e.RowIndex];
                txtIDProgress.Text = row.Cells["id_pesanan"].Value.ToString();
                txtTgl.Text = row.Cells["tgl_kegiatan"].Value.ToString();
                cbKegiatan.Text = row.Cells["jenis_kegiatan"].Value.ToString();
                txtHasil.Text = row.Cells["hasil"].Value.ToString();
                txtLokasi.Text = row.Cells["lokasi"].Value.ToString();
                cbPesanan.Text = row.Cells["id_pesanan"].Value.ToString();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(txtTgl.Text);
            string tanggal = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            if (txtIDProgress.Text.Trim() == "" || txtTgl.Text.Trim() == "" || cbKegiatan.Text.Trim() == "" || txtHasil.Text.Trim() == ""  || txtLokasi.Text.Trim() == "" || cbPesanan.Text.Trim() == "" )
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Koneksi.conn.Open();
                    cmd = new MySqlCommand("update progress_pesanan set tgl_kegiatan='" + tanggal + "', jenis_kegiatan='" + cbKegiatan.Text + "', hasil='" + txtHasil.Text + "', lokasi='" + txtLokasi.Text + "', id_pesanan='" + cbPesanan.Text + "' where id_progress='" + txtIDProgress.Text + "'", Koneksi.conn);
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
                if (MessageBox.Show("Apakah Anda Yakin Unruk Menghapus Proggres Booking Data : " + cbKegiatan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from progress_kegiatan where id_pesanan='" + txtIDProgress.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + txtIDProgress.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
