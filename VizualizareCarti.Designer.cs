namespace Biblioteca
{
    partial class VizualizareCarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareCarti));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDenumireCarte = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnStergeti = new System.Windows.Forms.Button();
            this.btnActualizati = new System.Windows.Forms.Button();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtEditie = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInchide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DENUMIRE CARTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDenumireCarte
            // 
            this.txtDenumireCarte.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDenumireCarte.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDenumireCarte.ForeColor = System.Drawing.Color.Orange;
            this.txtDenumireCarte.Location = new System.Drawing.Point(287, 270);
            this.txtDenumireCarte.Name = "txtDenumireCarte";
            this.txtDenumireCarte.Size = new System.Drawing.Size(581, 28);
            this.txtDenumireCarte.TabIndex = 2;
            this.txtDenumireCarte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(916, 253);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 41);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(36, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 261);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Controls.Add(this.txtData);
            this.panel22.Controls.Add(this.btnInapoi);
            this.panel22.Controls.Add(this.btnStergeti);
            this.panel22.Controls.Add(this.btnActualizati);
            this.panel22.Controls.Add(this.txtCantitate);
            this.panel22.Controls.Add(this.txtPret);
            this.panel22.Controls.Add(this.txtEditie);
            this.panel22.Controls.Add(this.txtAutor);
            this.panel22.Controls.Add(this.txtDenumire);
            this.panel22.Controls.Add(this.label9);
            this.panel22.Controls.Add(this.label8);
            this.panel22.Controls.Add(this.label7);
            this.panel22.Controls.Add(this.label6);
            this.panel22.Controls.Add(this.label5);
            this.panel22.Controls.Add(this.label4);
            this.panel22.Location = new System.Drawing.Point(24, 607);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(962, 226);
            this.panel22.TabIndex = 5;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtData.ForeColor = System.Drawing.Color.Orange;
            this.txtData.Location = new System.Drawing.Point(600, 17);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(214, 28);
            this.txtData.TabIndex = 15;
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Orange;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInapoi.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInapoi.ForeColor = System.Drawing.Color.White;
            this.btnInapoi.Location = new System.Drawing.Point(748, 178);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(147, 36);
            this.btnInapoi.TabIndex = 14;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStergeti
            // 
            this.btnStergeti.BackColor = System.Drawing.Color.Orange;
            this.btnStergeti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergeti.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStergeti.ForeColor = System.Drawing.Color.White;
            this.btnStergeti.Location = new System.Drawing.Point(556, 178);
            this.btnStergeti.Name = "btnStergeti";
            this.btnStergeti.Size = new System.Drawing.Size(149, 36);
            this.btnStergeti.TabIndex = 13;
            this.btnStergeti.Text = "Stergeti";
            this.btnStergeti.UseVisualStyleBackColor = false;
            this.btnStergeti.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnActualizati
            // 
            this.btnActualizati.BackColor = System.Drawing.Color.Orange;
            this.btnActualizati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizati.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActualizati.ForeColor = System.Drawing.Color.White;
            this.btnActualizati.Location = new System.Drawing.Point(367, 178);
            this.btnActualizati.Name = "btnActualizati";
            this.btnActualizati.Size = new System.Drawing.Size(152, 36);
            this.btnActualizati.TabIndex = 12;
            this.btnActualizati.Text = "Actualizati";
            this.btnActualizati.UseVisualStyleBackColor = false;
            this.btnActualizati.Click += new System.EventHandler(this.btnActualizati_Click);
            // 
            // txtCantitate
            // 
            this.txtCantitate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCantitate.ForeColor = System.Drawing.Color.Orange;
            this.txtCantitate.Location = new System.Drawing.Point(600, 99);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(214, 28);
            this.txtCantitate.TabIndex = 10;
            // 
            // txtPret
            // 
            this.txtPret.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPret.ForeColor = System.Drawing.Color.Orange;
            this.txtPret.Location = new System.Drawing.Point(600, 59);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(214, 28);
            this.txtPret.TabIndex = 9;
            // 
            // txtEditie
            // 
            this.txtEditie.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEditie.ForeColor = System.Drawing.Color.Orange;
            this.txtEditie.Location = new System.Drawing.Point(154, 105);
            this.txtEditie.Name = "txtEditie";
            this.txtEditie.Size = new System.Drawing.Size(218, 28);
            this.txtEditie.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAutor.ForeColor = System.Drawing.Color.Orange;
            this.txtAutor.Location = new System.Drawing.Point(154, 62);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(218, 28);
            this.txtAutor.TabIndex = 7;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDenumire.ForeColor = System.Drawing.Color.Orange;
            this.txtDenumire.Location = new System.Drawing.Point(154, 20);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(218, 28);
            this.txtDenumire.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(516, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantitate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(516, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(516, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(63, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Editie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Denumire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIZUALIZARE CARTI";
            // 
            // btnInchide
            // 
            this.btnInchide.Image = ((System.Drawing.Image)(resources.GetObject("btnInchide.Image")));
            this.btnInchide.Location = new System.Drawing.Point(963, -2);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(43, 36);
            this.btnInchide.TabIndex = 6;
            this.btnInchide.UseVisualStyleBackColor = true;
            this.btnInchide.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VizualizareCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 652);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtDenumireCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VizualizareCarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VizualizareCarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDenumireCarte;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnStergeti;
        private System.Windows.Forms.Button btnActualizati;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtEditie;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInchide;
    }
}