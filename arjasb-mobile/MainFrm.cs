using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

using  System.IO;

namespace arjasb_mobile
{
   
    public partial class MainFrm : Form
    {
        
        public MainFrm()
        {
            InitializeComponent();
           
           
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'common_DataSet.ownertbl' table. You can move, or remove it, as needed.
            this.ownertblTableAdapter.Fill(this.common_DataSet.ownertbl);
            try
            {
                // TODO: This line of code loads data into the 'common_DataSet.MaxOrderId' table. You can move, or remove it, as needed.
                this.maxOrderIdTableAdapter.Fill(this.common_DataSet.MaxOrderId);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDefectType' table. You can move, or remove it, as needed.
                this.showDefectTypeTableAdapter.Fill(this.common_DataSet.ShowDefectType);




                while (true)
                {
                    LoginFrm obj = new LoginFrm();
                    System.Windows.Forms.DialogResult dr = obj.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.Abort)
                    {
                        MessageBox.Show("کاربر مورد نظر معتبر نمیباشد ", "وارد شدن کاربر نامعتبر"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                    else if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        obj.Dispose();
                        break;
                    }
                    else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    {
                        Application.Exit();
                        break;
                    }
                    obj.Dispose();
                }
                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceManufacturer' table. You can move, or remove it, as needed.
                this.showDeviceManufacturerTableAdapter.Fill(this.common_DataSet.ShowDeviceManufacturer);
                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvman' table. You can move, or remove it, as needed.
                this.showSrvmanTableAdapter.Fill(this.common_DataSet.ShowSrvman);


                // TODO: This line of code loads data into the 'common_DataSet.ShowDefectSolution' table. You can move, or remove it, as needed.
                this.showDefectSolutionTableAdapter.Fill(this.common_DataSet.ShowDefectSolution, CBoxDeviceName_for_ShowDefect.Text, CBoxDefectType_for_ShowDefect.Text
                    , txtSearchDefect.Text);

                // TODO: This line of code loads data into the 'common_DataSet.ShowOrderMenu' table. You can move, or remove it, as needed.
                this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                     , txtSearchOrderId.Text
                     , txtSearchDeviceName.Text
                     , txtSearchOwner.Text);

                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceNames' table. You can move, or remove it, as needed.
                this.showDeviceNamesTableAdapter.Fill(this.common_DataSet.ShowDeviceNames);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDefectType' table. You can move, or remove it, as needed.
                this.showDefectTypeTableAdapter.Fill(this.common_DataSet.ShowDefectType);
                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvman' table. You can move, or remove it, as needed.
                this.showSrvmanTableAdapter.Fill(this.common_DataSet.ShowSrvman);
                # region DataGridview
                //foreach (DataRow row in GVTable)//???????????????????????
                //{
                //    GVTable.Rows[0].Cells[0].
                //}
                //this.txtSelectSrvman.Text="1";
                // DataGridViewCheckBoxColumn GVchekedbox = new DataGridViewCheckBoxColumn();



                //this.رمDataGridViewCheckBoxColumn.DataPropertyName = "رم";
                //this.رمDataGridViewCheckBoxColumn.HeaderText = "رم";
                //this.رمDataGridViewCheckBoxColumn.Name = "رمDataGridViewCheckBoxColumn";
                //this.رمDataGridViewCheckBoxColumn.ReadOnly = true;
                //// 
                //// شارژرDataGridViewCheckBoxColumn
                //// 
                //this.شارژرDataGridViewCheckBoxColumn.DataPropertyName = "شارژر";
                //this.شارژرDataGridViewCheckBoxColumn.HeaderText = "شارژر";
                //this.شارژرDataGridViewCheckBoxColumn.Name = "شارژرDataGridViewCheckBoxColumn";
                //this.شارژرDataGridViewCheckBoxColumn.ReadOnly = true;
                //// 
                //// باطریDataGridViewCheckBoxColumn
                //// 
                //this.باطریDataGridViewCheckBoxColumn.DataPropertyName = "باطری";
                //this.باطریDataGridViewCheckBoxColumn.HeaderText = "باطری";
                //this.باطریDataGridViewCheckBoxColumn.Name = "باطریDataGridViewCheckBoxColumn";
                //this.باطریDataGridViewCheckBoxColumn.ReadOnly = true;

                //this.GVTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                //                    this.شمارهسفارشDataGridViewTextBoxColumn,
                //                    this.نامگوشیDataGridViewTextBoxColumn,
                //                    this.ناممشتریDataGridViewTextBoxColumn,
                //                    this.رمDataGridViewCheckBoxColumn,
                //                    this.شارژرDataGridViewCheckBoxColumn,
                //                    this.باطریDataGridViewCheckBoxColumn,
                //                    this.تاریخدریافتDataGridViewTextBoxColumn,
                //                    this.تاریختعمیرDataGridViewTextBoxColumn,
                //                    this.پیشپرداختDataGridViewTextBoxColumn,
                //                    this.توضیحاتDataGridViewTextBoxColumn,
                //                    this.نامقطعهDataGridViewTextBoxColumn,
                //                    this.نامتعمیرکارDataGridViewTextBoxColumn,
                //                    this.نختعمیرکارDataGridViewTextBoxColumn});
                #endregion
                var db = new linqDataContext();
                //GVTable.DataSource = db.ShowOrderMenu();///?????????????????

                GVTableSrv1.DataSource = db.ShowDeviceReapairing(Convert.ToInt32(txtSelectSrvman.SelectedValue));
                GVTableSrv2.DataSource = db.ShowDeviceRepaired(Convert.ToInt32(txtSelectSrvman.SelectedValue));
                GVTablePart.DataSource = db.ShowParts();
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void Refresh_Commponent(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceManufacturer' table. You can move, or remove it, as needed.
                this.showDeviceManufacturerTableAdapter.Fill(this.common_DataSet.ShowDeviceManufacturer);
                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvman' table. You can move, or remove it, as needed.
                this.showSrvmanTableAdapter.Fill(this.common_DataSet.ShowSrvman);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDefectSolution' table. You can move, or remove it, as needed.
                this.showDefectSolutionTableAdapter.Fill(this.common_DataSet.ShowDefectSolution, CBoxDeviceName_for_ShowDefect.Text, CBoxDefectType_for_ShowDefect.Text
                    , txtSearchDefect.Text.Substring(0, txtSearchOrderId.Text.Length));

                // TODO: This line of code loads data into the 'common_DataSet.ShowOrderMenu' table. You can move, or remove it, as needed.
                this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);

                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceNames' table. You can move, or remove it, as needed.
                this.showDeviceNamesTableAdapter.Fill(this.common_DataSet.ShowDeviceNames);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDefectType' table. You can move, or remove it, as needed.
                this.showDefectTypeTableAdapter.Fill(this.common_DataSet.ShowDefectType);
                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvman' table. You can move, or remove it, as needed.
                this.showSrvmanTableAdapter.Fill(this.common_DataSet.ShowSrvman);
                # region DataGridview
                //foreach (DataRow row in GVTable)//???????????????????????
                //{
                //    GVTable.Rows[0].Cells[0].
                //}
                //this.txtSelectSrvman.Text="1";
                // DataGridViewCheckBoxColumn GVchekedbox = new DataGridViewCheckBoxColumn();



                //this.رمDataGridViewCheckBoxColumn.DataPropertyName = "رم";
                //this.رمDataGridViewCheckBoxColumn.HeaderText = "رم";
                //this.رمDataGridViewCheckBoxColumn.Name = "رمDataGridViewCheckBoxColumn";
                //this.رمDataGridViewCheckBoxColumn.ReadOnly = true;
                //// 
                //// شارژرDataGridViewCheckBoxColumn
                //// 
                //this.شارژرDataGridViewCheckBoxColumn.DataPropertyName = "شارژر";
                //this.شارژرDataGridViewCheckBoxColumn.HeaderText = "شارژر";
                //this.شارژرDataGridViewCheckBoxColumn.Name = "شارژرDataGridViewCheckBoxColumn";
                //this.شارژرDataGridViewCheckBoxColumn.ReadOnly = true;
                //// 
                //// باطریDataGridViewCheckBoxColumn
                //// 
                //this.باطریDataGridViewCheckBoxColumn.DataPropertyName = "باطری";
                //this.باطریDataGridViewCheckBoxColumn.HeaderText = "باطری";
                //this.باطریDataGridViewCheckBoxColumn.Name = "باطریDataGridViewCheckBoxColumn";
                //this.باطریDataGridViewCheckBoxColumn.ReadOnly = true;

                //this.GVTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                //                    this.شمارهسفارشDataGridViewTextBoxColumn,
                //                    this.نامگوشیDataGridViewTextBoxColumn,
                //                    this.ناممشتریDataGridViewTextBoxColumn,
                //                    this.رمDataGridViewCheckBoxColumn,
                //                    this.شارژرDataGridViewCheckBoxColumn,
                //                    this.باطریDataGridViewCheckBoxColumn,
                //                    this.تاریخدریافتDataGridViewTextBoxColumn,
                //                    this.تاریختعمیرDataGridViewTextBoxColumn,
                //                    this.پیشپرداختDataGridViewTextBoxColumn,
                //                    this.توضیحاتDataGridViewTextBoxColumn,
                //                    this.نامقطعهDataGridViewTextBoxColumn,
                //                    this.نامتعمیرکارDataGridViewTextBoxColumn,
                //                    this.نختعمیرکارDataGridViewTextBoxColumn});
                #endregion
                var db = new linqDataContext();


                GVTableSrv1.DataSource = db.ShowDeviceReapairing(Convert.ToInt32(txtSelectSrvman.SelectedValue));
                GVTableSrv2.DataSource = db.ShowDeviceRepaired(Convert.ToInt32(txtSelectSrvman.SelectedValue));
                GVTablePart.DataSource = db.ShowParts();

                this.FormBorderStyle = FormBorderStyle.FixedDialog;

                //GVTable.DataSource = db.ShowOrderMenu();///?????????????????

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ////////////////////    Order tab  /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
                //var db = new linqDataContext();
                //GVTable.DataSource = db.ShowOrderMenu();
                this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchOrderId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //var db = new linqDataContext();
                if (txtSearchOrderId.Text == "")
                {

                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);
                    // GVTable.DataSource = db.ShowOrderMenu();
                }
                else
                {

                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);
                    //GVTable.DataSource = db.ShearchOrder( txtSearchOrderId.Text.Substring(0, txtSearchOrderId.Text.Length));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtSearchDeviceName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                if (txtSearchDeviceName.Text == "")
                {
                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);
                    //GVTable.DataSource = db.ShowOrderMenu();
                }
                else
                {

                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);
                    //GVTable.DataSource = db.ShearchOrderDI(txtSearchDeviceName.Text.Substring(0, txtSearchDeviceName.Text.Length));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchOwner_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                if (txtSearchOwner.Text == "")
                {
                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                    , txtSearchOrderId.Text
                    , txtSearchDeviceName.Text
                    , txtSearchOwner.Text);
                    // GVTable.DataSource = db.ShowOrderMenu();
                }
                else
                {
                    this.showOrderMenuTableAdapter.Fill(this.common_DataSet.ShowOrderMenu
                     , txtSearchOrderId.Text
                     , txtSearchDeviceName.Text
                     , txtSearchOwner.Text);
                    // GVTable.DataSource = db.ShearchOrderOwner(txtSearchOwner.Text.Substring(0, txtSearchOwner.Text.Length));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
      

        

        private void orderbtn_Click(object sender, EventArgs e)
        {
            try
            {

                var db = new linqDataContext();
                var addorder = new OrderAddFrm();
                addorder.txtOrderId.Text = (db.MaxOrderId() + 1).ToString();


                //var d = DateTime.Now.Day.ToString();
                //var m = DateTime.Now.Month.ToString();
                //var y = DateTime.Now.Year.ToString();

                addorder.mtxtDate.Text = PersianDate.GetPersianDate();
                //addorder.dtpDate.Text = PersianDate.GetPersianDate();


                addorder.ShowDialog();
                Refresh_Commponent(null, null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var addorder = new OrderEditFrm();
                if (GVTable.RowCount > 1)
                {
                    addorder.txtOrderId.Text = GVTable.CurrentRow.Cells[0].Value.ToString();
                    addorder.CBoxMobileName.Text = GVTable.CurrentRow.Cells[1].Value.ToString();
                    addorder.txtOwner.Text = GVTable.CurrentRow.Cells[2].Value.ToString();
                    addorder.CHBox1.Checked = Convert.ToBoolean(GVTable.CurrentRow.Cells[3].Value);
                    addorder.CHBox2.Checked = Convert.ToBoolean(GVTable.CurrentRow.Cells[4].Value);
                    addorder.CHBox3.Checked = Convert.ToBoolean(GVTable.CurrentRow.Cells[5].Value);
                    if (GVTable.CurrentRow.Cells[6].Value != null)
                        addorder.mtxtDate.Text = GVTable.CurrentRow.Cells[6].Value.ToString();


                }
                addorder.ShowDialog();

                Refresh_Commponent(null, null);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GVTable.RowCount == 0) return;
                if (MessageBox.Show("                    آیا می خواهید حذف کنید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //  MessageBox.Show(
                    var db = new linqDataContext();

                    if (GVTable.RowCount > 1)
                    {

                        db.DeleteOrder(Convert.ToInt32(GVTable.CurrentRow.Cells[0].Value));

                    }
                    Refresh_Commponent(null, null);

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                var ORFrmObj = new OrderReportFrm();
                // ORFrmObj.GVvalue=GVTable.CurrentRow.Cells[0];

                ORFrmObj.NumberRowOfGridview = Convert.ToInt32(GVTable.CurrentRow.Cells[0].Value.ToString());


                ORFrmObj.ShowDialog();
                Refresh_Commponent(null, null);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ///////// tab  SERVICEMAN //////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage2_Click(object sender, EventArgs e)
        {
          //  Refresh_Commponent(null,null);

        }


        //private void txtSrvMan_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    btnsSelectDevice.Enabled = true;
        //}

        private void txtSelectSrvman_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                GVTableSrv1.DataSource = db.ShowDeviceReapairing(Convert.ToInt32(txtSelectSrvman.SelectedValue));
                GVTableSrv2.DataSource = db.ShowDeviceRepaired(Convert.ToInt32(txtSelectSrvman.SelectedValue));


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtSelectSrvman_TextChanged(object sender, EventArgs e)
        {
            btnsSelectDevice.Enabled = true;

        }
        

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();

                PersonalInfFrm p = new PersonalInfFrm();
                p.txtSrvMan.Text = (db.MaxSrvId() + 1).ToString();

                // p.textBoxSrvId.Text = txtSelectSrvman.SelectedValue.ToString();
                p.ShowDialog();
                Refresh_Commponent(null, null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnDelSrvMan_Click(object sender, EventArgs e)
        {
            try
            {
                var DelSrvObj = new PersonalInfDelFrm();
                DelSrvObj.ShowDialog();
                Refresh_Commponent(null, null);
            }
             
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void btnRtoL_Click(object sender, EventArgs e)
        {
            try
            {
                if (GVTableSrv1.RowCount == 0) return;
                var db = new linqDataContext();



                db.ChangeDeviceState(Convert.ToInt32(GVTableSrv1.CurrentRow.Cells[0].Value), true, PersianDate.GetPersianDate());
                Refresh_Commponent(null, null);
            }
             
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            
            }

        private void btnLtoR_Click(object sender, EventArgs e)
        {
            try
            {
            if (GVTableSrv2.RowCount == 0) return;
            var db = new linqDataContext();
            db.ChangeDeviceState(Convert.ToInt32(GVTableSrv2.CurrentRow.Cells[0].Value),false,null);
            Refresh_Commponent(null,null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void btnsSelectDevice_Click(object sender, EventArgs e)
        {
            try
            {
                // var selectD = new SelectDevicesOfSrvman();
                //selectD.
                SelectDevicesOfSrvman sd = new SelectDevicesOfSrvman();
                sd.idvalue = txtSelectSrvman.SelectedValue.ToString();
                sd.ShowDialog();

                Refresh_Commponent(null, null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnAssemblePart_Click(object sender, EventArgs e)
        {
            try

            {
                if (GVTableSrv1.RowCount > 0)
                {
                 
                    var SP = new SelectPartFrm();
                    SP.orderIdValue = GVTableSrv1.CurrentRow.Cells[0].Value.ToString();
                    SP.ShowDialog();
                    Refresh_Commponent(null,null);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnApplyExpr_Click(object sender, EventArgs e)
        {
            try
            {
            var db = new linqDataContext();

            db.UpdateExpr(Convert.ToInt32(GVTableSrv1.CurrentRow.Cells[0].Value), txtExpretion.Text);
            Refresh_Commponent(null,null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

      


        /// <summary>
        /// //////////////////// tab   PARTS   ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tabPage3_Click(object sender, EventArgs e)
        {
            Refresh_Commponent(null,null);


        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            try
            {
            var db = new linqDataContext();

            var PartAddObj = new PartAddFrm();
            PartAddObj.txtPartId.Text = (db.MaxPartId()+1).ToString();
        //    PartAddObj.txtPartId.Text = GVTablePart.CurrentRow.Cells[0].Value.ToString();
            PartAddObj.ShowDialog();
            Refresh_Commponent(null,null);
             }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            try
            {


                var editpartobj = new PartEditFrm();

                editpartobj.txtPartId.Text = GVTablePart.CurrentRow.Cells[0].Value.ToString();
                editpartobj.txtPartId.Text = GVTablePart.CurrentRow.Cells[0].Value.ToString();
                editpartobj.txtPartName.Text = GVTablePart.CurrentRow.Cells[1].Value.ToString();
                editpartobj.txtPartPrice.Text = GVTablePart.CurrentRow.Cells[2].Value.ToString();
                editpartobj.txtPartAlert.Text = GVTablePart.CurrentRow.Cells[3].Value.ToString();
                editpartobj.ShowDialog();

                Refresh_Commponent(null, null);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (GVTable.RowCount == 0) return;
                if (MessageBox.Show("آیا می خواهید حذف کنید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var db = new linqDataContext();
                    db.DeletePart(Convert.ToInt32(GVTablePart.CurrentRow.Cells[0].Value));
                    Refresh_Commponent(null, null);

                }
            }

            catch (System.Exception ex)
            { 
            System.Windows.Forms.MessageBox.Show(ex.Message);
                
            }
        }



        private void GVTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnEditPart.Enabled = true;
                btnDelPart.Enabled = true;

                string a = DateTime.Now.Date.ToString();
                string b = a.Substring(0, 8);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                if (txtSearch.Text == "")
                {
                    Refresh_Commponent(null, null);
                }
                else
                {
                    GVTablePart.DataSource = db.ShearchPart(txtSearch.Text.Substring(0, txtSearch.Text.Length));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
      

        //private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        //{
        //    btnSearch.Enabled = true;
        //}

       

       
        /// <summary>
        /// ////////////////////// tab    INFORMATION     /////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void CBoxDeviceManufaturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.showDeviceNamesbyCategorizingTableAdapter.Fill(this.common_DataSet.ShowDeviceNamesbyCategorizing
                    , CBoxDeviceManufaturer.Text);

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnEnableCBoxs_Click(object sender, EventArgs e)
        {
            try
            {
                this.CBoxDeviceManufaturer.Enabled = true;
                this.CboxDeviceName_for_AddDevice.Enabled = true;
                this.chBoxCboxDefectTypeEnable_for_AddDevice.Enabled = true;


                this.labelDeviceManufaturer.ForeColor = System.Drawing.SystemColors.ButtonFace;
                this.labelDeviceName.ForeColor = System.Drawing.SystemColors.ButtonFace;
                this.chBoxCboxDefectTypeEnable_for_AddDevice.ForeColor = System.Drawing.SystemColors.ButtonFace;

                this.btnEnableCBoxs.Visible = false;

                this.btnApplyDevice.Location = new System.Drawing.Point(402, 38);

                this.btnApplyDevice.Visible = true;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void btnApplyDevice_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                db.ApplyDevice(CBoxDeviceManufaturer.Text, CBoxDeviceName_for_ShowDefect.Text);

                this.btnEnableCBoxs.Visible = true;

                this.CBoxDeviceManufaturer.Enabled = false;
                this.CboxDeviceName_for_AddDevice.Enabled = false;
                this.chBoxCboxDefectTypeEnable_for_AddDevice.Enabled = false;
                this.CBoxDefectType_for_AddDevice.Enabled = false;

                this.labelDeviceManufaturer.ForeColor = System.Drawing.SystemColors.ButtonShadow;
                this.labelDeviceName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
                this.chBoxCboxDefectTypeEnable_for_AddDevice.ForeColor = System.Drawing.SystemColors.ButtonShadow;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void chBoxCboxDefectTypeEnable_for_AddDevice_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chBoxCboxDefectTypeEnable_for_AddDevice.Checked == true)

                    this.CBoxDefectType_for_AddDevice.Enabled = true;

                else if (this.chBoxCboxDefectTypeEnable_for_AddDevice.Checked == false)
                {
                    this.CBoxDefectType_for_AddDevice.Enabled = false;
                    this.CBoxDefectType_for_AddDevice.Text = null;

                }
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



      

        /// <summary>
        /// ///////////////////////////////// ایرادات////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.showDefectSolutionTableAdapter.Fill(this.common_DataSet.ShowDefectSolution
                    , CBoxDeviceName_for_ShowDefect.Text, CBoxDefectType_for_ShowDefect.Text, txtSearchDefect.Text);

                this.showDefectTypebyCategorizingTableAdapter.Fill(this.common_DataSet.ShowDefectTypebyCategorizing, CBoxDeviceName_for_ShowDefect.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CBoxDefectType_for_ShowDefect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.showDefectSolutionTableAdapter.Fill(this.common_DataSet.ShowDefectSolution
                  , CBoxDeviceName_for_ShowDefect.Text, CBoxDefectType_for_ShowDefect.Text, txtSearchDefect.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void txtSearchDefect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.showDefectSolutionTableAdapter.Fill(this.common_DataSet.ShowDefectSolution
                   , CBoxDeviceName_for_ShowDefect.Text, CBoxDefectType_for_ShowDefect.Text, txtSearchDefect.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
       
/// <summary>
/// //////////////////////////////////////ایراد جدید//////////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
///         

      

        private void chBoxDefectType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chBoxCBoxDefectTypeEnable_for_AddDefect.Checked == true)
                    CBoxDefecttype_for_AddDefect.Enabled = true;
                else if (this.chBoxCBoxDefectTypeEnable_for_AddDefect.Checked == false)
                {
                    CBoxDefecttype_for_AddDefect.Enabled = false;
                    CBoxDefecttype_for_AddDefect.Text = null;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void chBoxCBoxDiveNameEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chBoxCBoxDiveNameEnable.Checked == true)
                    this.CBoxDeviceName_for_AddDefect.Enabled = true;
                else if (this.chBoxCBoxDiveNameEnable.Checked == false)
                {
                    this.CBoxDeviceName_for_AddDefect.Enabled = false;
                    this.CBoxDeviceName_for_AddDefect.Text = null;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
        //// private Boolean checkastate1 = true;
       // private void CHBoxAdrFile_CheckedChanged(object sender, EventArgs e)
       // {
       //     RichtxtAdrFile.Enabled = true;
       //     CHBoxUrls.Checked = false;
       //     RichtxtUrls.Enabled = false;
       // }

       // private void CHBoxUrls_CheckedChanged(object sender, EventArgs e)
       // {
       //      RichtxtUrls.Enabled = true;
       //     CHBoxAdrFile.Checked = false;
       //     RichtxtAdrFile.Enabled = false;
       // }
        
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {

                var op = new OpenFileDialog();
                string fname = op.FileName.Replace("","");
                // op.Filter = "my dat files (*.dt))";

                DialogResult dr;
                dr = op.ShowDialog();
                if (dr == DialogResult.OK)
                {

                    //int r=this.RichtxtAdrFile.Text.Last();
                    // this.RichtxtAdrFile.Text.Insert(0, fname);
                    RichtxtAdrFile.Text = fname;

                    if (this.chBoxCBoxDiveNameEnable.Checked)
                    {
                        System.IO.Directory.CreateDirectory("c:\\ArjasbMobile\\Defects\\"
                            + this.CBoxDeviceName_for_AddDefect.Text);

                        if(this.chBoxCBoxDefectTypeEnable_for_AddDefect.Checked)
                        {
                            System.IO.Directory.CreateDirectory("c:\\ArjasbMobile\\Defects\\"
                            + this.CBoxDeviceName_for_AddDefect.Text + "\\" + this.CBoxDefecttype_for_AddDefect.Text);
                            
                            
                          //  op.FileName.Replace("*\\", "");


                            System.IO.File.Copy( op.FileName,
                                "c:\\ArjasbMobile\\Defects\\"+ this.CBoxDeviceName_for_AddDefect.Text 
                                + "\\" + this.CBoxDefecttype_for_AddDefect.Text,true);
                        }

                    }

                }
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          
        }
        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //   // string fname=LBoxUsfullAdrFile.SelectedItem.ToString();

        //   //this.LBoxUsfullAdrFile.Items.Clear();
        //   // LBoxUsfullAdrFile.Refresh();

        //}

        private void BtnApplySolution_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                db.ApplyDefect(CBoxDefecttype_for_AddDefect.Text, txtDefect.Text
                    , txtSolution.Text, RichtxtAdrFile.Text, RichtxtUrls.Text);/// ?????هنوز فایل و لینک ندارد????????
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// /////////////////////  tab   PRINTS ////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage5_Click(object sender, EventArgs e)
        {
          //  this.chartDeviceRipaired.dat
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "سفارشات")
                {
                    this.crystalReportViewer1.ReportSource = System.IO.Directory.GetCurrentDirectory() + "\\customer.rpt";

                }
                else if (comboBox1.SelectedItem.ToString() == "گوشی")
                {
                    this.crystalReportViewer1.ReportSource = System.IO.Directory.GetCurrentDirectory() + "\\mobile.rpt";

                }

                else if (comboBox1.SelectedItem.ToString() == "قطعات")
                {
                    this.crystalReportViewer1.ReportSource = System.IO.Directory.GetCurrentDirectory() + "\\part.rpt";

                }
                else
                {
                   
                }
                this.crystalReportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
       


       

       

        


/// <summary>
/// ////////////////////////     Others   //////////////////////////////////////////////////////////////////////////////////////////    
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //        this.partsTableAdapter.FillBy(this._arjasb_mobile_DBDataSet.Parts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d =new testFrm();
            d.ShowDialog();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      

        //private void btntest_Click(object sender, EventArgs e)
        //{
        //    var testFrm = new testFrm();
        //    testFrm.ShowDialog();

        //}
       
        //private void CBoxReportItems_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(CBoxReportItems.Text=="سفارش")
        //    {
        //    this.CBoxReportSubItems.Items.AddRange(new object[] {
        //    "تعداد گوشی های تعمیر شده ونشده",
        //    "تعداد هر مدل گوشی در ماه",
        //    "تعداد خرابی در ماه"
        //    });
        //    }
        //    else if (CBoxReportItems.Text == "قطعه")
        //    {
        //        this.CBoxReportSubItems.Items.AddRange(new object[] {
        //    "تعداد قطعات مصرف شده و نشده",
        //    "قطعات در مرز هشدار",
        //    "پیک مصرف هر قطعه بر حسب نام"
        //   });
        //    }
        //    else if (CBoxReportItems.Text == "درآمد")
        //    {
        //        this.CBoxReportSubItems.Items.AddRange(new object[] {
        //    "هزینه قطعات",
        //    "هزینه سفارشات",
        //    "درآمد کل و درآمد مقطعی-ماهانه"
        //    });
        //    }
        }

 
       
      

       
}

      

       

        
     

       
        
      

       
       
     
        

    
    

