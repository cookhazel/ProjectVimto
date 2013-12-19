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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _appointmentDateTime
            // 
            this._appointmentTimeDropDown.FormattingEnabled = true;
            this._appointmentTimeDropDown.Location = new System.Drawing.Point(57, 168);
            this._appointmentTimeDropDown.Name = "_appointmentDateTime";
            this._appointmentTimeDropDown.Size = new System.Drawing.Size(140, 24);
            this._appointmentTimeDropDown.TabIndex = 0;
            this._appointmentTimeDropDown.SelectedIndexChanged += new System.EventHandler(this._appointmentDateTime_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(269, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // AppointmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 410);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this._appointmentTimeDropDown);
            this.Name = "AppointmentUI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _appointmentTimeDropDown;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

