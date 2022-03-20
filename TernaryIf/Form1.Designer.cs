
namespace TernaryIf
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnTernaryIf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(266, 139);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(269, 20);
            this.txtSayi.TabIndex = 3;
            this.txtSayi.Text = "Lütfen  mutlak değere alınacak sayıyı giriniz...";
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            // 
            // btnTernaryIf
            // 
            this.btnTernaryIf.Location = new System.Drawing.Point(303, 185);
            this.btnTernaryIf.Margin = new System.Windows.Forms.Padding(2);
            this.btnTernaryIf.Name = "btnTernaryIf";
            this.btnTernaryIf.Size = new System.Drawing.Size(167, 127);
            this.btnTernaryIf.TabIndex = 2;
            this.btnTernaryIf.Text = "TERNARY IF";
            this.btnTernaryIf.UseVisualStyleBackColor = true;
            this.btnTernaryIf.Click += new System.EventHandler(this.btnTernaryIf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnTernaryIf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnTernaryIf;
    }
}

