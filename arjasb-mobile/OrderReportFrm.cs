using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace arjasb_mobile
{
    public partial class OrderReportFrm : Form
    {
        public OrderReportFrm()
        {
            InitializeComponent();
        }
        private void OrderReportFrm_Load(object sender, EventArgs e)
        {

        }

        public DataTable GVvalue { get; set; }

        public int NumberRowOfGridview { get; set; }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

               // var rd = new ReportDocument();
               // rd.FileName = "crystal files\\OrderReport.rpt";
               //// var MainFrmObj = new MainFrm();
               // var db = new linqDataContext();

               // //  rd.SetDataSource(MainFrmObj.common_DBDataSet.ordertbl.DataSet);

               // rd.SetDataSource(db.ordertbls);

               // crystalReportViewer.ReportSource = rd;
               // crystalReportViewer.Show();

              //  NumberRowOfGridview
                parametersFields = new CrystalDecisions.Shared.ParameterFields();
                parameterField = new CrystalDecisions.Shared.ParameterField();
                parameterValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
                parameterField.Name = "NumberRowOfGridview";
                parameterValue.Value = NumberRowOfGridview;
                parameterField.CurrentValues.Add(parameterValue);
                parametersFields.Add(parameterField);
                crystalReportViewer.ParameterFieldInfo = parametersFields;
                this.crystalReportViewer.ReportSource = System.IO.Directory.GetCurrentDirectory() + "\\OrderReport.rpt";
              //  this.crystalReportViewer.RefreshReport();
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

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {

        }

      
      
       
    }
}
