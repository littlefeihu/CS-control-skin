using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace wind
{
    public partial class FrmTest : Office2007Form
    {
        
        public FrmTest()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        string[] skinNames = { "Office2007Blue", "Office2007Silver", "Office2007Black", "Office2010Silver", "Office2013" };
        private void FrmTest_Load(object sender, EventArgs e)
        {
            foreach (string skin in skinNames)
            {
                this.cmbSkin.Items.Add(skin);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            switch (this.cmbSkin.Text)
            {
                case "Office2007Blue":
                    this.styleManager1.ManagerStyle = eStyle.Office2007Blue;
                    break;
                case "Office2007Silver":
                    this.styleManager1.ManagerStyle = eStyle.Office2007Silver;
                    break ;
                case "Office2007Black":
                    this.styleManager1.ManagerStyle = eStyle.Office2007Black;
                    break;
                case "Office2010Silver":
                    this.styleManager1.ManagerStyle = eStyle.Office2010Silver;
                    break;
                case "Office2013":
                    this.styleManager1.ManagerStyle = eStyle.Office2013;
                    break;   
            }
        }
    }
}
