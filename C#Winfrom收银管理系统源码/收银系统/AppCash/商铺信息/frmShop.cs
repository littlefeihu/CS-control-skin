using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCash
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            Dong.BLL.ShopInfo bShop = new Dong.BLL.ShopInfo();
            Dong.Model.ShopInfo mShop = new Dong.Model.ShopInfo();
            mShop = bShop.GetModel(1);
            tbShopName.Text = mShop.Name;
            tbPhone.Text = mShop.Phone;
            tbAddr.Text = mShop.Addr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dong.BLL.ShopInfo bShop = new Dong.BLL.ShopInfo();
            Dong.Model.ShopInfo mShop = new Dong.Model.ShopInfo();
            mShop.Id = 1;
            mShop.Name = tbShopName.Text;
            mShop.Addr = tbAddr.Text;
            mShop.Phone = tbPhone.Text;
            if (bShop.Update(mShop))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("修改成功!");
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("操作失败!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
