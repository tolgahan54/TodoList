
namespace TodoUygulması
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Islemlistesi = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbIslemliste = new System.Windows.Forms.GroupBox();
            this.btnuygulamakapa = new System.Windows.Forms.Button();
            this.btnkayitliste = new System.Windows.Forms.Button();
            this.btnYenikayit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblzaman = new System.Windows.Forms.Label();
            this.tm_zaman = new System.Windows.Forms.Timer(this.components);
            this.Islemlistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbIslemliste.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Islemlistesi
            // 
            this.Islemlistesi.Controls.Add(this.pictureBox1);
            this.Islemlistesi.Controls.Add(this.gbIslemliste);
            this.Islemlistesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.Islemlistesi.Location = new System.Drawing.Point(0, 0);
            this.Islemlistesi.Name = "Islemlistesi";
            this.Islemlistesi.Size = new System.Drawing.Size(391, 668);
            this.Islemlistesi.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbIslemliste
            // 
            this.gbIslemliste.Controls.Add(this.btnuygulamakapa);
            this.gbIslemliste.Controls.Add(this.btnkayitliste);
            this.gbIslemliste.Controls.Add(this.btnYenikayit);
            this.gbIslemliste.Location = new System.Drawing.Point(12, 275);
            this.gbIslemliste.Name = "gbIslemliste";
            this.gbIslemliste.Size = new System.Drawing.Size(222, 242);
            this.gbIslemliste.TabIndex = 0;
            this.gbIslemliste.TabStop = false;
            this.gbIslemliste.Text = "İşlem Listesi";
            // 
            // btnuygulamakapa
            // 
            this.btnuygulamakapa.Location = new System.Drawing.Point(6, 139);
            this.btnuygulamakapa.Name = "btnuygulamakapa";
            this.btnuygulamakapa.Size = new System.Drawing.Size(210, 37);
            this.btnuygulamakapa.TabIndex = 0;
            this.btnuygulamakapa.Text = "Uygulumayı Kapat";
            this.btnuygulamakapa.UseVisualStyleBackColor = true;
            this.btnuygulamakapa.Click += new System.EventHandler(this.btnuygulamakapa_Click);
            // 
            // btnkayitliste
            // 
            this.btnkayitliste.Location = new System.Drawing.Point(6, 86);
            this.btnkayitliste.Name = "btnkayitliste";
            this.btnkayitliste.Size = new System.Drawing.Size(210, 37);
            this.btnkayitliste.TabIndex = 0;
            this.btnkayitliste.Text = "Kayit Listele";
            this.btnkayitliste.UseVisualStyleBackColor = true;
            this.btnkayitliste.Click += new System.EventHandler(this.btnkayitliste_Click);
            // 
            // btnYenikayit
            // 
            this.btnYenikayit.Location = new System.Drawing.Point(6, 33);
            this.btnYenikayit.Name = "btnYenikayit";
            this.btnYenikayit.Size = new System.Drawing.Size(210, 37);
            this.btnYenikayit.TabIndex = 0;
            this.btnYenikayit.Text = "Yeni Kayit";
            this.btnYenikayit.UseVisualStyleBackColor = true;
            this.btnYenikayit.Click += new System.EventHandler(this.btnYenikayit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblzaman);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(1372, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 51);
            this.panel1.TabIndex = 2;
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Location = new System.Drawing.Point(3, 16);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(135, 20);
            this.lblzaman.TabIndex = 0;
            this.lblzaman.Text = "12.02.2022 17:43";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Islemlistesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TodoUygulmasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Islemlistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbIslemliste.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Islemlistesi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbIslemliste;
        private System.Windows.Forms.Button btnuygulamakapa;
        private System.Windows.Forms.Button btnkayitliste;
        private System.Windows.Forms.Button btnYenikayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Timer tm_zaman;
    }
}

