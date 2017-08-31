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
    public partial class frmUsers : Form
    {
        #region ------初始变量------
        private string strSql = "";
        private int intPage = 1;
        private int intPageSize = 20;
        private int pageCounts = 0;
        #endregion

        #region ------窗体实例化------
        public frmUsers()
        {
            InitializeComponent();
        }
        #endregion

        #region ------窗体加载------
        private void frmUsers_Load(object sender, EventArgs e)
        {
            //设置DataGridView的显示样式
            gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            fillGVList("", intPageSize, 1);         //填充数据

            //分页
            //初始页面显示条数选择框
            for (int i = 1; i < 6; i++)
            {
                int j = i * 10;
                cbPageSize.Items.Add(j.ToString());
            }
            cbPageSize.Text = "20";                 //页面条数显示框默认显示为20条

            //绑定页面显示条数设置控件的TextChanged事件
            cbPageSize.TextChanged += new EventHandler(cbPageSize_TextChanged);
        }
        #endregion

        #region ------搜索------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbKey.Text.Trim() != "")
            {
                strSql = "Name like '%" + tbKey.Text.Trim() + "%'";
                intPage = 1;
                fillGVList(strSql, intPageSize, 1);
            }
        }
        #endregion

        #region ------共用刷新方法------
        public void refreshData()
        {
            fillGVList(strSql, intPageSize, intPage);
        }
        #endregion

        #region ------填出datagridview------
        private void fillGVList(string key, int pageSize, int page)
        {
            strSql = key;
            intPage = page;
            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            DataSet ds = new DataSet();
            ds = bOper.GetListN(key, pageSize, page);

            gvList.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count > 0)
            {
                intPages();
            }
            else
            {
                MessageBoxEx.Show("对不起，没有您搜索的记录!");
            }

        }
        #endregion

        #region ------分页代码------
        private void intPages()
        {
            Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
            int counts = bOper.GetRecordCount(strSql);
            lblCounts.Text = counts.ToString();
            if (counts % intPageSize == 0)
            {
                pageCounts = counts / intPageSize;

            }
            else
            {
                pageCounts = (counts / intPageSize) + 1;

            }

            cbPage.Items.Clear();
            for (int i = 1; i <= pageCounts; i++)
            {
                cbPage.Items.Add(i.ToString());
            }
            cbPage.SelectedIndex = intPage - 1;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //转移到第一页
            fillGVList(strSql, intPageSize, 1);

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            intPage--;
            if (intPage >= 1)
            {
                fillGVList(strSql, intPageSize, intPage);
            }
            else
            {
                intPage++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intPage++;
            if (intPage <= pageCounts)
            {
                fillGVList(strSql, intPageSize, intPage);
            }
            else
            {
                intPage--;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            fillGVList(strSql, intPageSize, pageCounts);
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            int cPage = int.Parse(cbPage.Text);
            fillGVList(strSql, intPageSize, cPage);
        }

        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (cbPageSize.Text != "")
            {
                int cPageSize = int.Parse(cbPageSize.Text);
                intPageSize = cPageSize;
                fillGVList(strSql, cPageSize, 1);
            }
        }

        #endregion

        #region ------显示所有数据------
        private void btnAll_Click(object sender, EventArgs e)
        {
            
            fillGVList("", intPageSize, intPage);
            intPage = 1;
            

        }
        #endregion

        #region ------单条删除记录------
        private void btnDel_Click(object sender, EventArgs e)
        {
            //删除员工
            string id = gvList.SelectedRows[0].Cells[1].Value.ToString();
            if (id != "")
            {
                if (MessageBoxEx.Show("确定删除该记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Dong.BLL.OperInfo bOper = new Dong.BLL.OperInfo();
                    bOper.Delete(id);
                    this.gvList.Rows[0].Selected = true;
                    fillGVList(strSql, intPageSize, intPage);
                }
            }
            else
            {
                MessageBoxEx.Show("请选择要删除的行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ------弹出添加窗口------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUsers frmAdd = new frmAddUsers();
            frmAdd.Owner = this;
            frmAdd.ShowDialog();
        }
        #endregion

        #region ------弹出编辑窗口------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = gvList.SelectedRows[0].Cells[1].Value.ToString();
            if (id != "")
            {
                frmEditUsers frmEdit = new frmEditUsers();
                frmEdit.Owner = this;
                frmEdit.Tag = id.ToString();
                frmEdit.ShowDialog();

            }
            else
            {
                MessageBoxEx.Show("请选择要修改的行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ------双击行弹出编辑界面------
        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = gvList.SelectedRows[0].Cells[1].Value.ToString();
            if (id != "")
            {
                frmEditUsers frmEdit = new frmEditUsers();
                frmEdit.Owner = this;
                frmEdit.Tag = id.ToString();
                frmEdit.ShowDialog();
            }
        }
        #endregion
    }
}
