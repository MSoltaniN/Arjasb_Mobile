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
    public partial class PersonalInfDelFrm : Form
    {
        public PersonalInfDelFrm()
        {
            InitializeComponent();
        }

        private void PersonalInfDelFrm_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new linqDataContext();
                GVTableDelSrv.DataSource = db.ShowSrvman();
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnDelSrv_Click(object sender, EventArgs e)
        {
            try
            {
                if (GVTableDelSrv.RowCount > 0)
                {
                    var db = new linqDataContext();
                    db.DelSrvman(Convert.ToInt32(GVTableDelSrv.CurrentRow.Cells[0].Value));
                    GVTableDelSrv.DataSource = db.ShowSrvman();
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
