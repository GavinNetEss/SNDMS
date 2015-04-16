namespace ESS
{
    partial class InputMethodFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDictItem = new System.Windows.Forms.Panel();
            this.dgvDictItem = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInputCodeType = new System.Windows.Forms.ComboBox();
            this.lblInputCode = new System.Windows.Forms.TextBox();
            this.colMedOnlyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedFactory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDictItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictItem)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDictItem
            // 
            this.pnlDictItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDictItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDictItem.Controls.Add(this.dgvDictItem);
            this.pnlDictItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDictItem.Location = new System.Drawing.Point(0, 38);
            this.pnlDictItem.Name = "pnlDictItem";
            this.pnlDictItem.Size = new System.Drawing.Size(419, 298);
            this.pnlDictItem.TabIndex = 1;
            // 
            // dgvDictItem
            // 
            this.dgvDictItem.AllowUserToAddRows = false;
            this.dgvDictItem.AllowUserToDeleteRows = false;
            this.dgvDictItem.AllowUserToResizeRows = false;
            this.dgvDictItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDictItem.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDictItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDictItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDictItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedOnlyCode,
            this.colDrugName,
            this.colMedUnit,
            this.colMedFactory,
            this.colMedPack});
            this.dgvDictItem.Location = new System.Drawing.Point(0, 0);
            this.dgvDictItem.MultiSelect = false;
            this.dgvDictItem.Name = "dgvDictItem";
            this.dgvDictItem.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDictItem.RowHeadersVisible = false;
            this.dgvDictItem.RowTemplate.Height = 23;
            this.dgvDictItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictItem.ShowCellErrors = false;
            this.dgvDictItem.Size = new System.Drawing.Size(416, 293);
            this.dgvDictItem.TabIndex = 0;
            this.dgvDictItem.SelectionChanged += new System.EventHandler(this.dgvDictItem_SelectionChanged);
            this.dgvDictItem.DoubleClick += new System.EventHandler(this.dgvDictItem_DoubleClick);
            this.dgvDictItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDictItem_KeyPress);
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.cmbInputCodeType);
            this.pnlInput.Controls.Add(this.lblInputCode);
            this.pnlInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlInput.Location = new System.Drawing.Point(0, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(419, 25);
            this.pnlInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "输入码";
            // 
            // cmbInputCodeType
            // 
            this.cmbInputCodeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInputCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputCodeType.FormattingEnabled = true;
            this.cmbInputCodeType.Items.AddRange(new object[] {
            "拼音码"});
            this.cmbInputCodeType.Location = new System.Drawing.Point(352, 3);
            this.cmbInputCodeType.Name = "cmbInputCodeType";
            this.cmbInputCodeType.Size = new System.Drawing.Size(66, 20);
            this.cmbInputCodeType.TabIndex = 1;
            this.cmbInputCodeType.SelectedIndexChanged += new System.EventHandler(this.cmbInputCodeType_SelectedIndexChanged);
            this.cmbInputCodeType.SelectedValueChanged += new System.EventHandler(this.cmbInputCodeType_SelectedValueChanged);
            // 
            // lblInputCode
            // 
            this.lblInputCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInputCode.Location = new System.Drawing.Point(45, 2);
            this.lblInputCode.Name = "lblInputCode";
            this.lblInputCode.Size = new System.Drawing.Size(306, 21);
            this.lblInputCode.TabIndex = 0;
            this.lblInputCode.TextChanged += new System.EventHandler(this.lblInputCode_TextChanged);
            this.lblInputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditControl_KeyDown);
            this.lblInputCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditControl_KeyPress);
            // 
            // colMedOnlyCode
            // 
            this.colMedOnlyCode.DataPropertyName = "DrugNo";
            this.colMedOnlyCode.HeaderText = "编码";
            this.colMedOnlyCode.Name = "colMedOnlyCode";
            this.colMedOnlyCode.ReadOnly = true;
            // 
            // colDrugName
            // 
            this.colDrugName.DataPropertyName = "DrugName";
            this.colDrugName.HeaderText = "药名";
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            // 
            // colMedUnit
            // 
            this.colMedUnit.DataPropertyName = "DrugSpec";
            this.colMedUnit.HeaderText = "规格";
            this.colMedUnit.Name = "colMedUnit";
            this.colMedUnit.ReadOnly = true;
            // 
            // colMedFactory
            // 
            this.colMedFactory.DataPropertyName = "Manufactory";
            this.colMedFactory.HeaderText = "生产厂家";
            this.colMedFactory.Name = "colMedFactory";
            this.colMedFactory.ReadOnly = true;
            // 
            // colMedPack
            // 
            this.colMedPack.DataPropertyName = "Unit";
            this.colMedPack.HeaderText = "单位";
            this.colMedPack.Name = "colMedPack";
            this.colMedPack.ReadOnly = true;
            // 
            // InputMethodFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 337);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlDictItem);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputMethodFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.InputMethodFrm_Deactivate);
            this.Load += new System.EventHandler(this.InputMethodFrm_Load);
            this.Leave += new System.EventHandler(this.InputMethodFrm_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputMethodFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InputMethodFrm_MouseMove);
            this.pnlDictItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictItem)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDictItem;
        private System.Windows.Forms.DataGridView dgvDictItem;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cmbInputCodeType;
        private System.Windows.Forms.TextBox lblInputCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedOnlyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedFactory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedPack;
    }
}

