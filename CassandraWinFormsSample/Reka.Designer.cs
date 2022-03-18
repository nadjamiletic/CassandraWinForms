namespace CassandraWinFormsSample
{
    partial class Reka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reka));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtStanica = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtReka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPodatak = new System.Windows.Forms.TextBox();
            this.btnVrati = new System.Windows.Forms.Button();
            this.txtReka1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSve = new System.Windows.Forms.TextBox();
            this.btnVratiSve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtStanica);
            this.groupBox1.Controls.Add(this.txtGrad);
            this.groupBox1.Controls.Add(this.txtReka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(74, 142);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtStanica
            // 
            this.txtStanica.Location = new System.Drawing.Point(74, 102);
            this.txtStanica.Name = "txtStanica";
            this.txtStanica.Size = new System.Drawing.Size(120, 20);
            this.txtStanica.TabIndex = 5;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(74, 63);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(120, 20);
            this.txtGrad.TabIndex = 4;
            // 
            // txtReka
            // 
            this.txtReka.Location = new System.Drawing.Point(74, 29);
            this.txtReka.Name = "txtReka";
            this.txtReka.Size = new System.Drawing.Size(120, 20);
            this.txtReka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reka";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPodatak);
            this.groupBox2.Controls.Add(this.btnVrati);
            this.groupBox2.Controls.Add(this.txtReka1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(298, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 209);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrati podatke za jednu reku";
            // 
            // txtPodatak
            // 
            this.txtPodatak.Location = new System.Drawing.Point(6, 102);
            this.txtPodatak.Multiline = true;
            this.txtPodatak.Name = "txtPodatak";
            this.txtPodatak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPodatak.Size = new System.Drawing.Size(168, 90);
            this.txtPodatak.TabIndex = 3;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(74, 63);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(100, 23);
            this.btnVrati.TabIndex = 2;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // txtReka1
            // 
            this.txtReka1.Location = new System.Drawing.Point(74, 35);
            this.txtReka1.Name = "txtReka1";
            this.txtReka1.Size = new System.Drawing.Size(100, 20);
            this.txtReka1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reka";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSve);
            this.groupBox3.Controls.Add(this.btnVratiSve);
            this.groupBox3.Location = new System.Drawing.Point(588, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 209);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vrati podatke za sve reke";
            // 
            // txtSve
            // 
            this.txtSve.Location = new System.Drawing.Point(22, 63);
            this.txtSve.Multiline = true;
            this.txtSve.Name = "txtSve";
            this.txtSve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSve.Size = new System.Drawing.Size(163, 129);
            this.txtSve.TabIndex = 1;
            // 
            // btnVratiSve
            // 
            this.btnVratiSve.Location = new System.Drawing.Point(22, 30);
            this.btnVratiSve.Name = "btnVratiSve";
            this.btnVratiSve.Size = new System.Drawing.Size(163, 23);
            this.btnVratiSve.TabIndex = 0;
            this.btnVratiSve.Text = "Vrati sve";
            this.btnVratiSve.UseVisualStyleBackColor = true;
            this.btnVratiSve.Click += new System.EventHandler(this.btnVratiSve_Click);
            // 
            // Reka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reka";
            this.Text = "Reka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtStanica;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtReka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPodatak;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.TextBox txtReka1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSve;
        private System.Windows.Forms.Button btnVratiSve;
    }
}