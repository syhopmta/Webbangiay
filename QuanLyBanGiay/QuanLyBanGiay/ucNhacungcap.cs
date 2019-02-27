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
    public partial class ucNhacungcap : UserControl
    {
        public ucNhacungcap()
        {
            InitializeComponent();
        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void dIENTHOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void dIENTHOAITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                this.nHACUNGCAPBindingSource.AddNew();
                mANCCTextEdit.Focus();
                nHACUNGCAPTableAdapter.Update(ds.NHACUNGCAP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mANCCTextEdit.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc xóa người dùng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                nHACUNGCAPBindingSource.RemoveCurrent();
                //nGUOIDUNGTableAdapter.Update(ds.NGUOIDUNG);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                nHACUNGCAPBindingSource.EndEdit();
                nHACUNGCAPTableAdapter.Update(ds.NHACUNGCAP);
                MessageBox.Show("Lưu thành công ", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            nHACUNGCAPBindingSource.CancelEdit();
        }
        private void ucNhacungcap_Load(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(ds.NHACUNGCAP);

        }

        private void ucNhacungcap_Load_1(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(ds.NHACUNGCAP);
        }
    }
}

