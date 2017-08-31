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
    public partial class frmAddSup : Form
    {
        public frmAddSup()
        {
            InitializeComponent();
        }
        private void frmAddSup_Load(object sender, EventArgs e)
        {

            

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //验证商家名称
            if (txtName.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入商家名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (txtAdd.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入地址!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd.Focus();
                return;
            }

            if (txtContact.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入联系人!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return;
            }

            if (txtPhone.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入电话!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (txtCode.Text.Trim() == "")
            {
                txtCode.Text = "无";
            }

            if (txtaccount.Text.Trim() == "")
            {
                txtaccount.Text = "无";
            }

            if (txtbank.Text.Trim() == "")
            {
                txtbank.Text = "无";
            }

           



            Dong.BLL.Supplier bll = new Dong.BLL.Supplier();
            Dong.Model.Supplier model = new Dong.Model.Supplier();
            model.Name = txtName.Text;
            model.Addr = txtAdd.Text;
            model.Contact = txtContact.Text;
            model.Phone = txtPhone.Text;
            model.Code = txtCode.Text;
            model.Account = txtaccount.Text;
            model.Bank = txtbank.Text;
            model.Oper = Dong.Model.GlobalsInfo.UserName;

            model.OperDate = DateTime.Now;


            if (bll.Add(model))
            {
                MessageBoxEx.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSup fvip = (frmSup)this.Owner;
                fvip.refreshData();
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
