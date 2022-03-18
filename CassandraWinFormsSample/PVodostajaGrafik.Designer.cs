namespace CassandraWinFormsSample
{
    partial class PVodostajaGrafik
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
            this.pVodostaja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pVodostaja)).BeginInit();
            this.SuspendLayout();
            // 
            // pVodostaja
            // 
            chartArea1.AxisY.Maximum = 40D;
            chartArea1.AxisY.Minimum = -40D;
            chartArea1.AxisY2.Maximum = 40D;
            chartArea1.AxisY2.Minimum = -40D;
            chartArea1.Name = "ChartArea1";
            this.pVodostaja.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pVodostaja.Legends.Add(legend1);
            this.pVodostaja.Location = new System.Drawing.Point(29, 12);
            this.pVodostaja.Name = "pVodostaja";
            this.pVodostaja.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Promena vodostaja";
            this.pVodostaja.Series.Add(series1);
            this.pVodostaja.Size = new System.Drawing.Size(571, 369);
            this.pVodostaja.TabIndex = 0;
            this.pVodostaja.Text = "chart1";
            // 
            // PVodostajaGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 387);
            this.Controls.Add(this.pVodostaja);
            this.Name = "PVodostajaGrafik";
            this.Text = "PVodostajaGrafik";
            ((System.ComponentModel.ISupportInitialize)(this.pVodostaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pVodostaja;
    }
}