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
    public partial class PartEditFrm : Form
    {
        public PartEditFrm()
        {
            InitializeComponent();
        }
        private void PartEditFrm_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public string idvalue { get; set; }
       
        private void btnApply_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (txtAlarm.Text == "" || txtName.Text == "" || txtPartId.Text == "" || txtPrice.Text == "")
                //    MessageBox.Show("لطفا موارد خواسته شده را پر نمایید");
                //else
                //{
                var db = new linqDataContext();
                db.EditPart(Convert.ToInt32(txtPartId.Text), txtPartName.Text, Convert.ToInt32(txtPartPrice.Text), Convert.ToInt32(txtPartAlert.Text));
                var gvobj = new MainFrm();
                gvobj.GVTablePart.DataSource = db.ShowParts();
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //}
        }
       

       
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPartId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartAlert_TextChanged(object sender, EventArgs e)
        {

        }

      

      
    }
}
