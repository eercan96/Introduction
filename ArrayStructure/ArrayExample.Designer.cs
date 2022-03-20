
namespace ArrayStructure
{
    partial class ArrayExample
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btnElemanlariListboxaEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRastgeleEleman = new System.Windows.Forms.Button();
            this.btnSonElemaniGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(511, 169);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(59, 82);
            this.btn_ekle.TabIndex = 17;
            this.btn_ekle.Text = "button1";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btnElemanlariListboxaEkle
            // 
            this.btnElemanlariListboxaEkle.Location = new System.Drawing.Point(231, 212);
            this.btnElemanlariListboxaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnElemanlariListboxaEkle.Name = "btnElemanlariListboxaEkle";
            this.btnElemanlariListboxaEkle.Size = new System.Drawing.Size(203, 26);
            this.btnElemanlariListboxaEkle.TabIndex = 16;
            this.btnElemanlariListboxaEkle.Text = "ELEMANLARI LİSTBOX\'A EKLE";
            this.btnElemanlariListboxaEkle.UseVisualStyleBackColor = true;
            this.btnElemanlariListboxaEkle.Click += new System.EventHandler(this.btnElemanlariListboxaEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(231, 242);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 56);
            this.listBox1.TabIndex = 15;
            // 
            // btnRastgeleEleman
            // 
            this.btnRastgeleEleman.Location = new System.Drawing.Point(231, 182);
            this.btnRastgeleEleman.Margin = new System.Windows.Forms.Padding(2);
            this.btnRastgeleEleman.Name = "btnRastgeleEleman";
            this.btnRastgeleEleman.Size = new System.Drawing.Size(203, 26);
            this.btnRastgeleEleman.TabIndex = 14;
            this.btnRastgeleEleman.Text = "RASTGELE ELEMAN GÖSTER";
            this.btnRastgeleEleman.UseVisualStyleBackColor = true;
            this.btnRastgeleEleman.Click += new System.EventHandler(this.btnRastgeleEleman_Click);
            // 
            // btnSonElemaniGoster
            // 
            this.btnSonElemaniGoster.Location = new System.Drawing.Point(231, 152);
            this.btnSonElemaniGoster.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonElemaniGoster.Name = "btnSonElemaniGoster";
            this.btnSonElemaniGoster.Size = new System.Drawing.Size(203, 26);
            this.btnSonElemaniGoster.TabIndex = 13;
            this.btnSonElemaniGoster.Text = "SON ELEMANI GÖSTER";
            this.btnSonElemaniGoster.UseVisualStyleBackColor = true;
            this.btnSonElemaniGoster.Click += new System.EventHandler(this.btnSonElemaniGoster_Click);
            // 
            // ArrayExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btnElemanlariListboxaEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRastgeleEleman);
            this.Controls.Add(this.btnSonElemaniGoster);
            this.Name = "ArrayExample";
            this.Text = "ArrayExample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btnElemanlariListboxaEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRastgeleEleman;
        private System.Windows.Forms.Button btnSonElemaniGoster;
    }
}