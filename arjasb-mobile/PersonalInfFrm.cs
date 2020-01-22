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
    public partial class PersonalInfFrm : Form
    {
        public PersonalInfFrm()
        {
            InitializeComponent();
        }
        public string idvalue { get; set; }
        private void PersonalInfFrm_Load(object sender, EventArgs e)
        {
            try
            {
                // int temp;

                var db = new linqDataContext();
                // MessageBox.Show(db.GetMaxIdSrvman().ToString());
                // temp = Convert.ToInt32(db.GetMaxIdSrvman());
                // textBoxSrvId.Text = (++temp).ToString();
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                //  int temp;
                if (txtLName.Text == "" || txtname.Text == "")
                    MessageBox.Show("لطفا موارد خواسته شده را پر نمایید");
                else
                {
                    var db = new linqDataContext();
                    var mainfrmObj = new MainFrm();

                    //  temp = Convert.ToInt32(db.GetMaxIdSrvman());
                    ///stored //Convert.ToInt32(++temp),
                    db.ApplySrvman(txtname.Text, txtLName.Text, CBoxExpert.Text);
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

       
    }
}
