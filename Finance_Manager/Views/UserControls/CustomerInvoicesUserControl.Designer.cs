﻿namespace Finance_Manager
{
    partial class CustomerInvoicesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateCustomerInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Customer Invoice";
            // 
            // btnCreateCustomerInvoice
            // 
            this.btnCreateCustomerInvoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateCustomerInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomerInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateCustomerInvoice.Location = new System.Drawing.Point(687, 20);
            this.btnCreateCustomerInvoice.Name = "btnCreateCustomerInvoice";
            this.btnCreateCustomerInvoice.Size = new System.Drawing.Size(168, 41);
            this.btnCreateCustomerInvoice.TabIndex = 3;
            this.btnCreateCustomerInvoice.Text = "+  New Customer";
            this.btnCreateCustomerInvoice.UseVisualStyleBackColor = false;
            // 
            // CustomerInvoicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateCustomerInvoice);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInvoicesUserControl";
            this.Size = new System.Drawing.Size(873, 503);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateCustomerInvoice;
    }
}
