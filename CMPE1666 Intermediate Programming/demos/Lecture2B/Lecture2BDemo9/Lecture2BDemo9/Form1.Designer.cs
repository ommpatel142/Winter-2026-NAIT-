namespace Lecture2BDemo9
{
    partial class Form1
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
            this.UI_TaxRate_Gpb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_ItemPrice_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Output_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_5_Rdb = new System.Windows.Forms.RadioButton();
            this.UI_7_Rdb = new System.Windows.Forms.RadioButton();
            this.UI_10_Rdb = new System.Windows.Forms.RadioButton();
            this.UI_TaxRate_Gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_TaxRate_Gpb
            // 
            this.UI_TaxRate_Gpb.Controls.Add(this.UI_10_Rdb);
            this.UI_TaxRate_Gpb.Controls.Add(this.UI_7_Rdb);
            this.UI_TaxRate_Gpb.Controls.Add(this.UI_5_Rdb);
            this.UI_TaxRate_Gpb.Location = new System.Drawing.Point(33, 60);
            this.UI_TaxRate_Gpb.Name = "UI_TaxRate_Gpb";
            this.UI_TaxRate_Gpb.Size = new System.Drawing.Size(118, 100);
            this.UI_TaxRate_Gpb.TabIndex = 0;
            this.UI_TaxRate_Gpb.TabStop = false;
            this.UI_TaxRate_Gpb.Text = "Tax Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Price:";
            // 
            // UI_ItemPrice_Tbx
            // 
            this.UI_ItemPrice_Tbx.Location = new System.Drawing.Point(239, 82);
            this.UI_ItemPrice_Tbx.Name = "UI_ItemPrice_Tbx";
            this.UI_ItemPrice_Tbx.Size = new System.Drawing.Size(116, 20);
            this.UI_ItemPrice_Tbx.TabIndex = 2;
            // 
            // UI_Output_Tbx
            // 
            this.UI_Output_Tbx.Location = new System.Drawing.Point(220, 166);
            this.UI_Output_Tbx.Name = "UI_Output_Tbx";
            this.UI_Output_Tbx.ReadOnly = true;
            this.UI_Output_Tbx.Size = new System.Drawing.Size(116, 20);
            this.UI_Output_Tbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Cost (Including Tax):";
            // 
            // UI_5_Rdb
            // 
            this.UI_5_Rdb.AutoSize = true;
            this.UI_5_Rdb.Location = new System.Drawing.Point(7, 20);
            this.UI_5_Rdb.Name = "UI_5_Rdb";
            this.UI_5_Rdb.Size = new System.Drawing.Size(39, 17);
            this.UI_5_Rdb.TabIndex = 0;
            this.UI_5_Rdb.TabStop = true;
            this.UI_5_Rdb.Text = "5%";
            this.UI_5_Rdb.UseVisualStyleBackColor = true;
            // 
            // UI_7_Rdb
            // 
            this.UI_7_Rdb.AutoSize = true;
            this.UI_7_Rdb.Location = new System.Drawing.Point(7, 44);
            this.UI_7_Rdb.Name = "UI_7_Rdb";
            this.UI_7_Rdb.Size = new System.Drawing.Size(39, 17);
            this.UI_7_Rdb.TabIndex = 1;
            this.UI_7_Rdb.TabStop = true;
            this.UI_7_Rdb.Text = "7%";
            this.UI_7_Rdb.UseVisualStyleBackColor = true;
            // 
            // UI_10_Rdb
            // 
            this.UI_10_Rdb.AutoSize = true;
            this.UI_10_Rdb.Location = new System.Drawing.Point(7, 68);
            this.UI_10_Rdb.Name = "UI_10_Rdb";
            this.UI_10_Rdb.Size = new System.Drawing.Size(45, 17);
            this.UI_10_Rdb.TabIndex = 2;
            this.UI_10_Rdb.TabStop = true;
            this.UI_10_Rdb.Text = "10%";
            this.UI_10_Rdb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_Output_Tbx);
            this.Controls.Add(this.UI_ItemPrice_Tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_TaxRate_Gpb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_TaxRate_Gpb.ResumeLayout(false);
            this.UI_TaxRate_Gpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_TaxRate_Gpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_ItemPrice_Tbx;
        private System.Windows.Forms.TextBox UI_Output_Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton UI_10_Rdb;
        private System.Windows.Forms.RadioButton UI_7_Rdb;
        private System.Windows.Forms.RadioButton UI_5_Rdb;
    }
}

