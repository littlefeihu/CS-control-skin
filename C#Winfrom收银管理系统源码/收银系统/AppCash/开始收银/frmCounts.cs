using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCash
{
    public partial class frmCounts : Form
    {
        public frmCounts()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:

                    this.Close();
                    return true;
                case Keys.Enter:
                    if (tbCounts.Text != "")
                    {
                        frmCash frmP = (frmCash)this.Owner;
                        frmP.editCounts(int.Parse(tbCounts.Text));
                        this.Close();
                    }
                    
                    return true;
                
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void frmCounts_Load(object sender, EventArgs e)
        {
            this.Show();
            this.TopMost = true;
        }
    }
}
