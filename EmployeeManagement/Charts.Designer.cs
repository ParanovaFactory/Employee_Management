namespace EmployeeManagement
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartJob = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCity
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCity.Legends.Add(legend4);
            this.chartCity.Location = new System.Drawing.Point(12, 66);
            this.chartCity.Name = "chartCity";
            this.chartCity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.Legend = "Legend1";
            series4.Name = "Employee City";
            this.chartCity.Series.Add(series4);
            this.chartCity.Size = new System.Drawing.Size(669, 247);
            this.chartCity.TabIndex = 15;
            this.chartCity.Text = "chart1";
            // 
            // chartJob
            // 
            chartArea5.Name = "ChartArea1";
            this.chartJob.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartJob.Legends.Add(legend5);
            this.chartJob.Location = new System.Drawing.Point(12, 319);
            this.chartJob.Name = "chartJob";
            this.chartJob.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series5.Legend = "Legend1";
            series5.Name = "Employee Job";
            this.chartJob.Series.Add(series5);
            this.chartJob.Size = new System.Drawing.Size(669, 247);
            this.chartJob.TabIndex = 16;
            this.chartJob.Text = "chart2";
            // 
            // chartSalary
            // 
            chartArea6.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSalary.Legends.Add(legend6);
            this.chartSalary.Location = new System.Drawing.Point(12, 572);
            this.chartSalary.Name = "chartSalary";
            this.chartSalary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series6.Legend = "Legend1";
            series6.Name = "Average Salary";
            this.chartSalary.Series.Add(series6);
            this.chartSalary.Size = new System.Drawing.Size(669, 247);
            this.chartSalary.TabIndex = 17;
            this.chartSalary.Text = "chart3";
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(12, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(126, 48);
            this.BtnExit.TabIndex = 18;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(693, 834);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.chartSalary);
            this.Controls.Add(this.chartJob);
            this.Controls.Add(this.chartCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJob;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private System.Windows.Forms.Button BtnExit;
    }
}