
namespace Projekat_II
{
    partial class FrmNoviProizvod
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
            System.Windows.Forms.Label kategorijaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label cenaLabel;
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            kategorijaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kategorijaLabel
            // 
            kategorijaLabel.AutoSize = true;
            kategorijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kategorijaLabel.Location = new System.Drawing.Point(111, 154);
            kategorijaLabel.Name = "kategorijaLabel";
            kategorijaLabel.Size = new System.Drawing.Size(84, 20);
            kategorijaLabel.TabIndex = 1;
            kategorijaLabel.Text = "Kategorija:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nazivLabel.Location = new System.Drawing.Point(144, 122);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(51, 20);
            nazivLabel.TabIndex = 3;
            nazivLabel.Text = "Naziv:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cenaLabel.Location = new System.Drawing.Point(144, 188);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(51, 20);
            cenaLabel.TabIndex = 5;
            cenaLabel.Text = "Cena:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(201, 151);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 28);
            this.cbKategorija.TabIndex = 2;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(201, 119);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 26);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(201, 185);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 26);
            this.txtCena.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodajte novi Proizvod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unesite podatke novog proizvoda";
            // 
            // FrmNoviProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(kategorijaLabel);
            this.Controls.Add(this.cbKategorija);
            this.Name = "FrmNoviProizvod";
            this.Text = "FrmNoviProizvod";
            this.Load += new System.EventHandler(this.FrmNoviProizvod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}