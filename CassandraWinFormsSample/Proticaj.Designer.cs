namespace CassandraWinFormsSample
{
    partial class Proticaj
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProticaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProticaj)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProticaj
            // 
            chartArea1.AxisY.Maximum = 4000D;
            chartArea1.AxisY2.Maximum = 4000D;
            chartArea1.Name = "ChartArea1";
            this.chartProticaj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProticaj.Legends.Add(legend1);
            this.chartProticaj.Location = new System.Drawing.Point(0, 2);
            this.chartProticaj.Name = "chartProticaj";
            this.chartProticaj.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.Name = "Veoma visok";
            series1.ShadowColor = System.Drawing.Color.Tan;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.Name = "Visok";
            series2.ShadowColor = System.Drawing.Color.DarkGreen;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DarkGray;
            series3.Legend = "Legend1";
            series3.Name = "Srednji";
            series3.ShadowColor = System.Drawing.Color.MediumPurple;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Silver;
            series4.Legend = "Legend1";
            series4.Name = "Mali";
            series4.ShadowColor = System.Drawing.Color.Plum;
            this.chartProticaj.Series.Add(series1);
            this.chartProticaj.Series.Add(series2);
            this.chartProticaj.Series.Add(series3);
            this.chartProticaj.Series.Add(series4);
            this.chartProticaj.Size = new System.Drawing.Size(799, 420);
            this.chartProticaj.TabIndex = 0;
            this.chartProticaj.Text = "chart1";
            // 
            // Proticaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.chartProticaj);
            this.Name = "Proticaj";
            this.Text = "Proticaj";
            this.Load += new System.EventHandler(this.Proticaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProticaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProticaj;
    }
}