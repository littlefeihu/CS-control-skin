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
    public partial class frmEditSup : Form
    {
        public frmEditSup()
        {
            InitializeComponent();
        }
        private void frmEditSup_Load(object sender, EventArgs e)
        {

            Dong.BLL.Supplier bll = new Dong.BLL.Supplier();
            Dong.Model.Supplier model = new Dong.Model.Supplier();
            model = bll.GetModel(int.Parse(this.Tag.ToString()));
            if (model != null)
            {
                txtName.Text = model.Name;
                txtAdd.Text = model.Addr;
                txtContact.Text = model.Contact;
                txtPhone.Text = model.Phone;
                txtCode.Text = model.Code;
                txtaccount.Text = model.Account;
                
                txtbank.Text = model.Bank;


            }
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
            model.Id = int.Parse(this.Tag.ToString());
            model.Name = txtName.Text;
            model.Addr = txtAdd.Text;
            model.Contact = txtContact.Text;
            model.Phone = txtPhone.Text;
            model.Code = txtCode.Text;
            model.Account = txtaccount.Text;
            model.Bank = txtbank.Text;
            model.Oper = Dong.Model.GlobalsInfo.UserName;

            model.OperDate = DateTime.Now;


            if (bll.Update(model))
            {
                MessageBoxEx.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSup fvip = (frmSup)this.Owner;
                fvip.refreshData();
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("修改失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
