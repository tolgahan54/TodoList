
namespace TodoUygulması
{
    partial class yenikayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkisaacik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtonem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxdurum = new System.Windows.Forms.ComboBox();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(118, 12);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(255, 22);
            this.txtbaslik.TabIndex = 0;
            this.txtbaslik.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtbaslik.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txtkisaacik
            // 
            this.txtkisaacik.Location = new System.Drawing.Point(118, 40);
            this.txtkisaacik.Multiline = true;
            this.txtkisaacik.Name = "txtkisaacik";
            this.txtkisaacik.Size = new System.Drawing.Size(255, 96);
            this.txtkisaacik.TabIndex = 1;
            this.txtkisaacik.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtkisaacik.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(118, 142);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(255, 96);
            this.txtaciklama.TabIndex = 2;
            this.txtaciklama.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtaciklama.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // txtonem
            // 
            this.txtonem.Location = new System.Drawing.Point(118, 244);
            this.txtonem.Name = "txtonem";
            this.txtonem.Size = new System.Drawing.Size(255, 22);
            this.txtonem.TabIndex = 3;
            this.txtonem.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtonem.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // cbxdurum
            // 
            this.cbxdurum.FormattingEnabled = true;
            this.cbxdurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanmadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cbxdurum.Location = new System.Drawing.Point(118, 272);
            this.cbxdurum.Name = "cbxdurum";
            this.cbxdurum.Size = new System.Drawing.Size(255, 24);
            this.cbxdurum.TabIndex = 4;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(118, 302);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(255, 27);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "Yenikayit";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // yenikayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 343);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.cbxdurum);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtkisaacik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtonem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yenikayit";
            this.Text = "Todo-Yenikeyit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkisaacik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtonem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxdurum;
        private System.Windows.Forms.Button btnyenikayit;
    }
}