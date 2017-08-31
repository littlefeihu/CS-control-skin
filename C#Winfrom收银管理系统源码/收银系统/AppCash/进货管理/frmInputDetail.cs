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
    public partial class frmInputDetail : Form
    {
        public DataTable dt = null;
        public frmInputDetail()
        { 
            InitializeComponent();
        }

        private void frmInputBill_Load(object sender, EventArgs e)
        {
            dGV.AutoGenerateColumns = false;
            Dong.BLL.InGoods bInGoods = new Dong.BLL.InGoods();

            dt = bInGoods.getDetial(this.Tag.ToString()).Tables[0];
            BindGrid();
            if (dt.Rows.Count > 0)
            {
                lblCode.Text = dt.Rows[0]["Pcode"].ToString();
                txtOper.Text = dt.Rows[0]["Oper"].ToString();
                lblTime.Text = dt.Rows[0]["IDate"].ToString();
            }
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

        }

        private void BindGrid()
        {
            dGV.DataSource = dt;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




      
    }
}
