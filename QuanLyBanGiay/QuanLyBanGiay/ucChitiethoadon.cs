using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay
{
    public partial class ucChitiethoadon : UserControl
    {
        public ucChitiethoadon()
        {
            InitializeComponent();
        }

        private void cHITIETHOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHITIETHOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void dONGIALabel_Click(object sender, EventArgs e)
        {

        }

        private void dONGIATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHITIETHOADONBindingSource.AddNew();
                mAHHTextEdit.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mAHHTextEdit.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc xóa  không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                cHITIETHOADONBindingSource.RemoveCurrent();
                //nGUOIDUNGTableAdapter.Update(ds.NGUOIDUNG);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                cHITIETHOADONBindingSource.EndEdit();
                cHITIETHOADONTableAdapter.Update(ds.    CHITIETHOADON);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ucHoadon_Load(object sender, EventArgs e)
        {
            this.cHITIETHOADONTableAdapter.Fill(ds.CHITIETHOADON);
        }
    }
}
