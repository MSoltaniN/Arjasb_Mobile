using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace arjasb_mobile
{
    public partial class OrderAddFrm : Form
    {
        
        public OrderAddFrm()
        {
            InitializeComponent();
        }
        private void OrderAddFrm_Load(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvmanExpert' table. You can move, or remove it, as needed.
                this.showSrvmanExpertTableAdapter.Fill(this.common_DataSet.ShowSrvmanExpert);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceManufacturer' table. You can move, or remove it, as needed.
                this.showDeviceManufacturerTableAdapter.Fill(this.common_DataSet.ShowDeviceManufacturer);


                mtxtDate.Text = PersianDate.GetPersianDate();

                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private Boolean b=true;
       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (b == true)
                {
                    CBSrvMan.Enabled = true;
                    //                // TODO: This line of code loads data into the 'common_DBDataSet.serviceman' table. You can move, or remove it, as needed.
                    this.showSrvmanCategorizingbyExpertTableAdapter.Fill(this.common_DataSet.ShowSrvmanCategorizingbyExpert, CBoxExpert.Text);
                    b = false;

                }
                else
                {
                    CBSrvMan.Enabled = false;
                    this.CBSrvMan.Text = null;
                    b = true;

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        //private enum DayAction
        //{
        //    GettingReadyForWork = 0,
        //    TravelingToWork,
        //    AtWork,
        //    AtLunch,
        //    TravelingFromWork,
        //    RelaxingForFriends,
        //    GettingReadyForBed,
        //    Asleep
        //};
        //private DayAction CurrentState;
        //// Hour property 
        //private int Hour
        //{
        //    get
        //    {
        //        // Return the current hour displayed 
        //        return dtpDate.Value.Hour;
        //    }
        //    set
        //    {
        //        // Set the date using the hour 
        //        // passed to this property 
        //        dtpDate.Value = new DateTime(
        //    DateTime.Now.Year, DateTime.Now.Month,
        //    DateTime.Now.Day, value, 0, 0);
        //        // Set the display text 
        //        lblState.Text = "At " + value + ":00 Matt is ";
        //    }
        //}

        public DataTable dtOrderMenue = new DataTable();
        
       
        

        public string idvalue { get; set; }
      
        ////private void dtpDate_ValueChanged(object sender, EventArgs e)
        ////{
        ////    // Update the hour property 
        ////    this.Hour = dtpDate.Value.Hour;
        ////}




        private void btnapply_Click(object sender, EventArgs e)
        {
            try
            {
                //int counter=1;
                if (CBoxExpert.Text == "" || CBoxMobileManufacturer.Text == "" || CBoxMobileName.Text == "" || txtOwner.Text == "")
                    MessageBox.Show("لطفا موارد خواسته شده را پر نمایید");
                else
                {
                    var db = new linqDataContext();
                    var gvObj = new MainFrm();
                    //while (db.ChechOrderId(counter) != null) { counter++; }
                    //while (gvObj.GVTable.Rows[3].Cells["OrederId"].Value!= null) { counter++; }
                    //store /Convert.ToInt32(txtOrderId.Text),
                    db.ApplyOrderOwnerDeviceTBL(Convert.ToInt32(CBSrvMan.SelectedValue.ToString()), CHBox1.Checked, CHBox2.Checked,
                       CHBox3.Checked, false, mtxtDate.Text, Convert.ToInt32(txtpayment.Text), txtexpr.Text, txtOwner.Text, txtPhoneNumber.Text
                       , CBoxMobileManufacturer.Text, CBoxMobileName.Text);


                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }




        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

      
       







        internal void ShowDialog(int temp)
        {
            throw new NotImplementedException();
        }

        private void CBoxMobileManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.showDeviceNamesbyCategorizingTableAdapter.Fill(this.common_DataSet.ShowDeviceNamesbyCategorizing
                    , CBoxMobileManufacturer.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

     

        
        //private void categorizingMobileNameToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ordertblTableAdapter.CategorizingMobileName(this.general_DBDataSet.ordertbl);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

      

       
       // Declare variable 
     
      

       
    }
}
