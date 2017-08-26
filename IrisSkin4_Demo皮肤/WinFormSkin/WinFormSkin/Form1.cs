using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormSkin
{
    public partial class Form1 : Form
    {
        Sunisoft.IrisSkin.SkinEngine s;
        public Form1()
        {
            InitializeComponent();
            s = new Sunisoft.IrisSkin.SkinEngine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.DataSource = new DirectoryInfo("Skins").GetFiles();
            this.listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
                s.SkinFile = (this.listBox1.SelectedItem as FileInfo).FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
