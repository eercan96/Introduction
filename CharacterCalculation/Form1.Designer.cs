
namespace CharacterCalculation
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
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetinAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Location = new System.Drawing.Point(408, 249);
            this.lblKalanKarakter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(25, 13);
            this.lblKalanKarakter.TabIndex = 11;
            this.lblKalanKarakter.Text = "450";
            this.lblKalanKarakter.Click += new System.EventHandler(this.lblKalanKarakter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kalan Karakter Sayısı:";
            // 
            // txtMetinAlani
            // 
            this.txtMetinAlani.Location = new System.Drawing.Point(267, 189);
            this.txtMetinAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtMetinAlani.Multiline = true;
            this.txtMetinAlani.Name = "txtMetinAlani";
            this.txtMetinAlani.Size = new System.Drawing.Size(269, 52);
            this.txtMetinAlani.TabIndex = 9;
            this.txtMetinAlani.TextChanged += new System.EventHandler(this.txtMetinAlani_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetinAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalanKarakter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetinAlani;
    }
}

