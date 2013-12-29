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
            System.Windows.Forms.Label medicationLabel;
            this.isExtendibleTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.medicationListBox = new System.Windows.Forms.ListBox();
            medicationLabel = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(medicationLabel);
            this.tabPage2.Controls.Add(this.medicationListBox);
            this.tabPage2.Controls.Add(this.dateTimePicker);
            this.tabPage2.Controls.Add(this.isExtendibleTextBox);
            this.tabPage2.Text = "Medication";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Controls.SetChildIndex(this.isExtendibleTextBox, 0);
            this.tabPage2.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.tabPage2.Controls.SetChildIndex(this.medicationListBox, 0);
            this.tabPage2.Controls.SetChildIndex(medicationLabel, 0);
            // 
            // medicationLabel
            // 
            medicationLabel.AutoSize = true;
            medicationLabel.Location = new System.Drawing.Point(6, 23);
            medicationLabel.Name = "medicationLabel";
            medicationLabel.Size = new System.Drawing.Size(62, 13);
            medicationLabel.TabIndex = 11;
            medicationLabel.Text = "Medication:";
            medicationLabel.Click += new System.EventHandler(this.medicationLabel_Click);
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
            // medicationListBox
            // 
            this.medicationListBox.FormattingEnabled = true;
            this.medicationListBox.Location = new System.Drawing.Point(9, 39);
            this.medicationListBox.Name = "medicationListBox";
            this.medicationListBox.Size = new System.Drawing.Size(184, 95);
            this.medicationListBox.TabIndex = 12;
            this.medicationListBox.SelectedIndexChanged += new System.EventHandler(this.medicationListBox_SelectedIndexChanged);
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 398);
            this.Name = "Medication";
            this.Load += new System.EventHandler(this.Medication_Load_1);
            this.tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox isExtendibleTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MedicationDataset medicationDataset;
        private MedicationDatasetTableAdapters.Medication_DBTableAdapter medication_DBTableAdapter;
        private MedicationDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox medicationListBox;
    }
}