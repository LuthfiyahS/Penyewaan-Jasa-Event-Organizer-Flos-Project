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
    public partial class DataUser : Form
    {

        private MySqlCommand cmd;
        public DataUser()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                ("SELECT id_user,nama,email,telepon,level_user,status FROM user", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvUser.DataSource = data;
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
                    ("SELECT  id_user,nama,email,telepon,level_user,status FROM user where  nama like '%" + txtSearch.Text + "%' or telepon like '%" + txtSearch.Text + "%'", Koneksi.conn);

                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvUser.DataSource = data;
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
            txtIdUser.Text = "";
            txtNama.Text = "";
            txtNoHP.Text = "";
            txtEmail.Text = "";
            txtPasswd.Text = "";
            cbLevel.Text = null;
            cbStatus.Text = null;
        }
        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select id_user from user where id_user in(select max(id_user) from user) order by id_user desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_user"].ToString().Length - 4, 4)) + 1;
                string idurut = "0000" + itung;
                urut = "USR" + idurut.Substring(idurut.Length - 4, 4);
            }
            else
            {
                urut = "USR0001";
            }
            dr.Close();
            txtIdUser.Text = urut;
            Koneksi.conn.Close();
        }

        private void DataUser_Load(object sender, EventArgs e)
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

        private void txtSimpan_Click(object sender, EventArgs e)
        {
            
            if (txtIdUser.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtNoHP.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPasswd.Text.Trim() == "" || cbLevel.Text.Trim() == "" || cbStatus.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into user(id_user,nama,email,telepon,passwd,level_user,status) values('" + txtIdUser.Text + "', '" + txtNama.Text + "', '" + txtEmail.Text + "', '" + txtNoHP.Text + "', '" + txtPasswd.Text + "', '" + cbLevel.Text + "', '" + cbStatus.Text + "')", Koneksi.conn);
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

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
                txtIdUser.Text = row.Cells["id_user"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtNoHP.Text = row.Cells["telepon"].Value.ToString();
                cbLevel.Text = row.Cells["level_user"].Value.ToString();
                cbStatus.Text = row.Cells["status"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtNoHP.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPasswd.Text.Trim() == "" || cbLevel.Text.Trim() == "" || cbStatus.Text.Trim() == "")
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update user set nama='"+ txtNama.Text + "', email='" + txtEmail.Text + "', telepon='" + txtNoHP.Text + "', passwd='" + txtPasswd.Text + "', level_user='" + cbLevel.Text + "', status='" + cbStatus.Text + "' where id_user='" + txtIdUser.Text + "'", Koneksi.conn);
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

        private void txtDelete_Click(object sender, EventArgs e)
        {
                try
                {
                if (MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data " + txtNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from user where id_user='" + txtIdUser.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + txtIdUser.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }
    }
}
