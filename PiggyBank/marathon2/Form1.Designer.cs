
namespace marathon2
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
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.lblParaMiktari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamPara = new System.Windows.Forms.Label();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            this.cmbParalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnParaAt
            // 
            this.btnParaAt.Location = new System.Drawing.Point(354, 47);
            this.btnParaAt.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(136, 53);
            this.btnParaAt.TabIndex = 0;
            this.btnParaAt.Text = "Para At";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(354, 132);
            this.btnSalla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(136, 53);
            this.btnSalla.TabIndex = 1;
            this.btnSalla.Text = "Kumbarayı Salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKir
            // 
            this.btnKir.Location = new System.Drawing.Point(354, 220);
            this.btnKir.Margin = new System.Windows.Forms.Padding(4);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(136, 53);
            this.btnKir.TabIndex = 2;
            this.btnKir.Text = "Kumbarayı Kır";
            this.btnKir.UseVisualStyleBackColor = true;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(354, 302);
            this.btnYapistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(136, 53);
            this.btnYapistir.TabIndex = 3;
            this.btnYapistir.Text = "Kumbarayı Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // lblParaMiktari
            // 
            this.lblParaMiktari.AutoSize = true;
            this.lblParaMiktari.Location = new System.Drawing.Point(13, 47);
            this.lblParaMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParaMiktari.Name = "lblParaMiktari";
            this.lblParaMiktari.Size = new System.Drawing.Size(99, 16);
            this.lblParaMiktari.TabIndex = 4;
            this.lblParaMiktari.Text = "Para Seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Hacim:";
            // 
            // lblToplamPara
            // 
            this.lblToplamPara.AutoSize = true;
            this.lblToplamPara.Location = new System.Drawing.Point(176, 302);
            this.lblToplamPara.Name = "lblToplamPara";
            this.lblToplamPara.Size = new System.Drawing.Size(34, 16);
            this.lblToplamPara.TabIndex = 8;
            this.lblToplamPara.Text = "0TL";
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Location = new System.Drawing.Point(191, 339);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(16, 16);
            this.lblToplamHacim.TabIndex = 9;
            this.lblToplamHacim.Text = "0";
            // 
            // cmbParalar
            // 
            this.cmbParalar.FormattingEnabled = true;
            this.cmbParalar.Location = new System.Drawing.Point(140, 47);
            this.cmbParalar.Name = "cmbParalar";
            this.cmbParalar.Size = new System.Drawing.Size(136, 24);
            this.cmbParalar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::marathon2.Properties.Resources.piggyx;
            this.ClientSize = new System.Drawing.Size(518, 372);
            this.Controls.Add(this.cmbParalar);
            this.Controls.Add(this.lblToplamHacim);
            this.Controls.Add(this.lblToplamPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParaMiktari);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnParaAt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Piggy Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.Label lblParaMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamPara;
        private System.Windows.Forms.Label lblToplamHacim;
        private System.Windows.Forms.ComboBox cmbParalar;
    }
}

