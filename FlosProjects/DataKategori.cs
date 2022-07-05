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
    public partial class DataKategori : Form
    {
        private MySqlCommand cmd;
        public DataKategori()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                ("SELECT * FROM kategori", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvKategori.DataSource = data;
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
                    ("SELECT * FROM kategori where  id_kategori like '%" + txtSearch.Text + "%' or nama_kategori like '%" + txtSearch.Text + "%'", Koneksi.conn);

                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvKategori.DataSource = data;
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
            txtIdKategori.Text = "";
            txtNama.Text = "";
        }

        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select id_kategori from kategori where id_kategori in(select max(id_kategori) from kategori) order by id_kategori desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_kategori"].ToString().Length - 3, 3)) + 1;
                string idurut = "000" + itung;
                urut = "CTL" + idurut.Substring(idurut.Length - 3, 3);
            }
            else
            {
                urut = "CTL001";
            }
            dr.Close();
            txtIdKategori.Text = urut;
            Koneksi.conn.Close();
        }
        private void DataKategori_Load(object sender, EventArgs e)
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
            if (txtIdKategori.Text.Trim() == "" || txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into kategori(id_kategori,nama_kategori) values('" + txtIdKategori.Text + "', '" + txtNama.Text + "')", Koneksi.conn);
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

        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvKategori.Rows[e.RowIndex];
                txtIdKategori.Text = row.Cells["id_kategori"].Value.ToString();
                txtNama.Text = row.Cells["nama_kategori"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdKategori.Text.Trim() == "" || txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update kategori set nama_kategori='" + txtNama.Text + "' where id_kategori='" + txtIdKategori.Text + "'", Koneksi.conn);
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
                    cmd = new MySqlCommand("delete from kategori where id_kategori='" + txtIdKategori.Text + "'", Koneksi.conn);
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
