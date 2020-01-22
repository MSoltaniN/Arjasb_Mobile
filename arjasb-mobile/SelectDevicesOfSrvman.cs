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
    public partial class SelectDevicesOfSrvman : Form
    {
        public SelectDevicesOfSrvman()
        {
            InitializeComponent();
        }
        public string idvalue { get; set; }
        private void SelectDevicesOfSrvman_Load(object sender, EventArgs e)
        {
            try
            {

                //label1.Text = idvalue;
                //  var mainObj = new MainFrm();
                var db = new linqDataContext();
                GVTableNotSelectedDevice.DataSource = db.ShowDeviceNSofSrvman();
                GVTableSelectedDevice.DataSource = db.ShowDeviceSofSrvman(Convert.ToInt32(idvalue));
                ////Convert.ToInt32(mainObj.txtSelectSrvman.Text)

                this.FormBorderStyle = FormBorderStyle.FixedDialog;

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
                if (GVTableNotSelectedDevice.RowCount > 0)
                {
                    var mainObj = new MainFrm();
                    var db = new linqDataContext();

                    db.ChangeDeviceSrvMan(Convert.ToInt32(GVTableNotSelectedDevice.CurrentRow.Cells[0].Value), Convert.ToInt32(idvalue));

                    GVTableNotSelectedDevice.DataSource = db.ShowDeviceNSofSrvman();
                    GVTableSelectedDevice.DataSource = db.ShowDeviceSofSrvman(Convert.ToInt32(idvalue));
                }
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
                if (GVTableSelectedDevice.RowCount > 0)
                {
                    var mainObj = new MainFrm();
                    var db = new linqDataContext();

                    db.FreeDeviceSrvMan(Convert.ToInt32(GVTableSelectedDevice.CurrentRow.Cells[0].Value), null);

                    GVTableNotSelectedDevice.DataSource = db.ShowDeviceNSofSrvman();
                    GVTableSelectedDevice.DataSource = db.ShowDeviceSofSrvman(Convert.ToInt32(idvalue));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                var db = new linqDataContext();
                var MainFrmObj = new MainFrm();
                MainFrmObj.GVTableSrv1.DataSource = db.ShowDeviceReapairing(Convert.ToInt32(MainFrmObj.txtSelectSrvman.SelectedValue));
                MainFrmObj.GVTableSrv2.DataSource = db.ShowDeviceRepaired(Convert.ToInt32(MainFrmObj.txtSelectSrvman.SelectedValue));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



       
       
    }
}
