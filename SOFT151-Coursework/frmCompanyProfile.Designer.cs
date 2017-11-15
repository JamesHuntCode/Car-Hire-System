﻿namespace SOFT151_Coursework
{
    partial class frmCompanyProfile
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lstListCompanyCars = new System.Windows.Forms.ListBox();
            this.lblCompanyId = new System.Windows.Forms.Label();
            this.lblCompanyPostcode = new System.Windows.Forms.Label();
            this.lblCarCount = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnMakeComments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(7, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(209, 31);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lstListCompanyCars
            // 
            this.lstListCompanyCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListCompanyCars.FormattingEnabled = true;
            this.lstListCompanyCars.ItemHeight = 18;
            this.lstListCompanyCars.Location = new System.Drawing.Point(12, 131);
            this.lstListCompanyCars.Name = "lstListCompanyCars";
            this.lstListCompanyCars.Size = new System.Drawing.Size(586, 382);
            this.lstListCompanyCars.TabIndex = 1;
            // 
            // lblCompanyId
            // 
            this.lblCompanyId.AutoSize = true;
            this.lblCompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyId.Location = new System.Drawing.Point(12, 59);
            this.lblCompanyId.Name = "lblCompanyId";
            this.lblCompanyId.Size = new System.Drawing.Size(90, 18);
            this.lblCompanyId.TabIndex = 2;
            this.lblCompanyId.Text = "Company ID";
            // 
            // lblCompanyPostcode
            // 
            this.lblCompanyPostcode.AutoSize = true;
            this.lblCompanyPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPostcode.Location = new System.Drawing.Point(343, 97);
            this.lblCompanyPostcode.Name = "lblCompanyPostcode";
            this.lblCompanyPostcode.Size = new System.Drawing.Size(140, 18);
            this.lblCompanyPostcode.TabIndex = 3;
            this.lblCompanyPostcode.Text = "Company Postcode";
            // 
            // lblCarCount
            // 
            this.lblCarCount.AutoSize = true;
            this.lblCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCount.Location = new System.Drawing.Point(343, 59);
            this.lblCarCount.Name = "lblCarCount";
            this.lblCarCount.Size = new System.Drawing.Size(122, 18);
            this.lblCarCount.TabIndex = 4;
            this.lblCarCount.Text = "Cars on loan (int)";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.Location = new System.Drawing.Point(12, 97);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(130, 18);
            this.lblCompanyAddress.TabIndex = 5;
            this.lblCompanyAddress.Text = "Company Address";
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(160, 519);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(142, 58);
            this.btnUpdateCar.TabIndex = 6;
            this.btnUpdateCar.Text = "Update Selected Car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(308, 519);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(142, 58);
            this.btnDeleteCar.TabIndex = 7;
            this.btnDeleteCar.Text = "Delete Selected Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(12, 519);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(142, 58);
            this.btnAddNewCar.TabIndex = 8;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnMakeComments
            // 
            this.btnMakeComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeComments.Location = new System.Drawing.Point(456, 519);
            this.btnMakeComments.Name = "btnMakeComments";
            this.btnMakeComments.Size = new System.Drawing.Size(142, 58);
            this.btnMakeComments.TabIndex = 9;
            this.btnMakeComments.Text = "Comment On Car";
            this.btnMakeComments.UseVisualStyleBackColor = true;
            this.btnMakeComments.Click += new System.EventHandler(this.btnMakeComments_Click);
            // 
            // frmCompanyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 585);
            this.Controls.Add(this.btnMakeComments);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.lblCarCount);
            this.Controls.Add(this.lblCompanyPostcode);
            this.Controls.Add(this.lblCompanyId);
            this.Controls.Add(this.lstListCompanyCars);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "frmCompanyProfile";
            this.Text = "frmCompanyProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ListBox lstListCompanyCars;
        private System.Windows.Forms.Label lblCompanyId;
        private System.Windows.Forms.Label lblCompanyPostcode;
        private System.Windows.Forms.Label lblCarCount;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnMakeComments;
    }
}