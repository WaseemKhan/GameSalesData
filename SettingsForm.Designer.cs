namespace GameSalesData
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.platformsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameSalesDataDataSet = new GameSalesData.Database.GameSalesDataDataSet();
            this.chartboostAppsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adMobAppsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateChartboost = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.applicationsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.ApplicationsTableAdapter();
            this.platformsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.PlatformsTableAdapter();
            this.chartboostAppsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.ChartboostAppsTableAdapter();
            this.btnUpdateAdMob = new System.Windows.Forms.Button();
            this.adMobAppsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.AdMobAppsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chartboostIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.adMobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mobFoxIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appAnnieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSalesDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartboostAppsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adMobAppsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabApplications);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.dataGridView1);
            this.tabApplications.Location = new System.Drawing.Point(4, 22);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(982, 474);
            this.tabApplications.TabIndex = 0;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.applicationNameDataGridViewTextBoxColumn,
            this.platformIDDataGridViewTextBoxColumn,
            this.chartboostIDDataGridViewTextBoxColumn,
            this.adMobIDDataGridViewTextBoxColumn,
            this.mobFoxIDDataGridViewTextBoxColumn,
            this.appAnnieIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applicationsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // platformsBindingSource
            // 
            this.platformsBindingSource.DataMember = "Platforms";
            this.platformsBindingSource.DataSource = this.gameSalesDataDataSet;
            // 
            // gameSalesDataDataSet
            // 
            this.gameSalesDataDataSet.DataSetName = "GameSalesDataDataSet";
            this.gameSalesDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartboostAppsBindingSource
            // 
            this.chartboostAppsBindingSource.DataMember = "ChartboostApps";
            this.chartboostAppsBindingSource.DataSource = this.gameSalesDataDataSet;
            // 
            // adMobAppsBindingSource
            // 
            this.adMobAppsBindingSource.DataMember = "AdMobApps";
            this.adMobAppsBindingSource.DataSource = this.gameSalesDataDataSet;
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.gameSalesDataDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateChartboost
            // 
            this.btnUpdateChartboost.Location = new System.Drawing.Point(996, 25);
            this.btnUpdateChartboost.Name = "btnUpdateChartboost";
            this.btnUpdateChartboost.Size = new System.Drawing.Size(150, 31);
            this.btnUpdateChartboost.TabIndex = 1;
            this.btnUpdateChartboost.Text = "Update Chartboost";
            this.btnUpdateChartboost.UseVisualStyleBackColor = true;
            this.btnUpdateChartboost.Click += new System.EventHandler(this.btnUpdateChartboost_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(996, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // platformsTableAdapter
            // 
            this.platformsTableAdapter.ClearBeforeFill = true;
            // 
            // chartboostAppsTableAdapter
            // 
            this.chartboostAppsTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateAdMob
            // 
            this.btnUpdateAdMob.Location = new System.Drawing.Point(996, 71);
            this.btnUpdateAdMob.Name = "btnUpdateAdMob";
            this.btnUpdateAdMob.Size = new System.Drawing.Size(150, 31);
            this.btnUpdateAdMob.TabIndex = 3;
            this.btnUpdateAdMob.Text = "Update Admob";
            this.btnUpdateAdMob.UseVisualStyleBackColor = true;
            this.btnUpdateAdMob.Click += new System.EventHandler(this.btnUpdateAdMob_Click);
            // 
            // adMobAppsTableAdapter
            // 
            this.adMobAppsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            this.applicationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            this.applicationNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // platformIDDataGridViewTextBoxColumn
            // 
            this.platformIDDataGridViewTextBoxColumn.DataPropertyName = "PlatformID";
            this.platformIDDataGridViewTextBoxColumn.DataSource = this.platformsBindingSource;
            this.platformIDDataGridViewTextBoxColumn.DisplayMember = "PlatformName";
            this.platformIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.platformIDDataGridViewTextBoxColumn.HeaderText = "PlatformID";
            this.platformIDDataGridViewTextBoxColumn.Name = "platformIDDataGridViewTextBoxColumn";
            this.platformIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.platformIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.platformIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // chartboostIDDataGridViewTextBoxColumn
            // 
            this.chartboostIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chartboostIDDataGridViewTextBoxColumn.DataPropertyName = "ChartboostID";
            this.chartboostIDDataGridViewTextBoxColumn.DataSource = this.chartboostAppsBindingSource;
            this.chartboostIDDataGridViewTextBoxColumn.DisplayMember = "DisplayName";
            this.chartboostIDDataGridViewTextBoxColumn.DropDownWidth = 20;
            this.chartboostIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chartboostIDDataGridViewTextBoxColumn.HeaderText = "ChartboostID";
            this.chartboostIDDataGridViewTextBoxColumn.Name = "chartboostIDDataGridViewTextBoxColumn";
            this.chartboostIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chartboostIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chartboostIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.chartboostIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // adMobIDDataGridViewTextBoxColumn
            // 
            this.adMobIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adMobIDDataGridViewTextBoxColumn.DataPropertyName = "AdMobID";
            this.adMobIDDataGridViewTextBoxColumn.DataSource = this.adMobAppsBindingSource;
            this.adMobIDDataGridViewTextBoxColumn.DisplayMember = "ApplicationName";
            this.adMobIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adMobIDDataGridViewTextBoxColumn.HeaderText = "AdMobID";
            this.adMobIDDataGridViewTextBoxColumn.Name = "adMobIDDataGridViewTextBoxColumn";
            this.adMobIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adMobIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adMobIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.adMobIDDataGridViewTextBoxColumn.Width = 77;
            // 
            // mobFoxIDDataGridViewTextBoxColumn
            // 
            this.mobFoxIDDataGridViewTextBoxColumn.DataPropertyName = "MobFoxID";
            this.mobFoxIDDataGridViewTextBoxColumn.HeaderText = "MobFoxID";
            this.mobFoxIDDataGridViewTextBoxColumn.Name = "mobFoxIDDataGridViewTextBoxColumn";
            // 
            // appAnnieIDDataGridViewTextBoxColumn
            // 
            this.appAnnieIDDataGridViewTextBoxColumn.DataPropertyName = "AppAnnieID";
            this.appAnnieIDDataGridViewTextBoxColumn.HeaderText = "AppAnnieID";
            this.appAnnieIDDataGridViewTextBoxColumn.Name = "appAnnieIDDataGridViewTextBoxColumn";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 500);
            this.Controls.Add(this.btnUpdateAdMob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateChartboost);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "Settings Form";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSalesDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartboostAppsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adMobAppsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database.GameSalesDataDataSet gameSalesDataDataSet;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private Database.GameSalesDataDataSetTableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private System.Windows.Forms.BindingSource platformsBindingSource;
        private Database.GameSalesDataDataSetTableAdapters.PlatformsTableAdapter platformsTableAdapter;
        private System.Windows.Forms.Button btnUpdateChartboost;
        private System.Windows.Forms.BindingSource chartboostAppsBindingSource;
        private Database.GameSalesDataDataSetTableAdapters.ChartboostAppsTableAdapter chartboostAppsTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdateAdMob;
        private System.Windows.Forms.BindingSource adMobAppsBindingSource;
        private Database.GameSalesDataDataSetTableAdapters.AdMobAppsTableAdapter adMobAppsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn platformIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn chartboostIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn adMobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobFoxIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appAnnieIDDataGridViewTextBoxColumn;
    }
}