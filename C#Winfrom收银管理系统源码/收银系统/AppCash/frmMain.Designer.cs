namespace AppCash
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnGoods = new DevComponents.DotNetBar.ButtonItem();
            this.btnCategory = new DevComponents.DotNetBar.ButtonItem();
            this.btnUnit = new DevComponents.DotNetBar.ButtonItem();
            this.btnInput = new DevComponents.DotNetBar.ButtonItem();
            this.btnPD = new DevComponents.DotNetBar.ButtonItem();
            this.btnGoodsSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnCash = new DevComponents.DotNetBar.ButtonItem();
            this.btnReport1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnSys = new DevComponents.DotNetBar.ButtonItem();
            this.btnHotKey = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSupp = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnShop = new DevComponents.DotNetBar.ButtonItem();
            this.btnVip = new DevComponents.DotNetBar.ButtonItem();
            this.btnUsers = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btnReportToDay = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportDay = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportMonth = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblShopName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAddr = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain = new DevComponents.DotNetBar.TabControl();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.cms.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel2.Size = new System.Drawing.Size(692, 66);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGoods,
            this.btnCategory,
            this.btnUnit,
            this.btnInput,
            this.btnPD,
            this.btnGoodsSearch,
            this.btnCash,
            this.btnReport1});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(593, 64);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 0;
            this.ribbonBar3.Text = "ribbonBar3";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.TitleVisible = false;
            // 
            // btnGoods
            // 
            this.btnGoods.Image = global::AppCash.Properties.Resources.Gallery;
            this.btnGoods.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnGoods.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnGoods.SubItemsExpandWidth = 14;
            this.btnGoods.Text = "商品档案";
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Image = global::AppCash.Properties.Resources.Messenger;
            this.btnCategory.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnCategory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.SubItemsExpandWidth = 14;
            this.btnCategory.Text = "商品类别";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Image = global::AppCash.Properties.Resources.Skype;
            this.btnUnit.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnUnit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.SubItemsExpandWidth = 14;
            this.btnUnit.Text = "商品单位";
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnInput
            // 
            this.btnInput.Image = global::AppCash.Properties.Resources.SoundHound;
            this.btnInput.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnInput.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInput.Name = "btnInput";
            this.btnInput.SubItemsExpandWidth = 14;
            this.btnInput.Text = "进货管理";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnPD
            // 
            this.btnPD.Image = global::AppCash.Properties.Resources.Speaker;
            this.btnPD.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnPD.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPD.Name = "btnPD";
            this.btnPD.SubItemsExpandWidth = 14;
            this.btnPD.Text = "商品盘点";
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            // 
            // btnGoodsSearch
            // 
            this.btnGoodsSearch.Image = global::AppCash.Properties.Resources.YouTube;
            this.btnGoodsSearch.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnGoodsSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGoodsSearch.Name = "btnGoodsSearch";
            this.btnGoodsSearch.SubItemsExpandWidth = 14;
            this.btnGoodsSearch.Text = "商品查询";
            this.btnGoodsSearch.Click += new System.EventHandler(this.btnGoodsSearch_Click);
            // 
            // btnCash
            // 
            this.btnCash.Image = global::AppCash.Properties.Resources.Play;
            this.btnCash.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnCash.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCash.Name = "btnCash";
            this.btnCash.SubItemsExpandWidth = 14;
            this.btnCash.Text = "开始收银";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnReport1
            // 
            this.btnReport1.Image = global::AppCash.Properties.Resources.PicsPlay;
            this.btnReport1.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnReport1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.SubItemsExpandWidth = 14;
            this.btnReport1.Text = "商品零售报表";
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // btnSys
            // 
            this.btnSys.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSys.Name = "btnSys";
            this.btnSys.SubItemsExpandWidth = 14;
            this.btnSys.Text = "收银配置";
            this.btnSys.Click += new System.EventHandler(this.btnSys_Click);
            // 
            // btnHotKey
            // 
            this.btnHotKey.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHotKey.Name = "btnHotKey";
            this.btnHotKey.SubItemsExpandWidth = 14;
            this.btnHotKey.Text = "热键设定";
            this.btnHotKey.Click += new System.EventHandler(this.btnHotKey_Click);
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "商品管理";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem3,
            this.ribbonTabItem2,
            this.ribbonTabItem4,
            this.ribbonTabItem5});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(692, 91);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar4);
            this.ribbonPanel3.Controls.Add(this.ribbonBar2);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel3.Size = new System.Drawing.Size(692, 66);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSupp});
            this.ribbonBar4.Location = new System.Drawing.Point(208, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(86, 64);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 1;
            this.ribbonBar4.Text = "ribbonBar4";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.TitleVisible = false;
            // 
            // btnSupp
            // 
            this.btnSupp.Image = global::AppCash.Properties.Resources.Dropbox;
            this.btnSupp.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSupp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.SubItemsExpandWidth = 14;
            this.btnSupp.Text = "供应商管理";
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnShop,
            this.btnVip,
            this.btnUsers});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(205, 64);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "ribbonBar2";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.TitleVisible = false;
            // 
            // btnShop
            // 
            this.btnShop.Image = global::AppCash.Properties.Resources.App_Drawer;
            this.btnShop.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnShop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShop.Name = "btnShop";
            this.btnShop.SubItemsExpandWidth = 14;
            this.btnShop.Text = "商铺信息";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnVip
            // 
            this.btnVip.Image = global::AppCash.Properties.Resources.Contacts;
            this.btnVip.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnVip.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVip.Name = "btnVip";
            this.btnVip.SubItemsExpandWidth = 14;
            this.btnVip.Text = "会员管理";
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::AppCash.Properties.Resources.eBuddy;
            this.btnUsers.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.SubItemsExpandWidth = 14;
            this.btnUsers.Text = "员工管理";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar7);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel4.Size = new System.Drawing.Size(692, 66);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.DragDropSupport = true;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReportToDay,
            this.btnReportDay,
            this.btnReportMonth});
            this.ribbonBar7.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(273, 64);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 1;
            this.ribbonBar7.Text = "ribbonBar7";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.TitleVisible = false;
            // 
            // btnReportToDay
            // 
            this.btnReportToDay.Image = global::AppCash.Properties.Resources.Calendar;
            this.btnReportToDay.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnReportToDay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReportToDay.Name = "btnReportToDay";
            this.btnReportToDay.SubItemsExpandWidth = 14;
            this.btnReportToDay.Text = "当日营收";
            this.btnReportToDay.Click += new System.EventHandler(this.btnReportToDay_Click);
            // 
            // btnReportDay
            // 
            this.btnReportDay.Image = global::AppCash.Properties.Resources.Calculator;
            this.btnReportDay.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnReportDay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReportDay.Name = "btnReportDay";
            this.btnReportDay.SubItemsExpandWidth = 14;
            this.btnReportDay.Text = "营收日报";
            this.btnReportDay.Click += new System.EventHandler(this.btnReportDay_Click);
            // 
            // btnReportMonth
            // 
            this.btnReportMonth.Image = global::AppCash.Properties.Resources.Clock;
            this.btnReportMonth.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnReportMonth.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReportMonth.Name = "btnReportMonth";
            this.btnReportMonth.SubItemsExpandWidth = 14;
            this.btnReportMonth.Text = "营收月报";
            this.btnReportMonth.Click += new System.EventHandler(this.btnReportMonth_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Controls.Add(this.ribbonBar1);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel5.Size = new System.Drawing.Size(692, 66);
            // 
            // 
            // 
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 5;
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "基本资料";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "财务管理";
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.Checked = true;
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Panel = this.ribbonPanel5;
            this.ribbonTabItem5.Text = "关于我们";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMCloseAll,
            this.btnMCloseOther});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(125, 48);
            // 
            // btnMCloseAll
            // 
            this.btnMCloseAll.Name = "btnMCloseAll";
            this.btnMCloseAll.Size = new System.Drawing.Size(124, 22);
            this.btnMCloseAll.Text = "全部关闭";
            this.btnMCloseAll.Click += new System.EventHandler(this.btnMCloseAll_Click);
            // 
            // btnMCloseOther
            // 
            this.btnMCloseOther.Name = "btnMCloseOther";
            this.btnMCloseOther.Size = new System.Drawing.Size(124, 22);
            this.btnMCloseOther.Text = "关闭其它";
            this.btnMCloseOther.Click += new System.EventHandler(this.btnMCloseOther_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblShopName,
            this.lblUser,
            this.lblAddr,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(692, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = false;
            this.lblShopName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblShopName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(200, 21);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 21);
            // 
            // lblAddr
            // 
            this.lblAddr.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblAddr.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(257, 21);
            this.lblAddr.Spring = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = false;
            this.lblDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 21);
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.CanReorderTabs = true;
            this.tabMain.CloseButtonOnTabsVisible = true;
            this.tabMain.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 91);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = -1;
            this.tabMain.Size = new System.Drawing.Size(692, 274);
            this.tabMain.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tabMain.TabIndex = 4;
            this.tabMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabMain.Text = "tabControl1";
            this.tabMain.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabMain_TabItemClose);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(100, 64);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleVisible = false;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::AppCash.Properties.Resources.Messages;
            this.buttonItem1.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "微信";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = global::AppCash.Properties.Resources.QQ;
            this.buttonItem2.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "QQ";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 391);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "享智收银管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ButtonItem btnSys;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnGoods;
        private DevComponents.DotNetBar.ButtonItem btnCategory;
        private DevComponents.DotNetBar.ButtonItem btnUnit;
        private DevComponents.DotNetBar.ButtonItem btnHotKey;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnSupp;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnShop;
        private DevComponents.DotNetBar.ButtonItem btnVip;
        private DevComponents.DotNetBar.ButtonItem btnUsers;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnReportToDay;
        private DevComponents.DotNetBar.ButtonItem btnReportDay;
        private DevComponents.DotNetBar.ButtonItem btnReportMonth;
        private DevComponents.DotNetBar.ButtonItem btnInput;
        private DevComponents.DotNetBar.ButtonItem btnPD;
        private DevComponents.DotNetBar.ButtonItem btnGoodsSearch;
        private DevComponents.DotNetBar.ButtonItem btnCash;
        private DevComponents.DotNetBar.ButtonItem btnReport1;
        private System.Windows.Forms.ToolStripMenuItem btnMCloseAll;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem btnMCloseOther;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevComponents.DotNetBar.TabControl tabMain;
        private System.Windows.Forms.ToolStripStatusLabel lblShopName;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblAddr;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
    }
}