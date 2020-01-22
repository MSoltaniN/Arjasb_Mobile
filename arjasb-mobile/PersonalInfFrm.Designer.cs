namespace arjasb_mobile
{
    partial class PersonalInfFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfFrm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelSkill = new System.Windows.Forms.Label();
            this.CBoxExpert = new System.Windows.Forms.ComboBox();
            this.labelSrvId = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtSrvMan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(217, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(18, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "نام";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.BackColor = System.Drawing.Color.Transparent;
            this.labelLname.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLname.Location = new System.Drawing.Point(203, 103);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(54, 15);
            this.labelLname.TabIndex = 1;
            this.labelLname.Text = "نام خانوادگی";
            // 
            // labelSkill
            // 
            this.labelSkill.AutoSize = true;
            this.labelSkill.BackColor = System.Drawing.Color.Transparent;
            this.labelSkill.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelSkill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSkill.Location = new System.Drawing.Point(217, 158);
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(34, 15);
            this.labelSkill.TabIndex = 2;
            this.labelSkill.Text = "تخصص";
            // 
            // CBoxExpert
            // 
            this.CBoxExpert.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CBoxExpert.FormattingEnabled = true;
            this.CBoxExpert.Location = new System.Drawing.Point(70, 150);
            this.CBoxExpert.Name = "CBoxExpert";
            this.CBoxExpert.Size = new System.Drawing.Size(121, 21);
            this.CBoxExpert.TabIndex = 3;
            // 
            // labelSrvId
            // 
            this.labelSrvId.AutoSize = true;
            this.labelSrvId.BackColor = System.Drawing.Color.Transparent;
            this.labelSrvId.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelSrvId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSrvId.Location = new System.Drawing.Point(52, 15);
            this.labelSrvId.Name = "labelSrvId";
            this.labelSrvId.Size = new System.Drawing.Size(63, 15);
            this.labelSrvId.TabIndex = 6;
            this.labelSrvId.Text = "شماره کارمندی";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApply.Location = new System.Drawing.Point(12, 190);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "ثبت";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("B Elham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(12, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtname.Location = new System.Drawing.Point(81, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLName.Location = new System.Drawing.Point(81, 103);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 21);
            this.txtLName.TabIndex = 2;
            // 
            // txtSrvMan
            // 
            this.txtSrvMan.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSrvMan.Location = new System.Drawing.Point(15, 12);
            this.txtSrvMan.Name = "txtSrvMan";
            this.txtSrvMan.Size = new System.Drawing.Size(29, 21);
            this.txtSrvMan.TabIndex = 7;
            // 
            // PersonalInfFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.txtSrvMan);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.labelSrvId);
            this.Controls.Add(this.CBoxExpert);
            this.Controls.Add(this.labelSkill);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalInfFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PersonalInfFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.ComboBox CBoxExpert;
        private System.Windows.Forms.Label labelSrvId;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtLName;
        public System.Windows.Forms.TextBox txtSrvMan;
    }
}