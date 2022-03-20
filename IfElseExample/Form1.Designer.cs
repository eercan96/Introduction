
namespace IfElseExample
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
            this.btnSatisIslemi = new System.Windows.Forms.Button();
            this.btnMarketKontrolu = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnGirisKontrolu = new System.Windows.Forms.Button();
            this.txtIkinciDeger = new System.Windows.Forms.TextBox();
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSatisIslemi
            // 
            this.btnSatisIslemi.Location = new System.Drawing.Point(302, 282);
            this.btnSatisIslemi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatisIslemi.Name = "btnSatisIslemi";
            this.btnSatisIslemi.Size = new System.Drawing.Size(196, 31);
            this.btnSatisIslemi.TabIndex = 23;
            this.btnSatisIslemi.Text = "SATIŞ İŞLEMİ";
            this.btnSatisIslemi.UseVisualStyleBackColor = true;
            this.btnSatisIslemi.Click += new System.EventHandler(this.btnSatisIslemi_Click);
            // 
            // btnMarketKontrolu
            // 
            this.btnMarketKontrolu.Location = new System.Drawing.Point(302, 248);
            this.btnMarketKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarketKontrolu.Name = "btnMarketKontrolu";
            this.btnMarketKontrolu.Size = new System.Drawing.Size(196, 31);
            this.btnMarketKontrolu.TabIndex = 22;
            this.btnMarketKontrolu.Text = "MARKET KONTROLÜ";
            this.btnMarketKontrolu.UseVisualStyleBackColor = true;
            this.btnMarketKontrolu.Click += new System.EventHandler(this.btnMarketKontrolu_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Location = new System.Drawing.Point(302, 214);
            this.btnNotKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(196, 31);
            this.btnNotKontrolu.TabIndex = 21;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.btnNotKontrolu_Click);
            // 
            // btnGirisKontrolu
            // 
            this.btnGirisKontrolu.Location = new System.Drawing.Point(302, 179);
            this.btnGirisKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnGirisKontrolu.Name = "btnGirisKontrolu";
            this.btnGirisKontrolu.Size = new System.Drawing.Size(196, 31);
            this.btnGirisKontrolu.TabIndex = 20;
            this.btnGirisKontrolu.Text = "GİRİŞ BİLGİ KONTROLÜ";
            this.btnGirisKontrolu.UseVisualStyleBackColor = true;
            this.btnGirisKontrolu.Click += new System.EventHandler(this.btnGirisKontrolu_Click);
            // 
            // txtIkinciDeger
            // 
            this.txtIkinciDeger.Location = new System.Drawing.Point(302, 158);
            this.txtIkinciDeger.Margin = new System.Windows.Forms.Padding(2);
            this.txtIkinciDeger.Name = "txtIkinciDeger";
            this.txtIkinciDeger.Size = new System.Drawing.Size(197, 20);
            this.txtIkinciDeger.TabIndex = 19;
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Location = new System.Drawing.Point(302, 137);
            this.txtBirinciDeger.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(197, 20);
            this.txtBirinciDeger.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSatisIslemi);
            this.Controls.Add(this.btnMarketKontrolu);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnGirisKontrolu);
            this.Controls.Add(this.txtIkinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatisIslemi;
        private System.Windows.Forms.Button btnMarketKontrolu;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnGirisKontrolu;
        private System.Windows.Forms.TextBox txtIkinciDeger;
        private System.Windows.Forms.TextBox txtBirinciDeger;
    }
}

