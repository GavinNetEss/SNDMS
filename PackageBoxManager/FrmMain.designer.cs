namespace SNDMS.PackageBoxManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.btnUsualBoxTypeSet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRecycle = new System.Windows.Forms.Button();
            this.btnReplenish = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblTitle);
            this.gbLogin.Controls.Add(this.lblName);
            this.gbLogin.Controls.Add(this.btnLogout);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.pictureBox1);
            this.gbLogin.Location = new System.Drawing.Point(75, 70);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(269, 653);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(91, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 27);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(55, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "角色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(55, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "用户：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLog.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblLog.Location = new System.Drawing.Point(119, 664);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(158, 31);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "点击此处登录";
            this.lblLog.Visible = false;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(12, 735);
            this.txtCardNo.MaxLength = 10;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(1, 23);
            this.txtCardNo.TabIndex = 0;
            // 
            // btnUsualBoxTypeSet
            // 
            this.btnUsualBoxTypeSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsualBoxTypeSet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUsualBoxTypeSet.Location = new System.Drawing.Point(678, 132);
            this.btnUsualBoxTypeSet.Name = "btnUsualBoxTypeSet";
            this.btnUsualBoxTypeSet.Size = new System.Drawing.Size(137, 77);
            this.btnUsualBoxTypeSet.TabIndex = 2;
            this.btnUsualBoxTypeSet.Text = "常用设置";
            this.btnUsualBoxTypeSet.UseVisualStyleBackColor = true;
            this.btnUsualBoxTypeSet.Click += new System.EventHandler(this.btnUsualBoxTypeSet_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(895, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "快速取箱";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.Location = new System.Drawing.Point(678, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "取箱";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button4.Location = new System.Drawing.Point(895, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 77);
            this.button4.TabIndex = 5;
            this.button4.Text = "还箱";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button5.Location = new System.Drawing.Point(678, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 77);
            this.button5.TabIndex = 5;
            this.button5.Text = "临时还箱";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button6.Location = new System.Drawing.Point(895, 438);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 77);
            this.button6.TabIndex = 6;
            this.button6.Text = "临时取箱";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnRecycle
            // 
            this.btnRecycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecycle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRecycle.Location = new System.Drawing.Point(895, 591);
            this.btnRecycle.Name = "btnRecycle";
            this.btnRecycle.Size = new System.Drawing.Size(137, 77);
            this.btnRecycle.TabIndex = 8;
            this.btnRecycle.Text = "回收开箱";
            this.btnRecycle.UseVisualStyleBackColor = true;
            // 
            // btnReplenish
            // 
            this.btnReplenish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplenish.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReplenish.Location = new System.Drawing.Point(678, 591);
            this.btnReplenish.Name = "btnReplenish";
            this.btnReplenish.Size = new System.Drawing.Size(137, 77);
            this.btnReplenish.TabIndex = 7;
            this.btnReplenish.Text = "补药";
            this.btnReplenish.UseVisualStyleBackColor = true;
            this.btnReplenish.Click += new System.EventHandler(this.btnReplenish_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblName.Location = new System.Drawing.Point(105, 252);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "TEST";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblTitle.Location = new System.Drawing.Point(105, 288);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 17);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "专职药师";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnRecycle);
            this.Controls.Add(this.btnReplenish);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUsualBoxTypeSet);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lblLog);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Button btnUsualBoxTypeSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRecycle;
        private System.Windows.Forms.Button btnReplenish;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
    }
}

