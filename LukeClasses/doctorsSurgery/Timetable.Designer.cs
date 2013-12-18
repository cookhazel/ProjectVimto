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
            this.medicationDataset = new doctorsSurgery.MedicationDataset();
            this.medication_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medication_DBTableAdapter = new doctorsSurgery.MedicationDatasetTableAdapters.Medication_DBTableAdapter();
            this.tableAdapterManager = new doctorsSurgery.MedicationDatasetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDataSet = new doctorsSurgery.TimetableDataSet();
            this.timeTableTableAdapter = new doctorsSurgery.TimetableDataSetTableAdapters.TimeTableTableAdapter();
            this.tableAdapterManager1 = new doctorsSurgery.TimetableDataSetTableAdapters.TableAdapterManager();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new doctorsSurgery.TimetableDataSetTableAdapters.StaffTableAdapter();
            this.timeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Size = new System.Drawing.Size(766, 401);
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabs
            // 
            this.tabs.Size = new System.Drawing.Size(774, 427);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.timeTableDataGridView);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Size = new System.Drawing.Size(766, 401);
            this.tabPage2.Controls.SetChildIndex(this.button1, 0);
            this.tabPage2.Controls.SetChildIndex(this.timeTableDataGridView, 0);
            // 
            // medicationDataset
            // 
            this.medicationDataset.DataSetName = "MedicationDataset";
            this.medicationDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medication_DBBindingSource
            // 
            this.medication_DBBindingSource.DataMember = "Medication_DB";
            this.medication_DBBindingSource.DataSource = this.medicationDataset;
            // 
            // medication_DBTableAdapter
            // 
            this.medication_DBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Medication_DBTableAdapter = this.medication_DBTableAdapter;
            this.tableAdapterManager.UpdateOrder = doctorsSurgery.MedicationDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataMember = "TimeTable";
            this.timeTableBindingSource.DataSource = this.timetableDataSet;
            // 
            // timetableDataSet
            // 
            this.timetableDataSet.DataSetName = "TimetableDataSet";
            this.timetableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.timetableDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // timeTableDataGridView
            // 
            this.timeTableDataGridView.AutoGenerateColumns = false;
            this.timeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.timeTableDataGridView.DataSource = this.timeTableBindingSource;
            this.timeTableDataGridView.Location = new System.Drawing.Point(8, 33);
            this.timeTableDataGridView.Name = "timeTableDataGridView";
            this.timeTableDataGridView.Size = new System.Drawing.Size(750, 219);
            this.timeTableDataGridView.TabIndex = 11;
            this.timeTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timeTableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Monday";
            this.dataGridViewTextBoxColumn2.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tuesday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Wednesday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Thursday";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thursday";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Friday";
            this.dataGridViewTextBoxColumn6.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Saturday";
            this.dataGridViewTextBoxColumn7.HeaderText = "Saturday";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sunday";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sunday";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 423);
            this.Name = "Home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MedicationDataset medicationDataset;
        private System.Windows.Forms.BindingSource medication_DBBindingSource;
        private MedicationDatasetTableAdapters.Medication_DBTableAdapter medication_DBTableAdapter;
        private MedicationDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private TimetableDataSet timetableDataSet;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private TimetableDataSetTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
        private TimetableDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private TimetableDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridView timeTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}