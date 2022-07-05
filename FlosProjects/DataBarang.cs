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
    public partial class DataBarang : Form
    {
        private MySqlCommand cmd;
        public DataBarang()
        {
            InitializeComponent();
        }


        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM barang", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvBarang.DataSource = data;
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
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT  * FROM barang where  id_barang like '%" + txtIdBarang.Text + "%' or nama_barang like '%" + txtSearch.Text + "%' or merek like '%" + txtSearch.Text + "%'", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvBarang.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed \n Error" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select id_barang from barang where id_barang in(select max(id_barang) from barang) order by id_barang desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_barang"].ToString().Length - 4, 4)) + 1;
                string idurut = "0000" + itung;
                urut = "BRG" + idurut.Substring(idurut.Length - 4, 4);
            }
            else
            {
                urut = "BRG0001";
            }
            dr.Close();
            txtIdBarang.Text = urut;
            Koneksi.conn.Close();
        }

        void ClearData()
        {
            txtIdBarang.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            cbKategori.Text = null;
            txtDesc.Text = "";
        }
        private void DataBarang_Load(object sender, EventArgs e)
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
            ClearData();
            ShowData();
            IdOtomatis();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtHarga.Text.Trim() == "" ||
                txtStok.Text.Trim() == "" || cbKategori.Text.Trim() == "" || txtDesc.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Koneksi.conn.Open();
                    cmd = new MySqlCommand("insert into barang(id_barang,nama_barang,harga,stok,deskripsi,nama_kategori) values('" + txtIdBarang.Text + "', '" + txtNama.Text + "', '" + txtHarga.Text + "', '" + txtStok.Text + "', '" + txtDesc + "', '"  + cbKategori.Text + "')", Koneksi.conn); ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Koneksi.conn.Close();
                    ClearData();
                    ShowData();
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

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvBarang.Rows[e.RowIndex];
                txtIdBarang.Text = row.Cells["id_barang"].Value.ToString();
                txtNama.Text = row.Cells["nama_barang"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
                txtDesc.Text = row.Cells["deskripsi"].Value.ToString();
                cbKategori.Text = row.Cells["nama_kategori"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtStok.Text.Trim() == "" || txtDesc.Text.Trim() == "" || cbKategori.Text.Trim() == "" )
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update barang set nama_barang='" + txtNama.Text + "', harga='" + txtHarga.Text + "', stok='" + txtStok.Text + "', deskripsi='" + txtDesc.Text + "', nama_kategori='" + cbKategori.Text + "' where id_barang='" + txtIdBarang.Text + "'", Koneksi.conn);
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
                if (MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data " + txtNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from barang where id_barang='" + txtIdBarang.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + txtIdBarang.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
