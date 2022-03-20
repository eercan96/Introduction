
namespace TryCatch
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
            this.btnFinallyOnayla = new System.Windows.Forms.Button();
            this.btnDetayliOnayla = new System.Windows.Forms.Button();
            this.btnHataYonetimliOnayla = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFinallyOnayla
            // 
            this.btnFinallyOnayla.Location = new System.Drawing.Point(193, 310);
            this.btnFinallyOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinallyOnayla.Name = "btnFinallyOnayla";
            this.btnFinallyOnayla.Size = new System.Drawing.Size(418, 68);
            this.btnFinallyOnayla.TabIndex = 23;
            this.btnFinallyOnayla.Text = "ONAYLA - HATA YÖNETİMLİ (FINALLY BLOĞU)";
            this.btnFinallyOnayla.UseVisualStyleBackColor = true;
            this.btnFinallyOnayla.Click += new System.EventHandler(this.btnFinallyOnayla_Click);
            // 
            // btnDetayliOnayla
            // 
            this.btnDetayliOnayla.Location = new System.Drawing.Point(193, 250);
            this.btnDetayliOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetayliOnayla.Name = "btnDetayliOnayla";
            this.btnDetayliOnayla.Size = new System.Drawing.Size(418, 56);
            this.btnDetayliOnayla.TabIndex = 22;
            this.btnDetayliOnayla.Text = "ONAYLA - HATA YÖNETİMLİ (SİSTEM MESAJI)";
            this.btnDetayliOnayla.UseVisualStyleBackColor = true;
            this.btnDetayliOnayla.Click += new System.EventHandler(this.btnDetayliOnayla_Click);
            // 
            // btnHataYonetimliOnayla
            // 
            this.btnHataYonetimliOnayla.Location = new System.Drawing.Point(190, 191);
            this.btnHataYonetimliOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnHataYonetimliOnayla.Name = "btnHataYonetimliOnayla";
            this.btnHataYonetimliOnayla.Size = new System.Drawing.Size(421, 55);
            this.btnHataYonetimliOnayla.TabIndex = 21;
            this.btnHataYonetimliOnayla.Text = "ONAYLA - HATA YÖNETİMLİ";
            this.btnHataYonetimliOnayla.UseVisualStyleBackColor = true;
            this.btnHataYonetimliOnayla.Click += new System.EventHandler(this.btnHataYonetimliOnayla_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(193, 128);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(418, 59);
            this.btnOnayla.TabIndex = 20;
            this.btnOnayla.Text = "ONAYLA - HATA YÖNETİMSİZ";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lütfen telefon numaranızı giriniz:";
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(193, 88);
            this.txtGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(336, 20);
            this.txtGirisAlani.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinallyOnayla);
            this.Controls.Add(this.btnDetayliOnayla);
            this.Controls.Add(this.btnHataYonetimliOnayla);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinallyOnayla;
        private System.Windows.Forms.Button btnDetayliOnayla;
        private System.Windows.Forms.Button btnHataYonetimliOnayla;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

