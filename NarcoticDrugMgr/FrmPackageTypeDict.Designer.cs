namespace SNDMS.NarcoticDrugMgr
{
    partial class FrmPackageTypeDict
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
            this.dgvPackageDrugList = new System.Windows.Forms.DataGridView();
            this.colDrugNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufactory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelPackageType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManufactory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddPackageType = new System.Windows.Forms.Button();
            this.txtPackageTypeName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tvPackageType = new System.Windows.Forms.TreeView();
            this.lblPackageTypeSelected = new System.Windows.Forms.Label();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageDrugList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackageDrugList
            // 
            this.dgvPackageDrugList.AllowUserToAddRows = false;
            this.dgvPackageDrugList.AllowUserToDeleteRows = false;
            this.dgvPackageDrugList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackageDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDrugNo,
            this.colDrugName,
            this.colDrugSpec,
            this.colManufactory,
            this.colCount});
            this.dgvPackageDrugList.Location = new System.Drawing.Point(217, 54);
            this.dgvPackageDrugList.Name = "dgvPackageDrugList";
            this.dgvPackageDrugList.ReadOnly = true;
            this.dgvPackageDrugList.RowHeadersWidth = 25;
            this.dgvPackageDrugList.RowTemplate.Height = 23;
            this.dgvPackageDrugList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackageDrugList.Size = new System.Drawing.Size(693, 371);
            this.dgvPackageDrugList.TabIndex = 0;
            // 
            // colDrugNo
            // 
            this.colDrugNo.HeaderText = "药品编号";
            this.colDrugNo.Name = "colDrugNo";
            this.colDrugNo.ReadOnly = true;
            this.colDrugNo.Visible = false;
            // 
            // colDrugName
            // 
            this.colDrugName.HeaderText = "药品";
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            // 
            // colDrugSpec
            // 
            this.colDrugSpec.HeaderText = "规格";
            this.colDrugSpec.Name = "colDrugSpec";
            this.colDrugSpec.ReadOnly = true;
            // 
            // colManufactory
            // 
            this.colManufactory.HeaderText = "厂家";
            this.colManufactory.Name = "colManufactory";
            this.colManufactory.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "数量";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // btnDelPackageType
            // 
            this.btnDelPackageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelPackageType.Location = new System.Drawing.Point(121, 402);
            this.btnDelPackageType.Name = "btnDelPackageType";
            this.btnDelPackageType.Size = new System.Drawing.Size(75, 23);
            this.btnDelPackageType.TabIndex = 13;
            this.btnDelPackageType.Text = "删除";
            this.btnDelPackageType.UseVisualStyleBackColor = true;
            this.btnDelPackageType.Click += new System.EventHandler(this.btnDelPackageType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "所选套餐箱：";
            // 
            // txtManufactory
            // 
            this.txtManufactory.Location = new System.Drawing.Point(550, 22);
            this.txtManufactory.Name = "txtManufactory";
            this.txtManufactory.ReadOnly = true;
            this.txtManufactory.Size = new System.Drawing.Size(105, 23);
            this.txtManufactory.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "厂家";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(399, 22);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(105, 23);
            this.txtSpec.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "规格";
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(249, 22);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(105, 23);
            this.txtDrugName.TabIndex = 17;
            this.txtDrugName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrugName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "药品";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(698, 22);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(105, 23);
            this.txtCount.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "数量";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(809, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddPackageType
            // 
            this.btnAddPackageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPackageType.Location = new System.Drawing.Point(27, 402);
            this.btnAddPackageType.Name = "btnAddPackageType";
            this.btnAddPackageType.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackageType.TabIndex = 28;
            this.btnAddPackageType.Text = "添加";
            this.btnAddPackageType.UseVisualStyleBackColor = true;
            this.btnAddPackageType.Click += new System.EventHandler(this.btnAddPackageType_Click);
            // 
            // txtPackageTypeName
            // 
            this.txtPackageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPackageTypeName.Location = new System.Drawing.Point(28, 371);
            this.txtPackageTypeName.Name = "txtPackageTypeName";
            this.txtPackageTypeName.Size = new System.Drawing.Size(168, 23);
            this.txtPackageTypeName.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(863, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tvPackageType
            // 
            this.tvPackageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPackageType.Location = new System.Drawing.Point(27, 54);
            this.tvPackageType.Name = "tvPackageType";
            this.tvPackageType.ShowPlusMinus = false;
            this.tvPackageType.ShowRootLines = false;
            this.tvPackageType.Size = new System.Drawing.Size(169, 305);
            this.tvPackageType.TabIndex = 31;
            this.tvPackageType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPackageType_AfterSelect);
            // 
            // lblPackageTypeSelected
            // 
            this.lblPackageTypeSelected.AutoSize = true;
            this.lblPackageTypeSelected.ForeColor = System.Drawing.Color.Red;
            this.lblPackageTypeSelected.Location = new System.Drawing.Point(97, 25);
            this.lblPackageTypeSelected.Name = "lblPackageTypeSelected";
            this.lblPackageTypeSelected.Size = new System.Drawing.Size(0, 17);
            this.lblPackageTypeSelected.TabIndex = 32;
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(399, -7);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.ReadOnly = true;
            this.txtDrugID.Size = new System.Drawing.Size(105, 23);
            this.txtDrugID.TabIndex = 33;
            this.txtDrugID.Visible = false;
            // 
            // FrmPackageTypeDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.txtDrugID);
            this.Controls.Add(this.lblPackageTypeSelected);
            this.Controls.Add(this.tvPackageType);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPackageTypeName);
            this.Controls.Add(this.btnAddPackageType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManufactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrugName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelPackageType);
            this.Controls.Add(this.dgvPackageDrugList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPackageTypeDict";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmDrugDict";
            this.Load += new System.EventHandler(this.FrmPackageBoxDict_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageDrugList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPackageDrugList;
        private System.Windows.Forms.Button btnDelPackageType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufactory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.TextBox txtManufactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddPackageType;
        private System.Windows.Forms.TextBox txtPackageTypeName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView tvPackageType;
        private System.Windows.Forms.Label lblPackageTypeSelected;
        private System.Windows.Forms.TextBox txtDrugID;
    }
}