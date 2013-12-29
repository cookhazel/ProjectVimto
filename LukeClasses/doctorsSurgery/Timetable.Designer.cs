namespace doctorsSurgery
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.timeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDataSet = new doctorsSurgery.TimetableDataSet();
            this.staffDataset = new doctorsSurgery.StaffDataset();
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new doctorsSurgery.StaffDatasetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager2 = new doctorsSurgery.StaffDatasetTableAdapters.TableAdapterManager();
            this.timeTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTimeTableID60A75C0FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableTableAdapter = new doctorsSurgery.TimetableDataSetTableAdapters.TimeTableTableAdapter();
            this.tableAdapterManager1 = new doctorsSurgery.TimetableDataSetTableAdapters.TableAdapterManager();
            this.staffTableAdapter = new doctorsSurgery.TimetableDataSetTableAdapters.StaffTableAdapter();
            this.timeTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTimeTableID60A75C0FBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Size = new System.Drawing.Size(1076, 427);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Size = new System.Drawing.Size(1068, 401);
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            this.tabPage1.Controls.SetChildIndex(this.button1, 0);
            this.tabPage1.Controls.SetChildIndex(this.button2, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Size = new System.Drawing.Size(1068, 401);
            this.tabPage2.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // timeTableBindingSource1
            // 
            this.timeTableBindingSource1.DataMember = "FK__TimeTable__ID__60A75C0F";
            this.timeTableBindingSource1.DataSource = this.staffBindingSource;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.timetableDataSet;
            // 
            // timetableDataSet
            // 
            this.timetableDataSet.DataSetName = "TimetableDataSet";
            this.timetableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffDataset
            // 
            this.staffDataset.DataSetName = "StaffDataset";
            this.staffDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "Staff";
            this.staffBindingSource2.DataSource = this.staffDataset;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.StaffTableAdapter = this.staffTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = doctorsSurgery.StaffDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timeTableBindingSource3
            // 
            this.timeTableBindingSource3.DataMember = "TimeTable";
            this.timeTableBindingSource3.DataSource = this.timetableDataSetBindingSource;
            // 
            // timetableDataSetBindingSource
            // 
            this.timetableDataSetBindingSource.DataSource = this.timetableDataSet;
            this.timetableDataSetBindingSource.Position = 0;
            // 
            // fKTimeTableID60A75C0FBindingSource
            // 
            this.fKTimeTableID60A75C0FBindingSource.DataMember = "FK__TimeTable__ID__60A75C0F";
            this.fKTimeTableID60A75C0FBindingSource.DataSource = this.staffBindingSource;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.timetableDataSet;
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataMember = "TimeTable";
            this.timeTableBindingSource.DataSource = this.timetableDataSet;
            // 
            // timeTableTableAdapter
            // 
            this.timeTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StaffTableAdapter = null;
            this.tableAdapterManager1.TimeTableTableAdapter = this.timeTableTableAdapter;
            this.tableAdapterManager1.UpdateOrder = doctorsSurgery.TimetableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // timeTableBindingSource2
            // 
            this.timeTableBindingSource2.DataMember = "TimeTable";
            this.timeTableBindingSource2.DataSource = this.timetableDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 299);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 423);
            this.Name = "Home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTimeTableID60A75C0FBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TimetableDataSet timetableDataSet;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private TimetableDataSetTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
        private TimetableDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private TimetableDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource timeTableBindingSource1;
        private System.Windows.Forms.BindingSource timeTableBindingSource2;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.BindingSource timetableDataSetBindingSource;
        private StaffDataset staffDataset;
        private System.Windows.Forms.BindingSource staffBindingSource2;
        private StaffDatasetTableAdapters.StaffTableAdapter staffTableAdapter1;
        private StaffDatasetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingSource fKTimeTableID60A75C0FBindingSource;
        private System.Windows.Forms.BindingSource timeTableBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}