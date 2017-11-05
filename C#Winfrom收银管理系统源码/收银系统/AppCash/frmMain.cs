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
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.EnableGlass = false;
            ribbonControl1.Items[0].ShowSubItems = true;
            InitModules();
        }
        private void InitModules()
        {
            List<ButtonItem> btnItems = new List<ButtonItem>();

            foreach (var tabItem in ribbonControl1.Items)
            {
                RibbonTabItem ribbonTabItem = tabItem as RibbonTabItem;
                if (ribbonTabItem == null)
                    continue;
                foreach (RibbonBar ribbonBar in ribbonTabItem.Panel.Controls)
                {
                    foreach (var item in ribbonBar.Items)
                    {
                        ButtonItem btnItem = item as ButtonItem;
                        if (btnItem != null)
                        {
                            btnItems.Add(btnItem);
                        }
                        else
                        {
                            ItemContainer itemContainer = item as ItemContainer;

                            foreach (var subitem in itemContainer.SubItems)
                            {
                                ButtonItem btnItem1 = subitem as ButtonItem;
                                btnItems.Add(btnItem1);
                            }
                        }
                    }
                }
            }

            foreach (var btnitem in btnItems)
            {
                if (Dong.Model.GlobalsInfo.userflag == 0)
                {
                    //管理员

                }
                else
                {
                    //收银员

                    if (btnitem.Text == "开始收银"|| btnitem.Text =="微信" || btnitem.Text =="QQ" )
                    {
                        btnitem.Enabled = true;
                    }
                    else
                    {
                        btnitem.Enabled = false;
                    }
                }
            }

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 检测要打开的tab
        /// </summary>
        /// <param name="tabName"></param>
        /// <returns></returns>
        private bool IsOpenTab(string tabName)
        {
            bool isOpened = false;

            foreach (TabItem tab in tabMain.Tabs)
            {
                if (tab.Name == tabName.Trim())
                {
                    isOpened = true;
                    tabMain.SelectedTab = tab;
                    break;
                }
            }
            return isOpened;
        }
        public void openWindow(Form frm, string Name)
        {
            DevComponents.DotNetBar.TabItem tp = new DevComponents.DotNetBar.TabItem();
            DevComponents.DotNetBar.TabControlPanel tcp = new DevComponents.DotNetBar.TabControlPanel();
            tp.MouseDown += new MouseEventHandler(tp_MouseDown);
            tcp.Dock = System.Windows.Forms.DockStyle.Fill;
            tcp.Location = new System.Drawing.Point(0, 0);

            frm.TopLevel = false;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tcp.Controls.Add(frm);
            tp.Text = frm.Text;
            tp.Name = Name;

            if (!IsOpenTab(Name))
            {
                tcp.TabItem = tp;
                tp.AttachedControl = tcp;
                tabMain.Controls.Add(tcp);
                tabMain.Tabs.Add(tp);
                tabMain.SelectedTab = tp;
            }
            tabMain.Refresh();
        }
        private void tp_MouseDown(object sender, MouseEventArgs e)
        {
            tabMain.SelectedTab = (TabItem)sender;
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem tb = tabMain.SelectedTab;
            tabMain.Tabs.Remove(tb);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " --【" + Dong.Model.GlobalsInfo.shopName + "】";
            lblDate.Text = DateTime.Now.Date.ToString("yyyy年MM月dd日");
            lblShopName.Text = Dong.Model.GlobalsInfo.shopName;
            lblUser.Text = Dong.Model.GlobalsInfo.UserName;
            lblAddr.Text = Dong.Model.GlobalsInfo.shopAddr;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            //弹出商铺信息窗口
            frmShop frm = new frmShop();
            openWindow(frm, frm.Name);
        }
        private void btnSys_Click(object sender, EventArgs e)
        {
            frmCashSet frm = new frmCashSet();

            openWindow(frm, frm.Name);
        }
        private void btnHotKey_Click(object sender, EventArgs e)
        {
            frmHotKey frm = new frmHotKey();
            openWindow(frm, frm.Name);
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            frmVip frm = new frmVip();
            openWindow(frm, frm.Name);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            openWindow(frm, frm.Name);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            frmSup frm = new frmSup();
            openWindow(frm, frm.Name);
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            frmGoods frm = new frmGoods();
            openWindow(frm, frm.Name);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            openWindow(frm, frm.Name);
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmUnit frm = new frmUnit();
            openWindow(frm, frm.Name);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmInput frm = new frmInput();
            openWindow(frm, frm.Name);
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            frmPD frm = new frmPD();
            openWindow(frm, frm.Name);
        }

        private void btnGoodsSearch_Click(object sender, EventArgs e)
        {
            frmGoodsSearch frm = new frmGoodsSearch();
            openWindow(frm, frm.Name);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmCash frm = new frmCash();
            //openWindow(frm, frm.Name);
            frm.Show();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            frmReport1 frm = new frmReport1();
            openWindow(frm, frm.Name);
        }

        private void btnJB_Click(object sender, EventArgs e)
        {
            frmJB frm = new frmJB();
            openWindow(frm, frm.Name);
        }

        private void btnReportToDay_Click(object sender, EventArgs e)
        {
            frmToday frm = new frmToday();
            openWindow(frm, frm.Name);
        }

        private void btnReportDay_Click(object sender, EventArgs e)
        {
            frmReportDay frm = new frmReportDay();
            openWindow(frm, frm.Name);
        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            frmReportMonth frm = new frmReportMonth();
            openWindow(frm, frm.Name);
        }

        private void tabMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void tabMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void btnMCloseAll_Click(object sender, EventArgs e)
        {
            tabMain.Tabs.Clear();
        }

        private void btnMCloseOther_Click(object sender, EventArgs e)
        {

            do
            {
                if (tabMain.SelectedTab != tabMain.Tabs[0])
                {
                    tabMain.Tabs.RemoveAt(0);
                }
                else
                {
                    tabMain.Tabs.RemoveAt(1);
                }

            } while (tabMain.Tabs.Count != 1);

            tabMain.Refresh();
        }
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();

        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出收银系统吗?", "退出确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Visible = false;
        }

        private void switchButtonItem1_ValueChanged(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = !ribbonControl1.Expanded;
        }
    }

}
