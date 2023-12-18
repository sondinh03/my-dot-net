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

namespace DoiBanThan
{
    public partial class frmThemBanAn : Form
    {
        public frmThemBanAn()
        {
            InitializeComponent();
        }

        public int maBan = 0;

        private void btnHuyBanAn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuBanAn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (maBan == 0) //Insert
            {
                qry = "insert into tblBanAn values(@tenBan)";
            }
            else
            {
                qry = "update tblBanAn set tenBan = @tenBan where maBanAn = @maBan";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@maBan", maBan);
            ht.Add("@tenBan", txtTenBanAn.Text.Trim());

            if (MainClass.Sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm Bàn ăn thành công.");
                maBan = 0;
                txtTenBanAn.Focus();
                txtTenBanAn.Text = "";
                this.Close();
            }
        }
    }
}
