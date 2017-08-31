namespace AppCash
{
    partial class frmMoney
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
            this.tbYS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSSJE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbZL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbYS
            // 
            this.tbYS.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbYS.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYS.Location = new System.Drawing.Point(129, 23);
            this.tbYS.Name = "tbYS";
            this.tbYS.ReadOnly = true;
            this.tbYS.Size = new System.Drawing.Size(178, 33);
            this.tbYS.TabIndex = 10;
            this.tbYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(21, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "应收金额:";
            // 
            // tbSSJE
            // 
            this.tbSSJE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSSJE.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSSJE.Location = new System.Drawing.Point(129, 80);
            this.tbSSJE.Name = "tbSSJE";
            this.tbSSJE.Size = new System.Drawing.Size(178, 33);
            this.tbSSJE.TabIndex = 1;
            this.tbSSJE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSSJE.TextChanged += new System.EventHandler(this.tbSSJE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "实收金额:";
            // 
            // tbZL
            // 
            this.tbZL.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbZL.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbZL.Location = new System.Drawing.Point(129, 139);
            this.tbZL.Name = "tbZL";
            this.tbZL.ReadOnly = true;
            this.tbZL.Size = new System.Drawing.Size(178, 33);
            this.tbZL.TabIndex = 10;
            this.tbZL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "找回金额:";
            // 
            // frmMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(353, 201);
            this.ControlBox = false;
            this.Controls.Add(this.tbZL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSSJE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYS);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSSJE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZL;
        private System.Windows.Forms.Label label2;
    }
}