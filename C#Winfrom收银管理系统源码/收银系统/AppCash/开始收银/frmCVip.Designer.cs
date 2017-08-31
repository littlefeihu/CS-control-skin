namespace AppCash
{
    partial class frmCVip
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
            this.tbVipCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVipName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbVipCode
            // 
            this.tbVipCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbVipCode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbVipCode.Location = new System.Drawing.Point(132, 22);
            this.tbVipCode.Name = "tbVipCode";
            this.tbVipCode.Size = new System.Drawing.Size(245, 33);
            this.tbVipCode.TabIndex = 11;
            this.tbVipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "会员姓名:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(24, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "会员卡号:";
            // 
            // tbVipName
            // 
            this.tbVipName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbVipName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbVipName.ForeColor = System.Drawing.SystemColors.Info;
            this.tbVipName.Location = new System.Drawing.Point(132, 80);
            this.tbVipName.Name = "tbVipName";
            this.tbVipName.ReadOnly = true;
            this.tbVipName.Size = new System.Drawing.Size(245, 33);
            this.tbVipName.TabIndex = 14;
            this.tbVipName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(411, 141);
            this.ControlBox = false;
            this.Controls.Add(this.tbVipName);
            this.Controls.Add(this.tbVipCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVipCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVipName;
    }
}