using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCash
{
    public partial class frmMoney : Form
    {
        public frmMoney()
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
                    Cash();
                    return true;
                case Keys.D:

                    return true;
                case Keys.F1:
                    Form frmToday = new frmToday();
                    frmToday.ShowDialog();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void frmMoney_Load(object sender, EventArgs e)
        {
            this.Show();
            this.TopMost = true;
            tbYS.Text = string.Format("{0:F2}", double.Parse(this.Tag.ToString()));
            tbSSJE.Focus();
        }

        private void tbSSJE_TextChanged(object sender, EventArgs e)
        {
            tbZL.Text = "";
        }

        protected void Cash()
        {
            if (tbZL.Text.Trim() == "")
            {
                tbZL.Text = string.Format("{0:F2}", (double.Parse(tbSSJE.Text.Trim()) - double.Parse(tbYS.Text.Trim())));
            }
            else
            {
                Dong.BLL.GoodsInfo bGoods = new Dong.BLL.GoodsInfo();
                Dong.BLL.SaleInfo bSale = new Dong.BLL.SaleInfo();
                Dong.Model.SaleInfo mSale = new Dong.Model.SaleInfo();

                frmCash frmP = (frmCash)this.Owner;
                DataGridView dgv = (DataGridView)frmP.Controls.Find("dGV", true)[0];
                for (int i = 0; i < dgv.Rows.Count; i++)
                {

                    //添加销售记录
                    double price = double.Parse(dgv.Rows[i].Cells[4].Value.ToString());
                    mSale.Pid = Dong.Model.GlobalsInfo.bill;
                    mSale.GoodsCode = dgv.Rows[i].Cells[0].Value.ToString();
                    mSale.Counts = int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    mSale.Price = price;
                    mSale.PriceSum = double.Parse(tbYS.Text);
                    mSale.VipCode = Dong.Model.GlobalsInfo.vipCode;
                    mSale.Oper = Dong.Model.GlobalsInfo.UserName;
                    mSale.IDate = DateTime.Now;
                    bSale.Add(mSale);

                    //减少货物质量
                    bGoods.UpdateCount(int.Parse(dgv.Rows[i].Cells[3].Value.ToString()), dgv.Rows[i].Cells[0].Value.ToString());
                }

                frmP.ClearForm();
                frmP.showPre();
                this.Close();
            }
        }
    }
}
