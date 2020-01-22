namespace arjasb_mobile
{
    partial class PersonalInfDelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfDelFrm));
            this.GVTableDelSrv = new System.Windows.Forms.DataGridView();
            this.btnDelSrv = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVTableDelSrv)).BeginInit();
            this.SuspendLayout();
            // 
            // GVTableDelSrv
            // 
            this.GVTableDelSrv.AllowUserToAddRows = false;
            this.GVTableDelSrv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableDelSrv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVTableDelSrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTableDelSrv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GVTableDelSrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTableDelSrv.Location = new System.Drawing.Point(82, 22);
            this.GVTableDelSrv.Name = "GVTableDelSrv";
            this.GVTableDelSrv.ReadOnly = true;
            this.GVTableDelSrv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GVTableDelSrv.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.GVTableDelSrv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GVTableDelSrv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVTableDelSrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTableDelSrv.Size = new System.Drawing.Size(240, 271);
            this.GVTableDelSrv.StandardTab = true;
            this.GVTableDelSrv.TabIndex = 0;
            // 
            // btnDelSrv
            // 
            this.btnDelSrv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelSrv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelSrv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelSrv.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelSrv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelSrv.Location = new System.Drawing.Point(12, 219);
            this.btnDelSrv.Name = "btnDelSrv";
            this.btnDelSrv.Size = new System.Drawing.Size(64, 23);
            this.btnDelSrv.TabIndex = 1;
            this.btnDelSrv.Text = "حذف";
            this.btnDelSrv.UseVisualStyleBackColor = false;
            this.btnDelSrv.Click += new System.EventHandler(this.btnDelSrv_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(12, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PersonalInfDelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelSrv);
            this.Controls.Add(this.GVTableDelSrv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalInfDelFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PersonalInfDelFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVTableDelSrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVTableDelSrv;
        private System.Windows.Forms.Button btnDelSrv;
        private System.Windows.Forms.Button btnClose;
    }
}