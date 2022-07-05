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
    public partial class DataEvent : Form
    {
        private MySqlCommand cmd;
        public DataEvent()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter
                ("SELECT * FROM jenis_event", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvEvent.DataSource = data;
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
                    ("SELECT * FROM jenis_event where  id_event like '%" + txtSearch.Text + "%' or nama_event like '%" + txtSearch.Text + "%'", Koneksi.conn);

                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dgvEvent.DataSource = data;
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
            txtIdEvent.Text = "";
            txtEvent.Text = "";
        }


        void IdOtomatis()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select id_event from jenis_event where id_event in(select max(id_event) from jenis_event) order by id_event desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_event"].ToString().Length - 3, 3)) + 1;
                string idurut = "000" + itung;
                urut = "EVN" + idurut.Substring(idurut.Length - 3, 3);
            }
            else
            {
                urut = "EVN001";
            }
            dr.Close();
            txtIdEvent.Text = urut;
            Koneksi.conn.Close();
        }
        private void DataEvent_Load(object sender, EventArgs e)
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
            if (txtIdEvent.Text.Trim() == "" || txtEvent.Text.Trim() == "" )
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into jenis_event(id_event,nama_event) values('" + txtIdEvent.Text + "', '" + txtEvent.Text + "')", Koneksi.conn);
                    Koneksi.conn.Open();
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

        private void dgvEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvEvent.Rows[e.RowIndex];
                txtIdEvent.Text = row.Cells["id_event"].Value.ToString();
                txtEvent.Text = row.Cells["nama_event"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdEvent.Text.Trim() == "" || txtEvent.Text.Trim() == "" )
            {
                MessageBox.Show("Data Tidak Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("update jenis_event set nama_event='" + txtEvent.Text + "' where id_event='" + txtIdEvent.Text + "'", Koneksi.conn);
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
                if (MessageBox.Show("Apakah Anda Yakin Untuk Menghapus Jenis Event : " + txtEvent.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("delete from jenis_event where id_event='" + txtIdEvent.Text + "'", Koneksi.conn);
                    Koneksi.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data " + txtEvent.Text + " Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
