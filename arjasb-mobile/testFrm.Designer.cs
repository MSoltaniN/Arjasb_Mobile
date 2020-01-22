namespace arjasb_mobile
{
    partial class testFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testFrm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ordertblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.CBoxReportSubItems = new System.Windows.Forms.ComboBox();
            this.CBoxReportItems = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Samsung-S8000-Jet - Copy.jpg");
            this.imageList1.Images.SetKeyName(1, "a.jpg");
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(354, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "انتخاب نوع گزارش";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(335, 357);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(76, 26);
            this.btnViewReport.TabIndex = 7;
            this.btnViewReport.Text = "نمایش گزارش";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // CBoxReportSubItems
            // 
            this.CBoxReportSubItems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CBoxReportSubItems.FormattingEnabled = true;
            this.CBoxReportSubItems.Location = new System.Drawing.Point(304, 173);
            this.CBoxReportSubItems.Name = "CBoxReportSubItems";
            this.CBoxReportSubItems.Size = new System.Drawing.Size(144, 21);
            this.CBoxReportSubItems.TabIndex = 6;
            // 
            // CBoxReportItems
            // 
            this.CBoxReportItems.FormattingEnabled = true;
            this.CBoxReportItems.Items.AddRange(new object[] {
            "سفارش",
            "قطعه",
            "درآمد"});
            this.CBoxReportItems.Location = new System.Drawing.Point(304, 121);
            this.CBoxReportItems.Name = "CBoxReportItems";
            this.CBoxReportItems.Size = new System.Drawing.Size(144, 21);
            this.CBoxReportItems.TabIndex = 5;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1008, 511);
            this.crystalReportViewer1.TabIndex = 9;
            // 
            // testFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 526);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.CBoxReportSubItems);
            this.Controls.Add(this.CBoxReportItems);
            this.Name = "testFrm";
            this.Text = "testFrm";
            this.Load += new System.EventHandler(this.testFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Timer timer1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource ordertblBindingSource;
        private System.Windows.Forms.BindingSource ordertblBindingSource1;
        private System.Windows.Forms.BindingSource ordertblBindingSource2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.ComboBox CBoxReportSubItems;
        private System.Windows.Forms.ComboBox CBoxReportItems;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}