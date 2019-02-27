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
            // TODO: This line of code loads data into the 'ds.HANGHOA' table. You can move, or remove it, as needed.


            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhanvien uc = new ucNhanvien(); // khởi tạo user control
            panelControl1.Controls.Clear(); // xóa bỏ những gì nắm trền panelcontrol
            panelControl1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill; // thiết lập thuộc tính Dock cho ucNhanvien
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucChitiethoadon uc = new ucChitiethoadon();
            panelControl1.Controls.Clear(); // xóa bỏ những gì nắm trền panelcontrol
            panelControl1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;   
        }

        private void hANGHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hANGHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

      
       
       

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hANGHOABindingSource.CancelEdit();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhacungcap uc = new ucNhacungcap(); // khởi tạo user control
            panelControl1.Controls.Clear(); // xóa bỏ những gì nắm trền panelcontrol
            panelControl1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill; // thiết lập thuộc tính Dock cho ucNhanvien
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            
        }

        private void hANGHOADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucHanghoa uc = new ucHanghoa(); // khởi tạo user control
            panelControl1.Controls.Clear(); // xóa bỏ những gì nắm trền panelcontrol
            panelControl1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill; // thiết lập thuộc tính Dock cho ucNhanvien
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
