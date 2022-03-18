namespace CassandraWinFormsSample
{
    partial class CProticaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CProticaj));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proticaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbReka = new System.Windows.Forms.ComboBox();
            this.cbStanica = new System.Windows.Forms.ComboBox();
            this.cbMesec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sat,
            this.Proticaj});
            this.dataGridView1.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.Location = new System.Drawing.Point(119, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cbReka
            // 
            this.cbReka.FormattingEnabled = true;
            this.cbReka.Location = new System.Drawing.Point(62, 26);
            this.cbReka.Name = "cbReka";
            this.cbReka.Size = new System.Drawing.Size(75, 21);
            this.cbReka.TabIndex = 1;
            this.cbReka.SelectedIndexChanged += new System.EventHandler(this.cbReka_SelectedIndexChanged);
            // 
            // cbStanica
            // 
            this.cbStanica.FormattingEnabled = true;
            this.cbStanica.Location = new System.Drawing.Point(205, 26);
            this.cbStanica.Name = "cbStanica";
            this.cbStanica.Size = new System.Drawing.Size(84, 21);
            this.cbStanica.TabIndex = 2;
            this.cbStanica.SelectedIndexChanged += new System.EventHandler(this.cbStanica_SelectedIndexChanged);
            // 
            // cbMesec
            // 
            this.cbMesec.FormattingEnabled = true;
            this.cbMesec.Location = new System.Drawing.Point(351, 26);
            this.cbMesec.Name = "cbMesec";
            this.cbMesec.Size = new System.Drawing.Size(78, 21);
            this.cbMesec.TabIndex = 3;
            this.cbMesec.SelectedIndexChanged += new System.EventHandler(this.cbMesec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stanica";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesec";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(439, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 81);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prikazi grafik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dan";
            // 
            // cmbDan
            // 
            this.cmbDan.FormattingEnabled = true;
            this.cmbDan.Location = new System.Drawing.Point(486, 26);
            this.cmbDan.Name = "cmbDan";
            this.cmbDan.Size = new System.Drawing.Size(69, 21);
            this.cmbDan.TabIndex = 10;
            this.cmbDan.SelectedIndexChanged += new System.EventHandler(this.cmbDan_SelectedIndexChanged);
            // 
            // CProticaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMesec);
            this.Controls.Add(this.cbStanica);
            this.Controls.Add(this.cbReka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CProticaj";
            this.Size = new System.Drawing.Size(615, 393);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbReka;
        private System.Windows.Forms.ComboBox cbStanica;
        private System.Windows.Forms.ComboBox cbMesec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proticaj;
    }
}
