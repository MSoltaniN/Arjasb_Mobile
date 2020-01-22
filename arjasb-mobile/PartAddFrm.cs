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
    public partial class PartAddFrm : Form
    {
        public PartAddFrm()
        {
            InitializeComponent();
        }
        private void PartAddFrm_Load(object sender, EventArgs e)
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
                //if (txtPartAlert.Text == "" || txtPartName.Text == "" || txtPartPrice.Text == "")
                //    MessageBox.Show("لطفا موارد خواسته شده را پر نمایید");
                //else
                //{
                var db = new linqDataContext();

                //stored//int.Parse(txtPartId.Text),

                db.ApplyPart(txtPartName.Text.ToString(), Convert.ToInt32(txtPartPrice.Text), Convert.ToInt32(txtPartAlert.Text));
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

       
        

        

     

       
    }
}
