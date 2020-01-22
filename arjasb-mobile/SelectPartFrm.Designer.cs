namespace arjasb_mobile
{
    partial class SelectPartFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPartFrm));
            this.GVTableShowPforD = new System.Windows.Forms.DataGridView();
            this.btnApplyPForD = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelPartName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVTableShowPforD)).BeginInit();
            this.SuspendLayout();
            // 
            // GVTableShowPforD
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableShowPforD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVTableShowPforD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTableShowPforD.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GVTableShowPforD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTableShowPforD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GVTableShowPforD.Location = new System.Drawing.Point(70, 24);
            this.GVTableShowPforD.Name = "GVTableShowPforD";
            this.GVTableShowPforD.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableShowPforD.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GVTableShowPforD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVTableShowPforD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTableShowPforD.Size = new System.Drawing.Size(145, 250);
            this.GVTableShowPforD.StandardTab = true;
            this.GVTableShowPforD.TabIndex = 0;
            // 
            // btnApplyPForD
            // 
            this.btnApplyPForD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplyPForD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyPForD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApplyPForD.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnApplyPForD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApplyPForD.Location = new System.Drawing.Point(12, 190);
            this.btnApplyPForD.Name = "btnApplyPForD";
            this.btnApplyPForD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnApplyPForD.Size = new System.Drawing.Size(52, 29);
            this.btnApplyPForD.TabIndex = 1;
            this.btnApplyPForD.Text = "ثبت";
            this.btnApplyPForD.UseVisualStyleBackColor = false;
            this.btnApplyPForD.Click += new System.EventHandler(this.btnApplyPForD_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(12, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelPartName
            // 
            this.labelPartName.AutoSize = true;
            this.labelPartName.BackColor = System.Drawing.Color.Transparent;
            this.labelPartName.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelPartName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPartName.Location = new System.Drawing.Point(155, 8);
            this.labelPartName.Name = "labelPartName";
            this.labelPartName.Size = new System.Drawing.Size(48, 15);
            this.labelPartName.TabIndex = 3;
            this.labelPartName.Text = "نام قطعات";
            // 
            // SelectPartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(221, 286);
            this.ControlBox = false;
            this.Controls.Add(this.labelPartName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApplyPForD);
            this.Controls.Add(this.GVTableShowPforD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPartFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectPartFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVTableShowPforD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApplyPForD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelPartName;
        public System.Windows.Forms.DataGridView GVTableShowPforD;
    }
}