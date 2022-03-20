
namespace FormTransitions
{
    partial class Form2
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
            this.btnFormDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormDegistir
            // 
            this.btnFormDegistir.Location = new System.Drawing.Point(313, 162);
            this.btnFormDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormDegistir.Name = "btnFormDegistir";
            this.btnFormDegistir.Size = new System.Drawing.Size(174, 127);
            this.btnFormDegistir.TabIndex = 1;
            this.btnFormDegistir.Text = "Diğer Forma GERİ DÖN";
            this.btnFormDegistir.UseVisualStyleBackColor = true;
            this.btnFormDegistir.Click += new System.EventHandler(this.btnFormDegistir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormDegistir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormDegistir;
    }
}