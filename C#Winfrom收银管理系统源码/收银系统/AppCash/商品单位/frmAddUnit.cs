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
    public partial class frmAddUnit : Form
    {
        public frmAddUnit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //验证单位名称

            if (txtUnit.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入商品单位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
                return;
            }



            Dong.BLL.Unit bUnit = new Dong.BLL.Unit();
            Dong.Model.Unit model = new Dong.Model.Unit();
            model.Name = txtUnit.Text;

            if (bUnit.Add(model))
            {
                MessageBoxEx.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUnit fvip = (frmUnit)this.Owner;
                fvip.refreshData();
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
