namespace arjasb_mobile
{
    partial class SelectDevicesOfSrvman
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDevicesOfSrvman));
            this.GVTableNotSelectedDevice = new System.Windows.Forms.DataGridView();
            this.GVTableSelectedDevice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.btnRtoL = new System.Windows.Forms.Button();
            this.btnLtoR = new System.Windows.Forms.Button();
            this.btnColse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVTableNotSelectedDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTableSelectedDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // GVTableNotSelectedDevice
            // 
            this.GVTableNotSelectedDevice.AllowUserToAddRows = false;
            this.GVTableNotSelectedDevice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableNotSelectedDevice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVTableNotSelectedDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTableNotSelectedDevice.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GVTableNotSelectedDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTableNotSelectedDevice.Location = new System.Drawing.Point(359, 43);
            this.GVTableNotSelectedDevice.Name = "GVTableNotSelectedDevice";
            this.GVTableNotSelectedDevice.ReadOnly = true;
            this.GVTableNotSelectedDevice.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableNotSelectedDevice.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GVTableNotSelectedDevice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVTableNotSelectedDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTableNotSelectedDevice.Size = new System.Drawing.Size(218, 350);
            this.GVTableNotSelectedDevice.StandardTab = true;
            this.GVTableNotSelectedDevice.TabIndex = 0;
            // 
            // GVTableSelectedDevice
            // 
            this.GVTableSelectedDevice.AllowUserToAddRows = false;
            this.GVTableSelectedDevice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableSelectedDevice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GVTableSelectedDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTableSelectedDevice.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GVTableSelectedDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTableSelectedDevice.Location = new System.Drawing.Point(12, 43);
            this.GVTableSelectedDevice.Name = "GVTableSelectedDevice";
            this.GVTableSelectedDevice.ReadOnly = true;
            this.GVTableSelectedDevice.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableSelectedDevice.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GVTableSelectedDevice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVTableSelectedDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTableSelectedDevice.Size = new System.Drawing.Size(218, 350);
            this.GVTableSelectedDevice.StandardTab = true;
            this.GVTableSelectedDevice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(431, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "گوشی های تعمیر نشده";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.Color.Transparent;
            this.lable2.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lable2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lable2.Location = new System.Drawing.Point(39, 13);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(74, 15);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "گوشی های انتخابی";
            // 
            // btnRtoL
            // 
            this.btnRtoL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRtoL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRtoL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRtoL.Location = new System.Drawing.Point(269, 151);
            this.btnRtoL.Name = "btnRtoL";
            this.btnRtoL.Size = new System.Drawing.Size(50, 23);
            this.btnRtoL.TabIndex = 1;
            this.btnRtoL.Text = "->";
            this.btnRtoL.UseVisualStyleBackColor = false;
            this.btnRtoL.Click += new System.EventHandler(this.btnRtoL_Click);
            // 
            // btnLtoR
            // 
            this.btnLtoR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLtoR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLtoR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLtoR.Location = new System.Drawing.Point(269, 180);
            this.btnLtoR.Name = "btnLtoR";
            this.btnLtoR.Size = new System.Drawing.Size(50, 23);
            this.btnLtoR.TabIndex = 3;
            this.btnLtoR.Text = "<-";
            this.btnLtoR.UseVisualStyleBackColor = false;
            this.btnLtoR.Click += new System.EventHandler(this.btnLtoR_Click);
            // 
            // btnColse
            // 
            this.btnColse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColse.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnColse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColse.Location = new System.Drawing.Point(257, 350);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(75, 23);
            this.btnColse.TabIndex = 4;
            this.btnColse.Text = "خروج";
            this.btnColse.UseVisualStyleBackColor = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // SelectDevicesOfSrvman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 405);
            this.ControlBox = false;
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.btnLtoR);
            this.Controls.Add(this.btnRtoL);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GVTableSelectedDevice);
            this.Controls.Add(this.GVTableNotSelectedDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDevicesOfSrvman";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectDevicesOfSrvman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVTableNotSelectedDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTableSelectedDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVTableNotSelectedDevice;
        private System.Windows.Forms.DataGridView GVTableSelectedDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Button btnRtoL;
        private System.Windows.Forms.Button btnLtoR;
        private System.Windows.Forms.Button btnColse;
    }
}