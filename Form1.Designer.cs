namespace WheaterForecast_UserControl_Manual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewForecastButton = new System.Windows.Forms.Button();
            this.updateForecastButton = new System.Windows.Forms.Button();
            this.forecastFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // addNewForecastButton
            // 
            this.addNewForecastButton.Location = new System.Drawing.Point(36, 449);
            this.addNewForecastButton.Name = "addNewForecastButton";
            this.addNewForecastButton.Size = new System.Drawing.Size(158, 29);
            this.addNewForecastButton.TabIndex = 0;
            this.addNewForecastButton.Text = "Add New Forecast";
            this.addNewForecastButton.UseVisualStyleBackColor = true;
            this.addNewForecastButton.Click += new System.EventHandler(this.addNewForecastButton_Click);
            // 
            // updateForecastButton
            // 
            this.updateForecastButton.Location = new System.Drawing.Point(227, 449);
            this.updateForecastButton.Name = "updateForecastButton";
            this.updateForecastButton.Size = new System.Drawing.Size(97, 29);
            this.updateForecastButton.TabIndex = 1;
            this.updateForecastButton.Text = "Update";
            this.updateForecastButton.UseVisualStyleBackColor = true;
            this.updateForecastButton.Click += new System.EventHandler(this.updateForecastButton_Click);
            // 
            // forecastFlowLayoutPanel
            // 
            this.forecastFlowLayoutPanel.Location = new System.Drawing.Point(36, 34);
            this.forecastFlowLayoutPanel.Name = "forecastFlowLayoutPanel";
            this.forecastFlowLayoutPanel.Size = new System.Drawing.Size(890, 401);
            this.forecastFlowLayoutPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 500);
            this.Controls.Add(this.forecastFlowLayoutPanel);
            this.Controls.Add(this.updateForecastButton);
            this.Controls.Add(this.addNewForecastButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewForecastButton;
        private System.Windows.Forms.Button updateForecastButton;
        private System.Windows.Forms.FlowLayoutPanel forecastFlowLayoutPanel;
    }
}
