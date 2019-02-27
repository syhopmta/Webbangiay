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
    public partial class ucHanghoa : UserControl
    {
        public ucHanghoa()
        {
            InitializeComponent();
        }

        private void hANGHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hANGHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                this.hANGHOABindingSource.AddNew();
                mAHHTextEdit.Focus();
                hANGHOATableAdapter.Update(ds.HANGHOA);
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
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc xóa người dùng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hANGHOABindingSource.RemoveCurrent();
                //nGUOIDUNGTableAdapter.Update(ds.NGUOIDUNG);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                hANGHOABindingSource.EndEdit();
                hANGHOATableAdapter.Update(ds.HANGHOA);
                MessageBox.Show("Lưu thành công ", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ucHanghoa_Load(object sender, EventArgs e)
        {
            this.hANGHOATableAdapter.Fill(ds.HANGHOA);

        }
    }
}
