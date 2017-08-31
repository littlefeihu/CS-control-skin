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
    public partial class frmReportDay : Form
    {

        

        #region ------窗体实例化------
        public frmReportDay()
        {
            InitializeComponent();
        }
        #endregion

        #region ------窗体加载------
        private void frmReportDay_Load(object sender, EventArgs e)
        {
            //设置DataGridView的显示样式
            gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gvList.AutoGenerateColumns = false;

        }
        #endregion



        #region ------搜索------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSql = "";
            string time1 = string.Empty;
            string time2 = string.Empty;
            string startTime = txtStart.Text.Trim();
            string endTime = txtEnd.Text.Trim();
            if (string.IsNullOrEmpty(startTime) && string.IsNullOrEmpty(endTime))
            {
                MessageBoxEx.Show("开始时间或结束时间不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStart.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(startTime) && !string.IsNullOrEmpty(endTime))
            {
                strSql += " and IDate >= #" + startTime + "# and IDate<=#" + endTime + "# ";
                time1 = startTime;
                time2 = endTime;
            }
            else
            {
                if (!string.IsNullOrEmpty(startTime))
                {
                    strSql += " and IDate = #" + startTime + "# ";
                    time1 = startTime;
                }
                else
                {
                    strSql += "  and IDate=#" + endTime + "# ";
                    time1 = endTime;
                }
            }
            fillGVList(strSql, time1, time2);
        }
        #endregion



        #region ------填出datagridview------
        private void fillGVList(string key, string time1, string time2)
        {

            Dong.BLL.SaleInfo bll = new Dong.BLL.SaleInfo();
            DataTable dt = new DataTable();
            dt = bll.getDayRePort(Convert.ToDateTime(time1), Convert.ToDateTime(time2));
            gvList.DataSource = dt;
            int count = 0;
            double price = 0;
            double gain = 0;
            foreach (DataRow dr in dt.Rows)
            {
                count += int.Parse(dr[0].ToString());
                price += double.Parse(dr[1].ToString());
                gain += double.Parse(dr[2].ToString());
            }
            lblCount.Text = count.ToString();
            lblXSZE.Text = price.ToString();
            lblGain.Text = gain.ToString();
        }
        #endregion





    }
}
