using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Xml.Linq;
using System.IO;

namespace AppCash
{
    public partial class frmLogin : Office2007Form
    {
        const string userprofilefile = "userprofile.xml";
        public frmLogin()
        {
            InitializeComponent();
            this.EnableGlass = false;
            ReadUserProfile();
        }
        private void SaveUserProfile(string username, string password)
        {
            if (!chkRememberPassword.Checked)
            {
                username = string.Empty;
                password = string.Empty;
            }
            XDocument xdoc = new XDocument(
                                        new XDeclaration("1.0", "utf-8", "yes"),
                                        new XElement("root",
                                        new XElement("username", username),
                                        new XElement("password", password)
                                        ));
            xdoc.Save(userprofilefile);

        }
        private void ReadUserProfile()
        {
            if (File.Exists(userprofilefile))
            {
                XElement xele = XElement.Load(userprofilefile);
                XElement usernameEle = xele.Element("username");
                XElement pwdEle = xele.Element("password");
                txtusername.Text = usernameEle.Value;
                tbPwd.Text = pwdEle.Value;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录
            if (tbPwd.Text == "" || txtusername.Text == "")
            {
                MessageBoxEx.Show("请输入账号密码!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtusername.Text;
            string password = tbPwd.Text;


            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            if (bOper.CheckUser(username, password))
            {
                SaveUserProfile(username, password);

                Dong.Model.GlobalsInfo.UserName = txtusername.Text;

                frmMain frm = new frmMain();

                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBoxEx.Show("您输入的账号密码不正确!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //初始化界面信息
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
