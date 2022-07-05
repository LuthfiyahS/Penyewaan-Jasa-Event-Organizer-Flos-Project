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
    public partial class Login : Form
    {
        public static string user;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            user = txtUsername.Text;
            try
            {
                if (txtUsername.Text == "" || txtPasswd.Text == "")
                {
                    MessageBox.Show("Login Gagal");
                }
                else
                {
                    Koneksi.conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select nama,email, passwd, level_user,status from user where email = '" + txtUsername.Text + "' and passwd = '" + txtPasswd.Text + "'and status = 'Active'", Koneksi.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["level_user"].ToString() == "Administrator")
                            {
                                MessageBox.Show("Login Berhasil! Selamat Datang "+txtUsername.Text+" !");
                                Dashboard admin = new Dashboard();
                                admin.Show();
                                this.Hide();
                            }
                            else if (dr["level_user"].ToString() == "User")
                            {
                                MessageBox.Show("Login Success! Welcome User!");
                                Dashboard user = new Dashboard();
                                user.Show();
                                this.Hide();
                            }
                        }
                    }
                    Koneksi.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
