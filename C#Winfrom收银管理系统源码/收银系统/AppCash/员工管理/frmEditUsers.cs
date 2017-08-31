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
    public partial class frmEditUsers : Form
    {
        public frmEditUsers()
        {
            InitializeComponent();
        }

        #region ------退出------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {
            //验证
            
            
            if (tbName.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入员工姓名!","提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbName.Focus();
                return;
            }

            if(tbPwd.Text.Trim()=="")
            {
                MessageBoxEx.Show("请输入登录密码!","提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbPwd.Focus();
                return;
            }
            


            Dong.Model.OperInfo mOper = new Dong.Model.OperInfo();
            mOper.Code = tbCode.Text.Trim();
            mOper.Name = tbName.Text.Trim();
            mOper.Pwd = tbPwd.Text.Trim();
            mOper.Sex = cbSex.Text;
            
            if (tbPhone.Text != "")
            {
                mOper.Phone = tbPhone.Text.Trim();
            }
            else
            {
                mOper.Phone = "无";
            }
            if (tbCID.Text != "")
            {
                mOper.CId = tbCID.Text.Trim();
            }
            else
            {
                mOper.CId = "无";
            }
            mOper.Role = 0;
            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            if (bOper.Update(mOper))
            {
                MessageBoxEx.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUsers fUser = (frmUsers)this.Owner;
                fUser.refreshData();
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddVip_Load(object sender, EventArgs e)
        {
            cbSex.Items.Add("男");
            cbSex.Items.Add("女");
            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            Dong.Model.OperInfo mOper = new Dong.Model.OperInfo();
            mOper = bOper.GetModel(this.Tag.ToString());
            tbCode.Text = mOper.Code;
            tbName.Text = mOper.Name;
            tbPhone.Text = mOper.Phone;
            tbPwd.Text = mOper.Pwd;
            tbCID.Text = mOper.CId;
            cbSex.Text = mOper.Sex;

            cbRoles.Items.Add(new ComboBoxItem("0", "管理员"));
            cbRoles.Items.Add(new ComboBoxItem("1", "收银员"));
            cbRoles.SelectedIndex = (int)mOper.Role;
        }
    }
}
