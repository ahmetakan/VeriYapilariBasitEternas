
namespace VeriYapilariODEV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.grpEternas = new System.Windows.Forms.GroupBox();
            this.rtbAdimlar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNasilOynanir = new System.Windows.Forms.Label();
            this.rtbEternasOyunu = new System.Windows.Forms.RichTextBox();
            this.picEternas = new System.Windows.Forms.PictureBox();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.grpEternas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEternas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(433, 527);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(141, 36);
            this.btnOyunuBaslat.TabIndex = 0;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // grpEternas
            // 
            this.grpEternas.Controls.Add(this.rtbAdimlar);
            this.grpEternas.Controls.Add(this.label1);
            this.grpEternas.Controls.Add(this.lblNasilOynanir);
            this.grpEternas.Controls.Add(this.rtbEternasOyunu);
            this.grpEternas.Controls.Add(this.picEternas);
            this.grpEternas.Controls.Add(this.lblBilgilendirme);
            this.grpEternas.Controls.Add(this.btnOyunuBaslat);
            this.grpEternas.Location = new System.Drawing.Point(12, 12);
            this.grpEternas.Name = "grpEternas";
            this.grpEternas.Size = new System.Drawing.Size(608, 580);
            this.grpEternas.TabIndex = 1;
            this.grpEternas.TabStop = false;
            this.grpEternas.Text = "Eternas Oyunu";
            // 
            // rtbAdimlar
            // 
            this.rtbAdimlar.Location = new System.Drawing.Point(433, 83);
            this.rtbAdimlar.Name = "rtbAdimlar";
            this.rtbAdimlar.Size = new System.Drawing.Size(141, 426);
            this.rtbAdimlar.TabIndex = 5;
            this.rtbAdimlar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(425, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Durumlar";
            // 
            // lblNasilOynanir
            // 
            this.lblNasilOynanir.AutoSize = true;
            this.lblNasilOynanir.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNasilOynanir.Location = new System.Drawing.Point(94, 332);
            this.lblNasilOynanir.Name = "lblNasilOynanir";
            this.lblNasilOynanir.Size = new System.Drawing.Size(236, 45);
            this.lblNasilOynanir.TabIndex = 4;
            this.lblNasilOynanir.Text = "Nasıl Oynanır?";
            // 
            // rtbEternasOyunu
            // 
            this.rtbEternasOyunu.Enabled = false;
            this.rtbEternasOyunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbEternasOyunu.Location = new System.Drawing.Point(21, 380);
            this.rtbEternasOyunu.Name = "rtbEternasOyunu";
            this.rtbEternasOyunu.Size = new System.Drawing.Size(382, 125);
            this.rtbEternasOyunu.TabIndex = 3;
            this.rtbEternasOyunu.Text = resources.GetString("rtbEternasOyunu.Text");
            // 
            // picEternas
            // 
            this.picEternas.Image = ((System.Drawing.Image)(resources.GetObject("picEternas.Image")));
            this.picEternas.Location = new System.Drawing.Point(21, 46);
            this.picEternas.Name = "picEternas";
            this.picEternas.Size = new System.Drawing.Size(382, 283);
            this.picEternas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEternas.TabIndex = 2;
            this.picEternas.TabStop = false;
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.Location = new System.Drawing.Point(48, 516);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(331, 21);
            this.lblBilgilendirme.TabIndex = 1;
            this.lblBilgilendirme.Text = "Oyunu başlatmak için lütfen butona tıklayınız.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 604);
            this.Controls.Add(this.grpEternas);
            this.Name = "Form1";
            this.Text = "Eternas Oyunu";
            this.grpEternas.ResumeLayout(false);
            this.grpEternas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEternas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOyunuBaslat;
        private System.Windows.Forms.GroupBox grpEternas;
        private System.Windows.Forms.PictureBox picEternas;
        private System.Windows.Forms.Label lblBilgilendirme;
        private System.Windows.Forms.Label lblNasilOynanir;
        private System.Windows.Forms.RichTextBox rtbEternasOyunu;
        private System.Windows.Forms.RichTextBox rtbAdimlar;
        private System.Windows.Forms.Label label1;
    }
}

