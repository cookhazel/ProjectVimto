namespace ClassesSE
{
    partial class AppointmentUI
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
            this._appointmentTimeDropDown = new System.Windows.Forms.ComboBox();
            this._doctorNurseDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _appointmentTimeDropDown
            // 
            this._appointmentTimeDropDown.FormattingEnabled = true;
            this._appointmentTimeDropDown.Location = new System.Drawing.Point(57, 167);
            this._appointmentTimeDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._appointmentTimeDropDown.Name = "_appointmentTimeDropDown";
            this._appointmentTimeDropDown.Size = new System.Drawing.Size(140, 24);
            this._appointmentTimeDropDown.TabIndex = 0;
            this._appointmentTimeDropDown.SelectedIndexChanged += new System.EventHandler(this._appointmentDateTime_SelectedIndexChanged);
            // 
            // _doctorNurseDropDown
            // 
            this._doctorNurseDropDown.FormattingEnabled = true;
            this._doctorNurseDropDown.Location = new System.Drawing.Point(269, 167);
            this._doctorNurseDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._doctorNurseDropDown.Name = "_doctorNurseDropDown";
            this._doctorNurseDropDown.Size = new System.Drawing.Size(135, 24);
            this._doctorNurseDropDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Doctor/Nurse";
            // 
            // submitAppointment
            // 
            this.submitAppointment.Location = new System.Drawing.Point(272, 314);
            this.submitAppointment.Name = "submitAppointment";
            this.submitAppointment.Size = new System.Drawing.Size(157, 31);
            this.submitAppointment.TabIndex = 4;
            this.submitAppointment.Text = "Make Appointment";
            this.submitAppointment.UseVisualStyleBackColor = true;
            this.submitAppointment.Click += new System.EventHandler(this.submitAppointment_Click);
            // 
            // AppointmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 410);
            this.Controls.Add(this.submitAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._doctorNurseDropDown);
            this.Controls.Add(this._appointmentTimeDropDown);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentUI";
            this.Text = "Make Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _appointmentTimeDropDown;
        private System.Windows.Forms.ComboBox _doctorNurseDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitAppointment;
    }
}

