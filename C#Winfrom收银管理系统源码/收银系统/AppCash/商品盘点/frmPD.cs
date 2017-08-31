using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dong.BLL;
namespace AppCash
{
    public partial class frmPD : Form
    {
        public DataTable dt = null;
        GoodsInfo goodbll = new GoodsInfo();
        public frmPD()
        {
            InitializeComponent();
        }

        private void frmPD_Load(object sender, EventArgs e)
        {
            dGV.AutoGenerateColumns = false;
            dt = new DataTable();
            //lblCode.Text = "B" + DateTime.Now.ToString("yyyyMMddHHmmss");
            //lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //txtOper.Text = Dong.Model.GlobalsInfo.UserName;
            dt.Columns.Add(new DataColumn("Id"));
            dt.Columns.Add(new DataColumn("GoodCode"));
            dt.Columns.Add(new DataColumn("GoodName"));
            dt.Columns.Add(new DataColumn("CB"));
            dt.Columns.Add(new DataColumn("KC"));
            dt.Columns.Add(new DataColumn("XC"));
            dt.Columns.Add(new DataColumn("KSJE"));
        }

        /// <summary>
        /// 进货单保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 商品信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX3_Click(object sender, EventArgs e)
        {
            //商品编号
            string code = txtCode.Text;
            //商品名称
            string name = txtName.Text;
            //商品成本价
            string cb = txtCB.Text.Trim();
            //商品库存
            string kc = txtKC.Text.Trim();
            //商品现存数量
            string sl = txtSL.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                MessageBoxEx.Show("商品编号不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sl))
            {
                MessageBoxEx.Show("数量不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }



            int count;
            if (!int.TryParse(sl, out count))
            {
                MessageBoxEx.Show("数量必须为整数!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return;
            }

            DataRow[] drs = dt.Select("GoodCode='" + code + "'");
            if (drs.Length > 0)
            {
                MessageBoxEx.Show("商品已经存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DataRow dr = dt.NewRow();
            dr[0] = Guid.NewGuid().ToString();
            dr[1] = code;
            dr[2] = name;
            dr[3] = cb;
            dr[4] = kc;
            dr[5] = sl;
            if (sl == "0")
            {
                dr[6] = 0;
            }
            else
            {
                dr[6] = (Int32.Parse(kc) - count) * (double.Parse(cb));
            }
            dt.Rows.Add(dr);
            BindGrid();
            //计算总亏损
            double zksje = 0;
            foreach (DataRow item in dt.Rows)
            {
                zksje += double.Parse(item["KSJE"].ToString());
            }
            lblZKSJE.Text = zksje.ToString();
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
        private void buttonX2_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            Dong.Model.GoodsInfo model = goodbll.GetModel(code);
            if (model == null)
            {
                buttonX2_Click(null, null);
            }
            else
            {
                txtCode.Text = model.Code;
                txtName.Text = model.GoodsName;

                txtFactory.Text = model.Factory;
                txtCategory.Text = model.CategoryName;
                txtUnit.Text = model.UnitName;
                txtSuppier.Text = model.SupplierName;
                txtKC.Text = model.Counts == null ? "" : model.Counts.ToString();
                txtSJ.Text = model.Price0 == null ? "" : model.Price0.ToString();
                txtJJ.Text = model.Price1 == null ? "" : model.Price1.ToString();
                txtCB.Text = model.Price2 == null ? "" : model.Price2.ToString();
            }
        }
    }
}
