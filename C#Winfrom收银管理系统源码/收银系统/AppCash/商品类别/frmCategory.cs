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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        #region ------窗体加载------
        private void frmUnit_Load(object sender, EventArgs e)
        {
            //设置DataGridView的显示样式
            gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvList.AutoGenerateColumns = false;
            fillGVList();
        }
        #endregion

        #region ------弹出添加窗孔------
        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddCategory frmAdd = new frmAddCategory();
            frmAdd.Owner = this;
            frmAdd.ShowDialog();
        }
        #endregion

        #region ------单条删除记录------
        private void btnDel_Click(object sender, EventArgs e)
        {
            //删除会员
            string id = gvList.SelectedRows[0].Cells[0].Value.ToString();
            if (id != "")
            {
                if (MessageBoxEx.Show("确定删除该记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Dong.BLL.Category bll = new Dong.BLL.Category();
                    bll.Delete(int.Parse(id));
                    this.gvList.Rows[0].Selected = true;
                    fillGVList();
                }
            }
            else
            {
                MessageBoxEx.Show("请选择要删除的行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ------弹出编辑窗口------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = gvList.SelectedRows[0].Cells[0].Value.ToString();
            if (id != "")
            {
                frmEditCategory frmEdit = new frmEditCategory();
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

        #region ------填出datagridview------
        private void fillGVList()
        {


            Dong.BLL.Category bVip = new Dong.BLL.Category();
            DataSet ds = new DataSet();
            ds = bVip.GetAllList();

            gvList.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count > 0)
            {

            }
            else
            {
                MessageBoxEx.Show("对不起，没有您搜索的记录!");
            }

        }
        #endregion

        #region ------共用刷新方法------
        public void refreshData()
        {
            fillGVList();
        }
        #endregion

        #region ------双击行弹出编辑界面------
        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = gvList.SelectedRows[0].Cells[0].Value.ToString();
            if (id != "")
            {
                frmEditCategory frmEdit = new frmEditCategory();
                frmEdit.Owner = this;
                frmEdit.Tag = id.ToString();
                frmEdit.ShowDialog();
            }
        }
        #endregion

    }
}
