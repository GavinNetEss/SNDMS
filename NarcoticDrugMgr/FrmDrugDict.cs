using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SNDMS.NarcoticDrugMgr
{
    public partial class FrmDrugDict : Form
    {
        DAL.DrugDict dalDrug = new DAL.DrugDict();
        DataTable dtDrug = null;
        /// <summary>
        /// 记录Gridview的选择行
        /// </summary>
        int dgvSelectedIndex = 0; 

        public FrmDrugDict()
        {
            InitializeComponent();
        }

        private void FrmDrugDict_Load(object sender, EventArgs e)
        {
            BindDrugList();
        }

        /// <summary>
        /// 绑定药品信息
        /// </summary>
        private void BindDrugList()
        {
            DataSet dsDrug = dalDrug.GetList("");
            if(dsDrug!=null && dsDrug.Tables[0].Rows.Count>0)
            {
                dtDrug = dsDrug.Tables[0];

                dgvDrugList.DataSource = dtDrug.DefaultView;
            }
        }

        /// <summary>
        /// 重新选中之前的行
        /// </summary>
        private void ReSelect()
        {
            if (dgvDrugList.Rows.Count > 0)
            {
                if (dgvSelectedIndex < dgvDrugList.Rows.Count)
                {
                    dgvDrugList.Rows[dgvSelectedIndex].Selected = true;
                }
            }
        }


        //新增药品
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();

            if (dtDrug != null)
            {
                DataRow drNew = dtDrug.NewRow();

                dtDrug.Rows.Add(drNew);
                dgvDrugList.DataSource = dtDrug.DefaultView;

                this.dgvDrugList.Rows[dgvDrugList.Rows.Count - 1].Selected = true;


            }
            //标识状态
            txtDrugNo.Text = "新增";
            txtName.Focus();
        }

        /// <summary>
        /// 重置输入区域
        /// </summary>
        private void Reset()
        {
            txtDrugNo.Text = "";
            txtFactory.Text = "";
            txtName.Text = "";
            txtSpec.Text = "";
            txtUnitPackage.Text = "";
            cmbClass.SelectedIndex = 0;
            rbtnRecyleNo.Checked = true;        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text == "" || cmbClass.Text == "-请选择-")
            {
                MessageBox.Show("请选择药品类别");
                cmbClass.Focus();
                return;
            }

            //采集数据
            Model.DrugModel modelDrug = new Model.DrugModel();
            modelDrug.DrugName = txtName.Text.Trim();
            modelDrug.DrugSpec = txtSpec.Text.Trim();
            modelDrug.Manufactory = txtFactory.Text.Trim();
            modelDrug.Unit = txtUnitPackage.Text.Trim();
            modelDrug.DrugClass = cmbClass.Text;
            modelDrug.PYcode = txtPYCode.Text;

            if (rbtnRecyleYes.Checked)
            {
                modelDrug.IsRecycle = "是";
            }
            else
            {
                modelDrug.IsRecycle = "否";
            }

            

            if (txtDrugNo.Text == "新增")//新增保存
            {
                dalDrug.Add(modelDrug);
            }
            else //修改保存
            {
                modelDrug.DrugNo = int.Parse(txtDrugNo.Text);

                if (dalDrug.Update(modelDrug) == false)
                {
                    MessageBox.Show("修改失败，请重试");
                    return;
                }
            }

            //刷新绑定结果
            BindDrugList();
            ReSelect();
        }

        /// <summary>
        /// 根据选择行的内容，右侧显示详细，进行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDrugList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDrugList.SelectedRows.Count > 0)
            { 
                int i = dgvDrugList.SelectedRows[0].Index;
                txtDrugNo.Text = dgvDrugList.Rows[i].Cells["colDrugNo"].Value.ToString().Trim();

                this.txtName.Text = dgvDrugList.Rows[i].Cells["colDrugName"].Value.ToString().Trim();
                this.txtSpec.Text = dgvDrugList.Rows[i].Cells["colDrugSpec"].Value.ToString().Trim();
                this.txtUnitPackage.Text = dgvDrugList.Rows[i].Cells["colUnit"].Value.ToString().Trim();
                this.txtFactory.Text = dgvDrugList.Rows[i].Cells["colManufactory"].Value.ToString().Trim();
                this.cmbClass.Text = dgvDrugList.Rows[i].Cells["colDrugClass"].Value.ToString().Trim();
                
                if (dgvDrugList.Rows[i].Cells["colIsRecycle"].Value.ToString().Trim() == "是")
                {
                    rbtnRecyleYes.Checked = true;
                }
                else
                {
                    rbtnRecyleNo.Checked = true;
                }

                               
            }
        }

        private void dgvDrugList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelectedIndex = e.RowIndex;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDrugNo.Text != "" && txtDrugNo.Text != "新增")
            {
                if (dalDrug.Delete(int.Parse(txtDrugNo.Text)) == true)
                {
                    MessageBox.Show("删除成功");

                    //刷新绑定结果
                    BindDrugList();
                    ReSelect();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtPYCode.Text = SNDMS.Assist.PYcode.EssGetChineseSpellFirst(txtName.Text.Trim());
        }

      
    }
}
