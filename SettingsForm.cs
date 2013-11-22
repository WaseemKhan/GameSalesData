using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSalesData.DataServices;

namespace GameSalesData
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameSalesDataDataSet.ChartboostApps' table. You can move, or remove it, as needed.
            this.chartboostAppsTableAdapter.Fill(this.gameSalesDataDataSet.ChartboostApps);
            // TODO: This line of code loads data into the 'gameSalesDataDataSet.Platforms' table. You can move, or remove it, as needed.
            this.platformsTableAdapter.Fill(this.gameSalesDataDataSet.Platforms);
            // TODO: This line of code loads data into the 'gameSalesDataDataSet.Applications' table. You can move, or remove it, as needed.
            this.applicationsTableAdapter.Fill(this.gameSalesDataDataSet.Applications);

        }

        private void btnUpdateChartboost_Click(object sender, EventArgs e)
        {
            ChartboostService CBService = new ChartboostService();

            //CBService.UpdateAppsInDB();
            //CBService.UpdateAppsInDB(1);
            CBService.UpdateAppsInDB(null); //this.chartboostAppsTableAdapter);

            //if ( CBService.UpdateAppsInDB(this.gameSalesDataDataSet.ChartboostApps) )
            //    this.gameSalesDataDataSet.ChartboostApps.
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gameSalesDataDataSet.Applications.AcceptChanges();

            try
            {
                int count = this.applicationsTableAdapter.Update(this.gameSalesDataDataSet.Applications);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
