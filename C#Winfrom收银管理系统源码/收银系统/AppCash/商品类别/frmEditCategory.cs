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
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
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
            //验证类别名称

            if (txtName.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入商品类别名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }



            Dong.BLL.Category bll = new Dong.BLL.Category();
            Dong.Model.Category model = new Dong.Model.Category();
            model.Name = txtName.Text;
            model.Id = int.Parse(this.Tag.ToString());
            if (bll.Update(model))
            {
                MessageBoxEx.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCategory fvip = (frmCategory)this.Owner;
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

        private void frmEditUnit_Load(object sender, EventArgs e)
        {
            Dong.BLL.Category bll = new Dong.BLL.Category();
            Dong.Model.Category model = new Dong.Model.Category();
            model = bll.GetModel(int.Parse(this.Tag.ToString()));
            if (model != null)
            {
                txtName.Text = model.Name;

            }
        }
    }
}
