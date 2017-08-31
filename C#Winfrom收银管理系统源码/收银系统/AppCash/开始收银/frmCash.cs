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
    public partial class frmCash : Form
    {
        public frmCash()
        {
            InitializeComponent();
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetBounds(this);
            int width1 = ScreenArea.Width;
            int height1 = ScreenArea.Height;
            this.Width = width1;
            this.Height = height1;
            this.Top = 0;
            this.Left = 0;
            this.TopMost = true;

            dGV.Columns.Add("Code", "编号");
            dGV.Columns.Add("Name", "名称");
            dGV.Columns.Add("Price", "单价");
            dGV.Columns.Add("Counts", "数量");
            dGV.Columns.Add("Sum", "总价");



            //当前编号
            lblBill.Text = "B" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Dong.Model.GlobalsInfo.bill = lblBill.Text;

            showPre();

            lblUser.Text = Dong.Model.GlobalsInfo.UserName;
            lblTime.Text = DateTime.Now.ToString();
            tbCode.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (MessageBox.Show("确认退出收银界面?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    return true;
                case Keys.P:
                    Cash();
                    return true;
                case Keys.Enter:

                    addGoods();
                    return true;
                case Keys.D:
                    delGoods();
                    return true;
                case Keys.V:
                    frmCVip fVip = new frmCVip();
                    fVip.Owner = this;
                    fVip.ShowDialog();
                    return true;
                case Keys.End:
                    frmCounts fCounts = new frmCounts();
                    fCounts.Owner = this;
                    fCounts.ShowDialog();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        protected void addGoods()
        {
            Dong.BLL.GoodsInfo bGoods = new Dong.BLL.GoodsInfo();
            Dong.Model.GoodsInfo mGoods = new Dong.Model.GoodsInfo();
            mGoods = bGoods.GetModel(tbCode.Text.Trim());
            if (mGoods != null)
            {
                if (mGoods.Counts > 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV);

                    row.Cells[0].Value = mGoods.Code;
                    row.Cells[1].Value = mGoods.GoodsName;
                    row.Cells[2].Value = string.Format("{0:F2}", mGoods.Price0);
                    row.Cells[3].Value = "1";
                    row.Cells[4].Value = string.Format("{0:F2}", (mGoods.Price0 * int.Parse(row.Cells[3].Value.ToString())));
                    dGV.Rows.Add(row);
                    row.Selected = true;
                    tbCode.Text = "";

                    //计算总钱数
                    sumCash();
                    lblGoodsName.Text = mGoods.GoodsName;
                    lblStock.Text = mGoods.Counts.ToString();

                }
                else
                {
                    MessageBox.Show("对不起,此商品缺货!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("对不起,没有此商品!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void Cash()
        {
            frmMoney frmCash = new frmMoney();
            frmCash.Owner = this;
            frmCash.Tag = lblSF.Text;
            frmCash.ShowDialog();
        }

        public void ClearForm()
        {
            lblBill.Text = "B" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Dong.Model.GlobalsInfo.bill = lblBill.Text;
            lblCash.Text = "00.00";
            lblSF.Text = "00.00";
            dGV.Rows.Clear();
            tbCode.Text = "";
            lblGoodsName.Text = "";
            lblStock.Text = "";
        }

        public void showPre()
        {
            Dong.BLL.SaleInfo bSaleInfo = new Dong.BLL.SaleInfo();
            Dong.Model.SaleInfo mSaleInfo = new Dong.Model.SaleInfo();
            mSaleInfo = bSaleInfo.GetPreModel(Dong.Model.GlobalsInfo.UserName);
            lblPreBillNo.Text = mSaleInfo.Pid;
            lblPreBillCash.Text = string.Format("{0:F2}", mSaleInfo.Price.ToString());
            lblPreTime.Text = mSaleInfo.IDate.ToString();
        }

        public void sumCash()
        {
            double cash = 0;
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                double price = double.Parse(dGV.Rows[i].Cells[4].Value.ToString());
                cash = cash + price;
            }
            lblCash.Text = string.Format("{0:F2}", cash);
            //Dong.Model.GlobalsInfo.vipZK =0.99;
            lblSF.Text = string.Format("{0:F2}", cash * Dong.Model.GlobalsInfo.vipZK);
            lblVip.Text = Dong.Model.GlobalsInfo.vipCode;
        }

        protected void delGoods()
        {
            if (dGV.SelectedRows.Count > 0)
            {
                dGV.Rows.Remove(dGV.SelectedRows[0]);
                //计算总钱数
                sumCash();
            }
        }

        public void editCounts(int counts)
        {
            if (dGV.SelectedRows.Count > 0)
            {
                double price = double.Parse(dGV.SelectedRows[0].Cells[2].Value.ToString());
                dGV.SelectedRows[0].Cells[3].Value = counts.ToString();
                dGV.SelectedRows[0].Cells[4].Value = string.Format("{0:F2}", (price * int.Parse(dGV.SelectedRows[0].Cells[3].Value.ToString())));
                sumCash();
            }
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
