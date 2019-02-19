using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhanVien uc = new ucNhanVien(); // khởi tạo user control
            panelControl1.Controls.Clear(); // xóa bỏ những gì nắm trền panelcontrol
            panelControl1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill; // thiết lập thuộc tính Dock cho ucNhanvien
        }
    }
}
