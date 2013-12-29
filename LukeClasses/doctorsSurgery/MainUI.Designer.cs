namespace doctorsSurgery
{
    partial class MainUI
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(0, -1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(678, 396);
            this.tabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "4";
            this.tabPage1.Text = "hometab";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "3";
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.btSubmit);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Location = new System.Drawing.Point(3, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 34);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(423, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSubmit.Enabled = false;
            this.btSubmit.Location = new System.Drawing.Point(504, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBack.Location = new System.Drawing.Point(585, 4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 398);
            this.Controls.Add(this.tabs);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabs;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button1;
    }
}

