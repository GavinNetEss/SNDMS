namespace SNDMS.NarcoticDrugMgr
{
    partial class FrmDrugDict
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
            this.dgvDrugList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRecyleNo = new System.Windows.Forms.RadioButton();
            this.rbtnRecyleYes = new System.Windows.Forms.RadioButton();
            this.txtDrugNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPackage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colDrugNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufactory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comPYcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPYCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDrugList
            // 
            this.dgvDrugList.AllowUserToAddRows = false;
            this.dgvDrugList.AllowUserToDeleteRows = false;
            this.dgvDrugList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDrugNo,
            this.colDrugName,
            this.colDrugSpec,
            this.colManufactory,
            this.colUnit,
            this.colIsRecycle,
            this.colDrugClass,
            this.comPYcode});
            this.dgvDrugList.Location = new System.Drawing.Point(25, 25);
            this.dgvDrugList.MultiSelect = false;
            this.dgvDrugList.Name = "dgvDrugList";
            this.dgvDrugList.ReadOnly = true;
            this.dgvDrugList.RowHeadersWidth = 25;
            this.dgvDrugList.RowTemplate.Height = 23;
            this.dgvDrugList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugList.Size = new System.Drawing.Size(525, 395);
            this.dgvDrugList.TabIndex = 0;
            this.dgvDrugList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugList_CellClick);
            this.dgvDrugList.SelectionChanged += new System.EventHandler(this.dgvDrugList_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPYCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbtnRecyleNo);
            this.groupBox1.Controls.Add(this.rbtnRecyleYes);
            this.groupBox1.Controls.Add(this.txtDrugNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitPackage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFactory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSpec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(580, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbtnRecyleNo
            // 
            this.rbtnRecyleNo.AutoSize = true;
            this.rbtnRecyleNo.Location = new System.Drawing.Point(152, 224);
            this.rbtnRecyleNo.Name = "rbtnRecyleNo";
            this.rbtnRecyleNo.Size = new System.Drawing.Size(38, 21);
            this.rbtnRecyleNo.TabIndex = 6;
            this.rbtnRecyleNo.TabStop = true;
            this.rbtnRecyleNo.Text = "否";
            this.rbtnRecyleNo.UseVisualStyleBackColor = true;
            // 
            // rbtnRecyleYes
            // 
            this.rbtnRecyleYes.AutoSize = true;
            this.rbtnRecyleYes.Location = new System.Drawing.Point(80, 224);
            this.rbtnRecyleYes.Name = "rbtnRecyleYes";
            this.rbtnRecyleYes.Size = new System.Drawing.Size(38, 21);
            this.rbtnRecyleYes.TabIndex = 5;
            this.rbtnRecyleYes.TabStop = true;
            this.rbtnRecyleYes.Text = "是";
            this.rbtnRecyleYes.UseVisualStyleBackColor = true;
            // 
            // txtDrugNo
            // 
            this.txtDrugNo.Location = new System.Drawing.Point(80, 31);
            this.txtDrugNo.Name = "txtDrugNo";
            this.txtDrugNo.ReadOnly = true;
            this.txtDrugNo.Size = new System.Drawing.Size(146, 23);
            this.txtDrugNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "药品编号";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(46, 371);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "-请选择-",
            "麻醉药品",
            "精神一类药品",
            "精神二类药品",
            "高危药品",
            "普通药品"});
            this.cmbClass.Location = new System.Drawing.Point(81, 261);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(145, 25);
            this.cmbClass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "药品类别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "是否回收";
            // 
            // txtUnitPackage
            // 
            this.txtUnitPackage.Location = new System.Drawing.Point(80, 183);
            this.txtUnitPackage.Name = "txtUnitPackage";
            this.txtUnitPackage.Size = new System.Drawing.Size(146, 23);
            this.txtUnitPackage.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "包装单位";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(80, 145);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(146, 23);
            this.txtFactory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "生产厂家";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(80, 107);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(146, 23);
            this.txtSpec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "药品规格";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称";
            // 
            // colDrugNo
            // 
            this.colDrugNo.DataPropertyName = "DrugNo";
            this.colDrugNo.HeaderText = "编号";
            this.colDrugNo.Name = "colDrugNo";
            this.colDrugNo.ReadOnly = true;
            this.colDrugNo.Width = 55;
            // 
            // colDrugName
            // 
            this.colDrugName.DataPropertyName = "DrugName";
            this.colDrugName.HeaderText = "药品名称";
            this.colDrugName.Name = "colDrugName";
            this.colDrugName.ReadOnly = true;
            // 
            // colDrugSpec
            // 
            this.colDrugSpec.DataPropertyName = "DrugSpec";
            this.colDrugSpec.HeaderText = "药品规格";
            this.colDrugSpec.Name = "colDrugSpec";
            this.colDrugSpec.ReadOnly = true;
            // 
            // colManufactory
            // 
            this.colManufactory.DataPropertyName = "Manufactory";
            this.colManufactory.HeaderText = "生产厂家";
            this.colManufactory.Name = "colManufactory";
            this.colManufactory.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "包装单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colIsRecycle
            // 
            this.colIsRecycle.DataPropertyName = "IsRecycle";
            this.colIsRecycle.HeaderText = "是否回收";
            this.colIsRecycle.Name = "colIsRecycle";
            this.colIsRecycle.ReadOnly = true;
            // 
            // colDrugClass
            // 
            this.colDrugClass.DataPropertyName = "DrugClass";
            this.colDrugClass.HeaderText = "药品类别";
            this.colDrugClass.Name = "colDrugClass";
            this.colDrugClass.ReadOnly = true;
            // 
            // comPYcode
            // 
            this.comPYcode.DataPropertyName = "PYcode";
            this.comPYcode.HeaderText = "拼音简码";
            this.comPYcode.Name = "comPYcode";
            this.comPYcode.ReadOnly = true;
            // 
            // txtPYCode
            // 
            this.txtPYCode.Location = new System.Drawing.Point(80, 301);
            this.txtPYCode.Name = "txtPYCode";
            this.txtPYCode.ReadOnly = true;
            this.txtPYCode.Size = new System.Drawing.Size(146, 23);
            this.txtPYCode.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "拼音简码";
            // 
            // FrmDrugDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDrugList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDrugDict";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmDrugDict";
            this.Load += new System.EventHandler(this.FrmDrugDict_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrugList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDrugNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPackage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnRecyleNo;
        private System.Windows.Forms.RadioButton rbtnRecyleYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufactory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn comPYcode;
        private System.Windows.Forms.TextBox txtPYCode;
        private System.Windows.Forms.Label label8;
    }
}