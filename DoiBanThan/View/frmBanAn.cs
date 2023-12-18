using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiBanThan.View
{
    public partial class frmBanAn : Form
    {
        public frmBanAn()
        {
            InitializeComponent();
        }

        private void frmBanAn_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select * from tblBanAn where tenBan like '%"+ txtTimKiemBan.Text +"%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaBanAn);
            lb.Items.Add(dgvTenBanAn);

            MainClass.LoadData(qry, grvBanAn, lb);
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            frmThemBanAn frm = new frmThemBanAn();
            frm.ShowDialog();
            GetData();
        }

        private void txtTimKiemBan_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void grvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvBanAn.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmThemBanAn frm = new frmThemBanAn();
                frm.maBan = Convert.ToInt32(grvBanAn.CurrentRow.Cells["dgvMaBanAn"].Value);
                frm.txtTenBanAn.Text = Convert.ToString(grvBanAn.CurrentRow.Cells["dgvTenBanAn"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (grvBanAn.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maBan = Convert.ToString(grvBanAn.CurrentRow.Cells["dgvMaBanAn"].Value);
                    string qry = "delete from tblBanAn where maBanAn = "+ maBan +"";
                    Hashtable ht = new Hashtable();
                    MainClass.Sql(qry, ht);
                    MessageBox.Show("Xóa thành công!");
                    GetData();
                }

            }
        }
    }
}
