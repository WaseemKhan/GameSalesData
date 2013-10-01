namespace GameSalesData
{
    partial class DataPopupForm
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
            this.richData = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richData
            // 
            this.richData.Dock = System.Windows.Forms.DockStyle.Top;
            this.richData.Location = new System.Drawing.Point(0, 0);
            this.richData.Name = "richData";
            this.richData.Size = new System.Drawing.Size(503, 242);
            this.richData.TabIndex = 0;
            this.richData.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DataPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 287);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.richData);
            this.Name = "DataPopupForm";
            this.Text = "DataPopupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richData;
        private System.Windows.Forms.Button btnOK;
    }
}