namespace doctorsSurgery
{
    partial class Medication
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
            this.MedicationList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isExtendibleTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker);
            this.tabPage2.Controls.Add(this.isExtendibleTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.MedicationList);
            this.tabPage2.Text = "Medication";
            this.tabPage2.Controls.SetChildIndex(this.MedicationList, 0);
            this.tabPage2.Controls.SetChildIndex(this.label1, 0);
            this.tabPage2.Controls.SetChildIndex(this.isExtendibleTextBox, 0);
            this.tabPage2.Controls.SetChildIndex(this.dateTimePicker, 0);
            // 
            // MedicationList
            // 
            this.MedicationList.FormattingEnabled = true;
            this.MedicationList.Location = new System.Drawing.Point(8, 39);
            this.MedicationList.Name = "MedicationList";
            this.MedicationList.Size = new System.Drawing.Size(184, 277);
            this.MedicationList.TabIndex = 8;
            this.MedicationList.SelectedIndexChanged += new System.EventHandler(this.MedicationList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medication";
            // 
            // isExtendibleTextBox
            // 
            this.isExtendibleTextBox.Location = new System.Drawing.Point(199, 39);
            this.isExtendibleTextBox.Name = "isExtendibleTextBox";
            this.isExtendibleTextBox.Size = new System.Drawing.Size(100, 20);
            this.isExtendibleTextBox.TabIndex = 10;
            this.isExtendibleTextBox.TextChanged += new System.EventHandler(this.isExtendibleTextBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(306, 39);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 398);
            this.Name = "Medication";
            this.tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox isExtendibleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MedicationList;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}