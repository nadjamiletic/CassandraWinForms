namespace CassandraWinFormsSample
{
    partial class CSve
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proticaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromenaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vodostaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stanica,
            this.Reka,
            this.Mesec,
            this.Dan,
            this.Sat,
            this.Proticaj,
            this.PromenaV,
            this.Vodostaj,
            this.Temperatura});
            this.dataGridView1.GridColor = System.Drawing.Color.SpringGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(917, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stanica
            // 
            this.Stanica.HeaderText = "Stanica";
            this.Stanica.Name = "Stanica";
            this.Stanica.ReadOnly = true;
            // 
            // Reka
            // 
            this.Reka.HeaderText = "Reka";
            this.Reka.Name = "Reka";
            this.Reka.ReadOnly = true;
            // 
            // Mesec
            // 
            this.Mesec.HeaderText = "Mesec";
            this.Mesec.Name = "Mesec";
            this.Mesec.ReadOnly = true;
            // 
            // Dan
            // 
            this.Dan.HeaderText = "Dan";
            this.Dan.Name = "Dan";
            this.Dan.ReadOnly = true;
            // 
            // Sat
            // 
            this.Sat.HeaderText = "Sat";
            this.Sat.Name = "Sat";
            this.Sat.ReadOnly = true;
            // 
            // Proticaj
            // 
            this.Proticaj.HeaderText = "Proticaj";
            this.Proticaj.Name = "Proticaj";
            this.Proticaj.ReadOnly = true;
            // 
            // PromenaV
            // 
            this.PromenaV.HeaderText = "Promena vodostaja";
            this.PromenaV.Name = "PromenaV";
            this.PromenaV.ReadOnly = true;
            // 
            // Vodostaj
            // 
            this.Vodostaj.HeaderText = "Vodostaj";
            this.Vodostaj.Name = "Vodostaj";
            this.Vodostaj.ReadOnly = true;
            // 
            // Temperatura
            // 
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.ReadOnly = true;
            // 
            // CSve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CSve";
            this.Size = new System.Drawing.Size(912, 349);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proticaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromenaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vodostaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
    }
}
