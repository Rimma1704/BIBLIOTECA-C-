namespace Biblioteca
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizeazaCartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartiToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.detaliiCarteToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 503);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cartiToolStripMenuItem
            // 
            this.cartiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCarteToolStripMenuItem,
            this.vizualizeazaCartiToolStripMenuItem});
            this.cartiToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cartiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cartiToolStripMenuItem.Image")));
            this.cartiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cartiToolStripMenuItem.Name = "cartiToolStripMenuItem";
            this.cartiToolStripMenuItem.Size = new System.Drawing.Size(137, 58);
            this.cartiToolStripMenuItem.Text = "CARTI";
            // 
            // adaugaCarteToolStripMenuItem
            // 
            this.adaugaCarteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adaugaCarteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adaugaCarteToolStripMenuItem.Image")));
            this.adaugaCarteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adaugaCarteToolStripMenuItem.Name = "adaugaCarteToolStripMenuItem";
            this.adaugaCarteToolStripMenuItem.Size = new System.Drawing.Size(311, 84);
            this.adaugaCarteToolStripMenuItem.Text = "ADAUGA CARTE";
            this.adaugaCarteToolStripMenuItem.Click += new System.EventHandler(this.adaugaCarteToolStripMenuItem_Click);
            // 
            // vizualizeazaCartiToolStripMenuItem
            // 
            this.vizualizeazaCartiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vizualizeazaCartiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vizualizeazaCartiToolStripMenuItem.Image")));
            this.vizualizeazaCartiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vizualizeazaCartiToolStripMenuItem.Name = "vizualizeazaCartiToolStripMenuItem";
            this.vizualizeazaCartiToolStripMenuItem.Size = new System.Drawing.Size(311, 84);
            this.vizualizeazaCartiToolStripMenuItem.Text = "VIZUALIZEAZA CARTI";
            this.vizualizeazaCartiToolStripMenuItem.Click += new System.EventHandler(this.vizualizeazaCartiToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaStudentToolStripMenuItem,
            this.studentiInfoToolStripMenuItem});
            this.studentiToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.studentiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentiToolStripMenuItem.Image")));
            this.studentiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(170, 73);
            this.studentiToolStripMenuItem.Text = "STUDENTI";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // adaugaStudentToolStripMenuItem
            // 
            this.adaugaStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adaugaStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adaugaStudentToolStripMenuItem.Image")));
            this.adaugaStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adaugaStudentToolStripMenuItem.Name = "adaugaStudentToolStripMenuItem";
            this.adaugaStudentToolStripMenuItem.Size = new System.Drawing.Size(284, 66);
            this.adaugaStudentToolStripMenuItem.Text = "ADAUGA STUDENT";
            this.adaugaStudentToolStripMenuItem.Click += new System.EventHandler(this.adaugaStudentToolStripMenuItem_Click);
            // 
            // studentiInfoToolStripMenuItem
            // 
            this.studentiInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.studentiInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentiInfoToolStripMenuItem.Image")));
            this.studentiInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentiInfoToolStripMenuItem.Name = "studentiInfoToolStripMenuItem";
            this.studentiInfoToolStripMenuItem.Size = new System.Drawing.Size(284, 66);
            this.studentiInfoToolStripMenuItem.Text = "STUDENTI INFO";
            this.studentiInfoToolStripMenuItem.Click += new System.EventHandler(this.studentiInfoToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issueBooksToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(227, 66);
            this.issueBooksToolStripMenuItem.Text = "ELIBERARE CARTI";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnBooksToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
            this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(236, 72);
            this.returnBooksToolStripMenuItem.Text = "RETURNARE CARTI";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // detaliiCarteToolStripMenuItem
            // 
            this.detaliiCarteToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detaliiCarteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.detaliiCarteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaliiCarteToolStripMenuItem.Image")));
            this.detaliiCarteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaliiCarteToolStripMenuItem.Name = "detaliiCarteToolStripMenuItem";
            this.detaliiCarteToolStripMenuItem.Size = new System.Drawing.Size(219, 60);
            this.detaliiCarteToolStripMenuItem.Text = "DETALII CARTI";
            this.detaliiCarteToolStripMenuItem.Click += new System.EventHandler(this.detaliiCarteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(163, 68);
            this.helpToolStripMenuItem.Text = "AJUTOR";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 78);
            this.exitToolStripMenuItem.Text = "IESIRE";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(332, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIBLIOTECA";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizeazaCartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}