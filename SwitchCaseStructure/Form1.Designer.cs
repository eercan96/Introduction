
namespace SwitchCaseStructure
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
            this.btnIcIceSwitch = new System.Windows.Forms.Button();
            this.btnKullaniciKontrolu = new System.Windows.Forms.Button();
            this.txtIkinciGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIcIceSwitch
            // 
            this.btnIcIceSwitch.Location = new System.Drawing.Point(318, 263);
            this.btnIcIceSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnIcIceSwitch.Name = "btnIcIceSwitch";
            this.btnIcIceSwitch.Size = new System.Drawing.Size(164, 25);
            this.btnIcIceSwitch.TabIndex = 19;
            this.btnIcIceSwitch.Text = "İÇ İÇE SWITCH";
            this.btnIcIceSwitch.UseVisualStyleBackColor = true;
            this.btnIcIceSwitch.Click += new System.EventHandler(this.btnIcIceSwitch_Click);
            // 
            // btnKullaniciKontrolu
            // 
            this.btnKullaniciKontrolu.Location = new System.Drawing.Point(318, 234);
            this.btnKullaniciKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnKullaniciKontrolu.Name = "btnKullaniciKontrolu";
            this.btnKullaniciKontrolu.Size = new System.Drawing.Size(164, 25);
            this.btnKullaniciKontrolu.TabIndex = 18;
            this.btnKullaniciKontrolu.Text = "KULLANICI GİRİŞ";
            this.btnKullaniciKontrolu.UseVisualStyleBackColor = true;
            this.btnKullaniciKontrolu.Click += new System.EventHandler(this.btnKullaniciKontrolu_Click);
            // 
            // txtIkinciGirisAlani
            // 
            this.txtIkinciGirisAlani.Location = new System.Drawing.Point(318, 184);
            this.txtIkinciGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtIkinciGirisAlani.Name = "txtIkinciGirisAlani";
            this.txtIkinciGirisAlani.Size = new System.Drawing.Size(165, 20);
            this.txtIkinciGirisAlani.TabIndex = 17;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(318, 204);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(164, 25);
            this.btnOnayla.TabIndex = 16;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(318, 163);
            this.txtGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(165, 20);
            this.txtGirisAlani.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIcIceSwitch);
            this.Controls.Add(this.btnKullaniciKontrolu);
            this.Controls.Add(this.txtIkinciGirisAlani);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIcIceSwitch;
        private System.Windows.Forms.Button btnKullaniciKontrolu;
        private System.Windows.Forms.TextBox txtIkinciGirisAlani;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

