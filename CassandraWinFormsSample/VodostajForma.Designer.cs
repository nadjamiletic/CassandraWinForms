namespace CassandraWinFormsSample
{
    partial class VodostajForma
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
            this.chartVodostaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartVodostaj)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVodostaj
            // 
            this.chartVodostaj.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            chartArea1.AxisY.Maximum = 400D;
            chartArea1.AxisY.Minimum = -80D;
            chartArea1.AxisY2.Maximum = 400D;
            chartArea1.AxisY2.Minimum = -80D;
            chartArea1.Name = "ChartArea1";
            this.chartVodostaj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVodostaj.Legends.Add(legend1);
            this.chartVodostaj.Location = new System.Drawing.Point(12, 12);
            this.chartVodostaj.Name = "chartVodostaj";
            this.chartVodostaj.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.LabelForeColor = System.Drawing.Color.RosyBrown;
            series1.Legend = "Legend1";
            series1.Name = "Ispod nivoa mora";
            series1.ShadowColor = System.Drawing.Color.Silver;
            series1.YValuesPerPoint = 10;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Nizak";
            series2.YValuesPerPoint = 10;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "Srednji";
            series3.YValuesPerPoint = 10;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Purple;
            series4.Legend = "Legend1";
            series4.Name = "Visok";
            series4.YValuesPerPoint = 10;
            this.chartVodostaj.Series.Add(series1);
            this.chartVodostaj.Series.Add(series2);
            this.chartVodostaj.Series.Add(series3);
            this.chartVodostaj.Series.Add(series4);
            this.chartVodostaj.Size = new System.Drawing.Size(765, 394);
            this.chartVodostaj.TabIndex = 0;
            this.chartVodostaj.Text = "chart1";
            // 
            // VodostajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 402);
            this.Controls.Add(this.chartVodostaj);
            this.Name = "VodostajForma";
            this.Text = "VodostajForma";
            this.Load += new System.EventHandler(this.VodostajForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVodostaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVodostaj;
    }
}