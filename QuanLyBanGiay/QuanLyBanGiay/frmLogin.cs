using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyBanGiay
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyBanGiay.Properties.Settings.QLBANGIAYConnectionString"].ToString());


        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("exec useLogin '" + txtUser.Text + "', '" + txtPass.Text + "'", cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

                int count = (int)cmd.ExecuteScalar();

                cnn.Close();

                if (count == 1)
                {
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database!");
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
