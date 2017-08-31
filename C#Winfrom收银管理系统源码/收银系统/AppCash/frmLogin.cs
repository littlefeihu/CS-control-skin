using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
namespace AppCash
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录
            if (tbPwd.Text == "" || cbUserid.Text == "")
            {
                MessageBoxEx.Show("请输入登录口令!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            if (bOper.CheckUser(cbUserid.Text, tbPwd.Text))
            {
                Dong.Model.GlobalsInfo.UserName = cbUserid.Text;
                frmMain frm = new frmMain();

                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBoxEx.Show("您输入的口令不正确!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            //初始化界面信息
            //提取用户列表
            DataSet ds = new DataSet();
            Dong.BLL.OperInfo mOper = new Dong.BLL.OperInfo();
            ds = mOper.GetAllList();
            cbUserid.ValueMember = "Code";
            cbUserid.DisplayMember = "Code";
            cbUserid.DataSource = ds.Tables[0];

            //提取配置信息
            Dong.BLL.ShopInfo bShop = new Dong.BLL.ShopInfo();
            Dong.Model.ShopInfo mShop = new Dong.Model.ShopInfo();
            mShop = bShop.GetModel(1);
            Dong.Model.GlobalsInfo.shopName = mShop.Name;
            this.Text = this.Text + " --【" + mShop.Name + "】";

            Dong.Model.GlobalsInfo.shopAddr = mShop.Addr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    return true;
                case Keys.Enter:
                    btnLogin_Click(null, null);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
