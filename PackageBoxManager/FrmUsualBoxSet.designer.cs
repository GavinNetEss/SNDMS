namespace SNDMS.PackageBoxManager
{
    partial class FrmUsualBoxSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.btnType1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPackageBoxType = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPackageBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(12, 735);
            this.txtCardNo.MaxLength = 10;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(1, 23);
            this.txtCardNo.TabIndex = 0;
            // 
            // btnType1
            // 
            this.btnType1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnType1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnType1.Location = new System.Drawing.Point(20, 20);
            this.btnType1.Name = "btnType1";
            this.btnType1.Size = new System.Drawing.Size(135, 80);
            this.btnType1.TabIndex = 4;
            this.btnType1.Text = "普通麻醉药箱";
            this.btnType1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button4.Location = new System.Drawing.Point(236, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "无痛人流药箱";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(161, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "请选择常用手术箱：";
            // 
            // pnlPackageBoxType
            // 
            this.pnlPackageBoxType.Controls.Add(this.button2);
            this.pnlPackageBoxType.Controls.Add(this.button5);
            this.pnlPackageBoxType.Controls.Add(this.button4);
            this.pnlPackageBoxType.Controls.Add(this.btnType1);
            this.pnlPackageBoxType.Location = new System.Drawing.Point(148, 182);
            this.pnlPackageBoxType.Name = "pnlPackageBoxType";
            this.pnlPackageBoxType.Size = new System.Drawing.Size(596, 407);
            this.pnlPackageBoxType.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(20, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 80);
            this.button2.TabIndex = 7;
            this.button2.Text = "苏醒室药箱";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button5.Location = new System.Drawing.Point(20, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "抢救车";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(163, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "点击快速取药时，会自动提供";
            // 
            // lblSelectedType
            // 
            this.lblSelectedType.AutoSize = true;
            this.lblSelectedType.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lblSelectedType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedType.Location = new System.Drawing.Point(415, 616);
            this.lblSelectedType.Name = "lblSelectedType";
            this.lblSelectedType.Size = new System.Drawing.Size(126, 25);
            this.lblSelectedType.TabIndex = 12;
            this.lblSelectedType.Text = "普通麻醉药箱";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(649, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "主页";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmUsualBoxSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSelectedType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPackageBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardNo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(455, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsualBoxSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlPackageBoxType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Button btnType1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPackageBoxType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedType;
        private System.Windows.Forms.Button btnClose;
    }
}

