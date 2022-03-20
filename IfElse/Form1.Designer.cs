
namespace IfElseGeneral
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
            this.btnDegerKontrolu = new System.Windows.Forms.Button();
            this.btnCiftMiTekMi = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnAdminKontrolu = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDegerKontrolu
            // 
            this.btnDegerKontrolu.Location = new System.Drawing.Point(300, 267);
            this.btnDegerKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDegerKontrolu.Name = "btnDegerKontrolu";
            this.btnDegerKontrolu.Size = new System.Drawing.Size(200, 26);
            this.btnDegerKontrolu.TabIndex = 19;
            this.btnDegerKontrolu.Text = "DEĞER KONTROLÜ";
            this.btnDegerKontrolu.UseVisualStyleBackColor = true;
            this.btnDegerKontrolu.Click += new System.EventHandler(this.btnDegerKontrolu_Click);
            // 
            // btnCiftMiTekMi
            // 
            this.btnCiftMiTekMi.Location = new System.Drawing.Point(300, 238);
            this.btnCiftMiTekMi.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiftMiTekMi.Name = "btnCiftMiTekMi";
            this.btnCiftMiTekMi.Size = new System.Drawing.Size(200, 26);
            this.btnCiftMiTekMi.TabIndex = 18;
            this.btnCiftMiTekMi.Text = "ÇİFT - TEK KONTROLÜ";
            this.btnCiftMiTekMi.UseVisualStyleBackColor = true;
            this.btnCiftMiTekMi.Click += new System.EventHandler(this.btnCiftMiTekMi_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Location = new System.Drawing.Point(300, 208);
            this.btnNotKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(200, 26);
            this.btnNotKontrolu.TabIndex = 17;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.btnNotKontrolu_Click);
            // 
            // btnAdminKontrolu
            // 
            this.btnAdminKontrolu.Location = new System.Drawing.Point(300, 178);
            this.btnAdminKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminKontrolu.Name = "btnAdminKontrolu";
            this.btnAdminKontrolu.Size = new System.Drawing.Size(200, 26);
            this.btnAdminKontrolu.TabIndex = 16;
            this.btnAdminKontrolu.Text = "ADMİN KONTROLÜ";
            this.btnAdminKontrolu.UseVisualStyleBackColor = true;
            this.btnAdminKontrolu.Click += new System.EventHandler(this.btnAdminKontrolu_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(300, 157);
            this.txtGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(201, 20);
            this.txtGirisAlani.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDegerKontrolu);
            this.Controls.Add(this.btnCiftMiTekMi);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnAdminKontrolu);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegerKontrolu;
        private System.Windows.Forms.Button btnCiftMiTekMi;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnAdminKontrolu;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

