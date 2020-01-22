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
    public partial class SelectPartFrm : Form
    {
        public SelectPartFrm()
        {
            InitializeComponent();
        }
        public string orderIdValue { get; set; }
        private void SelectPartFrm_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                GVTableShowPforD.DataSource = db.ShowPartsforDevice();
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void btnApplyPForD_Click(object sender, EventArgs e)
        {
            try
            {
                if (GVTableShowPforD.RowCount > 0)
                {
                    var db = new linqDataContext();
                    var gvObj = new MainFrm();

                    db.SelectPartsforDevice(db.GivePartIdTakePartName(GVTableShowPforD.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(orderIdValue), PersianDate.GetPersianDate());

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
