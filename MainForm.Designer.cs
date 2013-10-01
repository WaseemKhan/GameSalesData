namespace GameSalesData
{
    partial class MainForm
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
            this.btnRevMob = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCB = new System.Windows.Forms.TabPage();
            this.grdChartBoost = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMobFox = new System.Windows.Forms.TabPage();
            this.grdMobFox = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCBRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdMobLogin = new System.Windows.Forms.Button();
            this.tabAppAnnie = new System.Windows.Forms.TabPage();
            this.grdAppAnnie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChartBoost)).BeginInit();
            this.tabMobFox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMobFox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabAppAnnie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppAnnie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevMob
            // 
            this.btnRevMob.Location = new System.Drawing.Point(834, 10);
            this.btnRevMob.Name = "btnRevMob";
            this.btnRevMob.Size = new System.Drawing.Size(101, 30);
            this.btnRevMob.TabIndex = 6;
            this.btnRevMob.Text = "Rev Mob";
            this.btnRevMob.UseVisualStyleBackColor = true;
            this.btnRevMob.Click += new System.EventHandler(this.btnRevMob_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdMobLogin, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 559);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCB);
            this.tabControl1.Controls.Add(this.tabMobFox);
            this.tabControl1.Controls.Add(this.tabAppAnnie);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 445);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCB
            // 
            this.tabCB.Controls.Add(this.grdChartBoost);
            this.tabCB.Location = new System.Drawing.Point(4, 22);
            this.tabCB.Name = "tabCB";
            this.tabCB.Padding = new System.Windows.Forms.Padding(3);
            this.tabCB.Size = new System.Drawing.Size(814, 419);
            this.tabCB.TabIndex = 0;
            this.tabCB.Text = "Chartboost";
            this.tabCB.UseVisualStyleBackColor = true;
            // 
            // grdChartBoost
            // 
            this.grdChartBoost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdChartBoost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChartBoost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdChartBoost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChartBoost.Location = new System.Drawing.Point(3, 3);
            this.grdChartBoost.MultiSelect = false;
            this.grdChartBoost.Name = "grdChartBoost";
            this.grdChartBoost.ReadOnly = true;
            this.grdChartBoost.Size = new System.Drawing.Size(808, 413);
            this.grdChartBoost.TabIndex = 4;
            this.grdChartBoost.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChartBoost_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Applications";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 89;
            // 
            // tabMobFox
            // 
            this.tabMobFox.Controls.Add(this.grdMobFox);
            this.tabMobFox.Location = new System.Drawing.Point(4, 22);
            this.tabMobFox.Name = "tabMobFox";
            this.tabMobFox.Padding = new System.Windows.Forms.Padding(3);
            this.tabMobFox.Size = new System.Drawing.Size(814, 419);
            this.tabMobFox.TabIndex = 1;
            this.tabMobFox.Text = "Mob Fox";
            this.tabMobFox.UseVisualStyleBackColor = true;
            // 
            // grdMobFox
            // 
            this.grdMobFox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMobFox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMobFox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grdMobFox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMobFox.Location = new System.Drawing.Point(3, 3);
            this.grdMobFox.MultiSelect = false;
            this.grdMobFox.Name = "grdMobFox";
            this.grdMobFox.ReadOnly = true;
            this.grdMobFox.Size = new System.Drawing.Size(808, 413);
            this.grdMobFox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Applications";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCBRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 48);
            this.panel1.TabIndex = 2;
            // 
            // btnCBRefresh
            // 
            this.btnCBRefresh.Location = new System.Drawing.Point(691, 5);
            this.btnCBRefresh.Name = "btnCBRefresh";
            this.btnCBRefresh.Size = new System.Drawing.Size(122, 33);
            this.btnCBRefresh.TabIndex = 14;
            this.btnCBRefresh.Text = "Refresh";
            this.btnCBRefresh.UseVisualStyleBackColor = true;
            this.btnCBRefresh.Click += new System.EventHandler(this.btnCBRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(400, 13);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 11;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(79, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 10;
            // 
            // btnAdMobLogin
            // 
            this.btnAdMobLogin.Location = new System.Drawing.Point(3, 508);
            this.btnAdMobLogin.Name = "btnAdMobLogin";
            this.btnAdMobLogin.Size = new System.Drawing.Size(101, 31);
            this.btnAdMobLogin.TabIndex = 10;
            this.btnAdMobLogin.Text = "AdMob Login";
            this.btnAdMobLogin.UseVisualStyleBackColor = true;
            // 
            // tabAppAnnie
            // 
            this.tabAppAnnie.Controls.Add(this.grdAppAnnie);
            this.tabAppAnnie.Location = new System.Drawing.Point(4, 22);
            this.tabAppAnnie.Name = "tabAppAnnie";
            this.tabAppAnnie.Size = new System.Drawing.Size(814, 419);
            this.tabAppAnnie.TabIndex = 2;
            this.tabAppAnnie.Text = "App Annie";
            this.tabAppAnnie.UseVisualStyleBackColor = true;
            // 
            // grdAppAnnie
            // 
            this.grdAppAnnie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdAppAnnie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppAnnie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grdAppAnnie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAppAnnie.Location = new System.Drawing.Point(0, 0);
            this.grdAppAnnie.MultiSelect = false;
            this.grdAppAnnie.Name = "grdAppAnnie";
            this.grdAppAnnie.ReadOnly = true;
            this.grdAppAnnie.Size = new System.Drawing.Size(814, 419);
            this.grdAppAnnie.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Applications";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRevMob);
            this.Name = "MainForm";
            this.Text = "Reporting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChartBoost)).EndInit();
            this.tabMobFox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMobFox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabAppAnnie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAppAnnie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevMob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCB;
        private System.Windows.Forms.DataGridView grdChartBoost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage tabMobFox;
        private System.Windows.Forms.DataGridView grdMobFox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAdMobLogin;
        private System.Windows.Forms.Button btnCBRefresh;
        private System.Windows.Forms.TabPage tabAppAnnie;
        private System.Windows.Forms.DataGridView grdAppAnnie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

