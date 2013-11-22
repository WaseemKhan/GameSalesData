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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateChartboost = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.platformsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameSalesDataDataSet = new GameSalesData.Database.GameSalesDataDataSet();
            this.chartboostIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chartboostAppsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adMobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobFoxIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appAnnieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.ApplicationsTableAdapter();
            this.platformsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.PlatformsTableAdapter();
            this.chartboostAppsTableAdapter = new GameSalesData.Database.GameSalesDataDataSetTableAdapters.ChartboostAppsTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSalesDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartboostAppsBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(818, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.dataGridView1);
            this.tabApplications.Location = new System.Drawing.Point(4, 22);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(810, 474);
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
            this.dataGridView1.Size = new System.Drawing.Size(804, 468);
            this.dataGridView1.TabIndex = 0;
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
            this.btnUpdateChartboost.Location = new System.Drawing.Point(833, 25);
            this.btnUpdateChartboost.Name = "btnUpdateChartboost";
            this.btnUpdateChartboost.Size = new System.Drawing.Size(150, 31);
            this.btnUpdateChartboost.TabIndex = 1;
            this.btnUpdateChartboost.Text = "Update Chartboost";
            this.btnUpdateChartboost.UseVisualStyleBackColor = true;
            this.btnUpdateChartboost.Click += new System.EventHandler(this.btnUpdateChartboost_Click);
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
            this.platformIDDataGridViewTextBoxColumn.HeaderText = "PlatformID";
            this.platformIDDataGridViewTextBoxColumn.Name = "platformIDDataGridViewTextBoxColumn";
            this.platformIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.platformIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.platformIDDataGridViewTextBoxColumn.ValueMember = "ID";
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
            // chartboostIDDataGridViewTextBoxColumn
            // 
            this.chartboostIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chartboostIDDataGridViewTextBoxColumn.DataPropertyName = "ChartboostID";
            this.chartboostIDDataGridViewTextBoxColumn.DataSource = this.chartboostAppsBindingSource;
            this.chartboostIDDataGridViewTextBoxColumn.DisplayMember = "ApplicationName";
            this.chartboostIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.chartboostIDDataGridViewTextBoxColumn.HeaderText = "ChartboostID";
            this.chartboostIDDataGridViewTextBoxColumn.Name = "chartboostIDDataGridViewTextBoxColumn";
            this.chartboostIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chartboostIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chartboostIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.chartboostIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // chartboostAppsBindingSource
            // 
            this.chartboostAppsBindingSource.DataMember = "ChartboostApps";
            this.chartboostAppsBindingSource.DataSource = this.gameSalesDataDataSet;
            // 
            // adMobIDDataGridViewTextBoxColumn
            // 
            this.adMobIDDataGridViewTextBoxColumn.DataPropertyName = "AdMobID";
            this.adMobIDDataGridViewTextBoxColumn.HeaderText = "AdMobID";
            this.adMobIDDataGridViewTextBoxColumn.Name = "adMobIDDataGridViewTextBoxColumn";
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
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.gameSalesDataDataSet;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(833, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateChartboost);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "Settings Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSalesDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartboostAppsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn platformIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn chartboostIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adMobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobFoxIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appAnnieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
    }
}