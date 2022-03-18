namespace CassandraWinFormsSample
{
    partial class Grad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grad));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVratiSve = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVrati1 = new System.Windows.Forms.Button();
            this.txtJedanGrad = new System.Windows.Forms.TextBox();
            this.txtNaziv1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtStanica = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblStanica = new System.Windows.Forms.Label();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVratiSve);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(596, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vrati za sve gradove";
            // 
            // btnVratiSve
            // 
            this.btnVratiSve.Location = new System.Drawing.Point(7, 20);
            this.btnVratiSve.Name = "btnVratiSve";
            this.btnVratiSve.Size = new System.Drawing.Size(75, 23);
            this.btnVratiSve.TabIndex = 1;
            this.btnVratiSve.Text = "Vrati sve";
            this.btnVratiSve.UseVisualStyleBackColor = true;
            this.btnVratiSve.Click += new System.EventHandler(this.btnVratiSve_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(187, 161);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVrati1);
            this.groupBox2.Controls.Add(this.txtJedanGrad);
            this.groupBox2.Controls.Add(this.txtNaziv1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(247, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci za jedan grad";
            // 
            // btnVrati1
            // 
            this.btnVrati1.Location = new System.Drawing.Point(13, 39);
            this.btnVrati1.Name = "btnVrati1";
            this.btnVrati1.Size = new System.Drawing.Size(81, 21);
            this.btnVrati1.TabIndex = 3;
            this.btnVrati1.Text = "Vrati";
            this.btnVrati1.UseVisualStyleBackColor = true;
            this.btnVrati1.Click += new System.EventHandler(this.btnVrati1_Click_1);
            // 
            // txtJedanGrad
            // 
            this.txtJedanGrad.Location = new System.Drawing.Point(13, 66);
            this.txtJedanGrad.Multiline = true;
            this.txtJedanGrad.Name = "txtJedanGrad";
            this.txtJedanGrad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJedanGrad.Size = new System.Drawing.Size(194, 95);
            this.txtJedanGrad.TabIndex = 2;
            // 
            // txtNaziv1
            // 
            this.txtNaziv1.Location = new System.Drawing.Point(84, 13);
            this.txtNaziv1.Name = "txtNaziv1";
            this.txtNaziv1.Size = new System.Drawing.Size(123, 20);
            this.txtNaziv1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv grada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtStanica);
            this.groupBox1.Controls.Add(this.txtDrzava);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.lblStanica);
            this.groupBox1.Controls.Add(this.lblDrzava);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Location = new System.Drawing.Point(1, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(79, 142);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // txtStanica
            // 
            this.txtStanica.Location = new System.Drawing.Point(79, 105);
            this.txtStanica.Name = "txtStanica";
            this.txtStanica.Size = new System.Drawing.Size(128, 20);
            this.txtStanica.TabIndex = 5;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(79, 67);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(128, 20);
            this.txtDrzava.TabIndex = 4;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(80, 30);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(128, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // lblStanica
            // 
            this.lblStanica.AutoSize = true;
            this.lblStanica.Location = new System.Drawing.Point(10, 105);
            this.lblStanica.Name = "lblStanica";
            this.lblStanica.Size = new System.Drawing.Size(43, 13);
            this.lblStanica.TabIndex = 2;
            this.lblStanica.Text = "Stanica";
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(10, 70);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(41, 13);
            this.lblDrzava.TabIndex = 1;
            this.lblDrzava.Text = "Drzava";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(10, 33);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(64, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv grada";
            // 
            // Grad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(808, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Grad";
            this.Text = "Grad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVratiSve;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVrati1;
        private System.Windows.Forms.TextBox txtJedanGrad;
        private System.Windows.Forms.TextBox txtNaziv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtStanica;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblStanica;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblNaziv;
    }
}