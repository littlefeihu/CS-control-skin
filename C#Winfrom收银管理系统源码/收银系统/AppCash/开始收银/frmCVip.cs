using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCash
{
    public partial class frmCVip : Form
    { 
        public frmCVip()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.Enter:
                    if (tbVipCode.Text.Trim()!="")
                    {
                        Dong.BLL.MemberInfo bMember = new Dong.BLL.MemberInfo();
                        Dong.Model.MemberInfo mMember = new Dong.Model.MemberInfo();
                        mMember = bMember.GetModel(tbVipCode.Text);
                        if (mMember == null)
                        {
                            MessageBox.Show("对不起，无此会员!");
                        }
                        else
                        {
                            tbVipName.Text = mMember.Name;
                            Dong.Model.GlobalsInfo.vipZK = mMember.Discount;
                            Dong.Model.GlobalsInfo.vipCode = tbVipCode.Text;
                            frmCash frmP = (frmCash)this.Owner;
                            frmP.sumCash();
                        }
                    }
                    return true;
                
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void frmVip_Load(object sender, EventArgs e)
        {
            this.Show();
            this.TopMost = true;
        }

    }
}
