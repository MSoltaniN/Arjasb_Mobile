using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arjasb_mobile
{
    public partial class OrderEditFrm : Form
    {
        public OrderEditFrm()
        {
            InitializeComponent();
        }

        public string idvalue { get; set; }
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
                    //var gvObj = new MainFrm();
                    //while (db.ChechOrderId(counter) != null) { counter++; }
                    //while (gvObj.GVTable.Rows[3].Cells["OrederId"].Value!= null) { counter++; }
                    //store /
                    db.EditOrder(Convert.ToInt32(txtOrderId.Text),
                        Convert.ToInt32(CBSrvMan.SelectedValue.ToString()),
                        CHBox1.Checked,
                        CHBox2.Checked,
                       CHBox3.Checked,
                        mtxtDate.Text,
                        Convert.ToInt32(txtpayment.Text),
                        txtexpr.Text,
                       txtOwner.Text,
                       txtPhoneNumber.Text,
                       CBoxMobileManufacturer.Text,
                        CBoxMobileName.Text);


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
          this.Close();
        }

      

        private void OrderEditFrm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        
        private Boolean b = true;
      
        private void checkBoxSrvManId_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (b == true)
                {
                    CBSrvMan.Enabled = true;
                    // TODO: This line of code loads data into the 'common_DBDataSet.serviceman' table. You can move, or remove it, as needed.
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

        private void OrderEditFrm_Load_1(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'common_DataSet.ShowSrvmanExpert' table. You can move, or remove it, as needed.
                this.showSrvmanExpertTableAdapter.Fill(this.common_DataSet.ShowSrvmanExpert);
                // TODO: This line of code loads data into the 'common_DataSet.ShowDeviceNames' table. You can move, or remove it, as needed.
                this.showDeviceManufacturerTableAdapter.Fill(this.common_DataSet.ShowDeviceManufacturer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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



        }






    }

