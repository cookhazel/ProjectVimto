namespace MainMenuUI
{
    partial class MainMenu
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnNewApp = new System.Windows.Forms.Button();
            this.btnCancelChangeApp = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(12, 12);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(101, 41);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnNewApp
            // 
            this.btnNewApp.Location = new System.Drawing.Point(119, 12);
            this.btnNewApp.Name = "btnNewApp";
            this.btnNewApp.Size = new System.Drawing.Size(101, 41);
            this.btnNewApp.TabIndex = 1;
            this.btnNewApp.Text = "New Appointment";
            this.btnNewApp.UseVisualStyleBackColor = true;
            // 
            // btnCancelChangeApp
            // 
            this.btnCancelChangeApp.Location = new System.Drawing.Point(226, 12);
            this.btnCancelChangeApp.Name = "btnCancelChangeApp";
            this.btnCancelChangeApp.Size = new System.Drawing.Size(101, 41);
            this.btnCancelChangeApp.TabIndex = 2;
            this.btnCancelChangeApp.Text = "Cancel/Change Appointment";
            this.btnCancelChangeApp.UseVisualStyleBackColor = true;
            this.btnCancelChangeApp.Click += new System.EventHandler(this.btnCancelChangeApp_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 59);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 24);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 93);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCancelChangeApp);
            this.Controls.Add(this.btnNewApp);
            this.Controls.Add(this.btnPatient);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnNewApp;
        private System.Windows.Forms.Button btnCancelChangeApp;
        private System.Windows.Forms.Button btnLogOut;
    }
}

