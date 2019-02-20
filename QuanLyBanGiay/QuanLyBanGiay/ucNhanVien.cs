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
    public partial class ucNhanvien : UserControl
    {
        public ucNhanvien()
        {
            InitializeComponent();
        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

       
       

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGUOIDUNGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mANVTextEdit.Focus();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.nGUOIDUNGBindingSource.AddNew();
                mANVTextEdit.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ucNhanvien_Load(object sender, EventArgs e)
        {
            this.nGUOIDUNGTableAdapter.Fill(ds.NGUOIDUNG);

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                nGUOIDUNGBindingSource.EndEdit();
                nGUOIDUNGTableAdapter.Update(ds.NGUOIDUNG);
                MessageBox.Show("Lưu thành công người dùng mới", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Bạn có chắc xóa người dùng này không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                nGUOIDUNGBindingSource.RemoveCurrent();
                //nGUOIDUNGTableAdapter.Update(ds.NGUOIDUNG);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nGUOIDUNGBindingSource.CancelEdit();
        }
    }
}