using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNDMS.DAL;
using ESS;

namespace SNDMS.NarcoticDrugMgr
{
    public partial class FrmPackageTypeDict : Form
    {
        DAL.PackageTypeDAL dalPackageType = new PackageTypeDAL();
        DAL.PackageTypeDrugDAL dalPackageTypeDrug = new PackageTypeDrugDAL();

        public FrmPackageTypeDict()
        {
            InitializeComponent();
        }

        private void FrmPackageBoxDict_Load(object sender, EventArgs e)
        {
            //绑定现有的套餐箱列表
            BindPackageType();
            //输入法
            if (InputMethod.Input == null)
            {
                InputMethod.Input = new InputMethodFrm();
            }
        }
        /// <summary>
        /// 绑定现有的套餐箱列表
        /// </summary>
        private void BindPackageType()
        {
            tvPackageType.Nodes.Clear();

            DataSet dsPackageType = dalPackageType.GetList("");
            if (dsPackageType != null && dsPackageType.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsPackageType.Tables[0].Rows.Count; i++)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dsPackageType.Tables[0].Rows[i]["PackageTypeName"].ToString();
                    tn.Tag = dsPackageType.Tables[0].Rows[i]["PackageTypeNo"].ToString();
                    tn.ToolTipText = dsPackageType.Tables[0].Rows[i]["PackageTypeName"].ToString();

                    tvPackageType.Nodes.Add(tn);
                }
            }
        }

        /// <summary>
        /// 绑定套餐箱详细
        /// </summary>
        private void BindPackageDrugList(string packageTypeNo)
        {

            DataSet dsPackageDrug = dalPackageType.GetListWithDrugName(" packageTypeNo =" + packageTypeNo);
            if (dsPackageDrug != null && dsPackageDrug.Tables[0].Rows.Count > 0)
            {
                dgvPackageDrugList.DataSource = dsPackageDrug.Tables[0].DefaultView;
            }
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPackageType_Click(object sender, EventArgs e)
        {
            if (txtPackageTypeName.Text.Trim() == "")
            {
                MessageBox.Show("请填写套餐箱类型名称");
                txtPackageTypeName.Focus();
                return;
            }

            //添加
            SNDMS.Model.PackageType model = new Model.PackageType();
            model.PackageTypeName = txtPackageTypeName.Text.Trim();
            dalPackageType.Add(model);
            //刷新绑定
            BindPackageType();

            //重置输入区域
            txtPackageTypeName.Text = "";
            txtPackageTypeName.Focus();
        }

        /// <summary>
        /// 删除
        /// </summary>
        private void btnDelPackageType_Click(object sender, EventArgs e)
        {
            if (tvPackageType.SelectedNode != null)
            {
                int typeNo = int.Parse(tvPackageType.SelectedNode.Tag.ToString());
                dalPackageType.Delete(typeNo);
                //刷新绑定
                BindPackageType();
            }
        }

        private void tvPackageType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvPackageType.SelectedNode != null)
            {
                lblPackageTypeSelected.Text = tvPackageType.SelectedNode.Text;                
                string packageTypeNo = tvPackageType.SelectedNode.Tag.ToString();

                BindPackageDrugList(packageTypeNo);
            }
        }

        


        private void txtDrugName_KeyDown(object sender, KeyEventArgs e)
        {
            string key = "";
            //只传 字母和数字
            if (e.KeyValue >= 48 && e.KeyValue <= 105)
            {
                key = e.KeyCode.ToString();

                InputMethod.Input.ItemSelected = drugInputed;
                Control ctrlEdit = sender as Control;
                InputMethod.Input.InputBegin(ctrlEdit, "药品字典表", key);
            }

        }
        private void drugInputed(object sender, InputResult e)
        {
            TextBox tb = sender as TextBox;

            txtDrugName.Text = e.ItemName.Trim();
            txtDrugID.Text = e.ItemCode.Trim();
            txtManufactory.Text = e.Performed_dept.Trim();
            txtSpec.Text = e.ItemSpec.Trim();

            txtCount.Focus();
            txtCount.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

      
    }
}
