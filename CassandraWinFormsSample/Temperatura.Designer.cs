namespace CassandraWinFormsSample
{
    partial class Temperatura
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTemperatura
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperatura.Legends.Add(legend1);
            this.chartTemperatura.Location = new System.Drawing.Point(1, 0);
            this.chartTemperatura.Name = "chartTemperatura";
            this.chartTemperatura.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.LabelForeColor = System.Drawing.Color.Turquoise;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Cyan;
            series1.Name = "Niska";
            series1.ShadowColor = System.Drawing.Color.DarkSlateGray;
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Srednja";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "Topla";
            this.chartTemperatura.Series.Add(series1);
            this.chartTemperatura.Series.Add(series2);
            this.chartTemperatura.Series.Add(series3);
            this.chartTemperatura.Size = new System.Drawing.Size(720, 392);
            this.chartTemperatura.TabIndex = 0;
            this.chartTemperatura.Text = "Temperatura";
            this.chartTemperatura.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 404);
            this.Controls.Add(this.chartTemperatura);
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Temperatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
    }
}