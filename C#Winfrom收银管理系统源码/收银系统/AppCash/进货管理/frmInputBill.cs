using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCash
{
    public partial class frmInputBill : Form
    {
        public DataTable dt = null;
        public frmInputBill()
        {
            InitializeComponent();
        }

        private void frmInputBill_Load(object sender, EventArgs e)
        {
            dGV.AutoGenerateColumns = false;
            dt = new DataTable();
            lblCode.Text = "B" + DateTime.Now.ToString("yyyyMMddHHmmss");
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtOper.Text = Dong.Model.GlobalsInfo.UserName;
            dt.Columns.Add(new DataColumn("Id"));
            dt.Columns.Add(new DataColumn("GoodCode"));
            dt.Columns.Add(new DataColumn("GoodName"));
            dt.Columns.Add(new DataColumn("JJ"));
            dt.Columns.Add(new DataColumn("SL"));
            dt.Columns.Add(new DataColumn("JE"));
        }

        /// <summary>
        /// 进货单保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Dong.BLL.InGoods bInGoods = new Dong.BLL.InGoods();
            Dong.Model.InGoods mInGoods = new Dong.Model.InGoods();
            Dong.BLL.GoodsInfo bGoodsInfo = new Dong.BLL.GoodsInfo();
            Dong.Model.GoodsInfo mGoodsInfo = new Dong.Model.GoodsInfo();
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                //添加进货信息
                mGoodsInfo = bGoodsInfo.GetModel(dGV.Rows[i].Cells[1].Value.ToString());
                mInGoods.PCode = lblCode.Text;
                mInGoods.GoodsCode = dGV.Rows[i].Cells[1].Value.ToString();
                mInGoods.Price = double.Parse(dGV.Rows[i].Cells[3].Value.ToString());
                mInGoods.Counts = int.Parse(dGV.Rows[i].Cells[4].Value.ToString());
                mInGoods.IDate = DateTime.Now.Date;
                mInGoods.Oper = txtOper.Text;
                mInGoods.Supplier = mGoodsInfo.Supplier;
                mInGoods.Remark = "";
                bInGoods.Add(mInGoods);

                //修改商品信息
                //进货价格
                double oldPrice1 = (double)mGoodsInfo.Price1;
                mGoodsInfo.Price1 = double.Parse(dGV.Rows[i].Cells[3].Value.ToString());
                
                //数量
                mGoodsInfo.Counts = mGoodsInfo.Counts + int.Parse(dGV.Rows[i].Cells[4].Value.ToString());

                //成本价
                int totalCount = (int)mGoodsInfo.Counts + int.Parse(dGV.Rows[i].Cells[4].Value.ToString());
                double totalPrice = (oldPrice1 * (int)mGoodsInfo.Counts) + (double.Parse(dGV.Rows[i].Cells[3].Value.ToString()) * int.Parse(dGV.Rows[i].Cells[4].Value.ToString()));
                double cbPrice = totalPrice / totalCount;
                mGoodsInfo.Price2 = cbPrice;
                bGoodsInfo.Update(mGoodsInfo);

            }

            frmInput frm = (frmInput)this.Owner;
            frm.refreshData();
            this.Close();
        }

        /// <summary>
        /// 商品信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //商品编号
            string code = txtCode.Text;
            //商品名称
            string name = txtName.Text;
            //商品进价
            string jj = txtJJ.Text.Trim();
            //商品数量

            string sl = txtSL.Text.Trim();


            if (string.IsNullOrEmpty(jj))
            {
                MessageBoxEx.Show("商品进价不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJJ.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sl))
            {
                MessageBoxEx.Show("数量不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }

            double price;
            if (!double.TryParse(jj, out price))
            {
                MessageBoxEx.Show("商品进价必须为数字!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJJ.Focus();
                return;
            }

            int count;
            if (!int.TryParse(sl, out count))
            {
                MessageBoxEx.Show("数量必须为整数!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }

            DataRow dr = dt.NewRow();
            dr[0] = Guid.NewGuid().ToString();
            dr[1] = code;
            dr[2] = name;
            dr[3] = price;
            dr[4] = count;
            dr[5] = price * count;
            dt.Rows.Add(dr);
            BindGrid();

            //计算总体数量和价格
            double cash = 0;
            int counts = 0;
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                double sumPrice = double.Parse(dGV.Rows[i].Cells[5].Value.ToString());
                int c = int.Parse(dGV.Rows[i].Cells[4].Value.ToString());
                cash = cash + sumPrice;
                counts = counts + c; 
            }
            lblCount.Text = counts.ToString();
            lblJG.Text = string.Format("{0:F2}", cash);


            //清空数据
            btnClear_Click(null, null);
        }

        private void BindGrid()
        {
            dGV.DataSource = dt;
            
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
            txtCategory.Text = "";
            txtSuppier.Text = "";
            txtFactory.Text = "";
            txtJJ.Text = "";
            txtKC.Text = "";
            txtSJ.Text = "";
            txtCB.Text = "";
            txtSL.Text = "";
        }

        /// <summary>
        /// 单元格点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:

                    this.Close();
                    return true;
                case Keys.Enter:
                    btnSearch_Click(null, null);
                    return true;
               
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入商品编码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dong.BLL.GoodsInfo bGoods = new Dong.BLL.GoodsInfo();
            Dong.Model.GoodsInfo mGoods = new Dong.Model.GoodsInfo();
            mGoods = bGoods.GetModel(txtCode.Text.Trim());
            if (mGoods != null)
            {
                txtCategory.Text = mGoods.CategoryName;
                txtFactory.Text = mGoods.Factory;
                txtName.Text = mGoods.GoodsName;
                txtKC.Text = mGoods.Counts.ToString();
                txtSJ.Text = mGoods.Price0.ToString();
                txtJJ.Text = mGoods.Price1.ToString();
                txtCB.Text = mGoods.Price2.ToString();
                txtSuppier.Text = mGoods.SupplierName;
                txtUnit.Text = mGoods.UnitName;
            }
            else
            {
                MessageBoxEx.Show("对不起,该商品不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dGV.SelectedRows.Count > 0)
            {
                dGV.Rows.Remove(dGV.SelectedRows[0]);
                //计算总钱数
                //计算总体数量和价格
                double cash = 0;
                int counts = 0;
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    double sumPrice = double.Parse(dGV.Rows[i].Cells[5].Value.ToString());
                    int c = int.Parse(dGV.Rows[i].Cells[3].Value.ToString());
                    cash = cash + sumPrice;
                    counts = counts + c;
                }
                lblCount.Text = counts.ToString();
                lblJG.Text = string.Format("{0:F2}", cash);
            }
        }
    }
}
