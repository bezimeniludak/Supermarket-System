
namespace Projekat_II
{
    partial class FrmGlavniMeni
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoviProizvod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRacun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlati = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnIsprazni = new System.Windows.Forms.Button();
            this.btnPribor = new System.Windows.Forms.Button();
            this.btnHigijena = new System.Windows.Forms.Button();
            this.btnOsnovno = new System.Windows.Forms.Button();
            this.btnSlatko = new System.Windows.Forms.Button();
            this.btnVoce = new System.Windows.Forms.Button();
            this.btnMleko = new System.Windows.Forms.Button();
            this.btnPice = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorije:";
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNoviProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviProizvod.Location = new System.Drawing.Point(161, 488);
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Size = new System.Drawing.Size(139, 70);
            this.btnNoviProizvod.TabIndex = 1;
            this.btnNoviProizvod.Text = "Dodajte novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = true;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(791, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Racun:";
            // 
            // lblRacun
            // 
            this.lblRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRacun.AutoSize = true;
            this.lblRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacun.Location = new System.Drawing.Point(857, 63);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(79, 20);
            this.lblRacun.TabIndex = 10;
            this.lblRacun.Text = "0.00 RSD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Korpa:";
            // 
            // btnPlati
            // 
            this.btnPlati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlati.Location = new System.Drawing.Point(748, 502);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(151, 56);
            this.btnPlati.TabIndex = 13;
            this.btnPlati.Text = "Plati";
            this.btnPlati.UseVisualStyleBackColor = true;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(489, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(447, 324);
            this.listBox1.TabIndex = 14;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(526, 422);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(151, 56);
            this.btnIzbaci.TabIndex = 15;
            this.btnIzbaci.Text = "Izbaci proizvod";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnIsprazni
            // 
            this.btnIsprazni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIsprazni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsprazni.Location = new System.Drawing.Point(526, 502);
            this.btnIsprazni.Name = "btnIsprazni";
            this.btnIsprazni.Size = new System.Drawing.Size(151, 56);
            this.btnIsprazni.TabIndex = 16;
            this.btnIsprazni.Text = "Isprazni korpu";
            this.btnIsprazni.UseVisualStyleBackColor = true;
            this.btnIsprazni.Click += new System.EventHandler(this.btnIsprazni_Click);
            // 
            // btnPribor
            // 
            this.btnPribor.BackColor = System.Drawing.Color.White;
            this.btnPribor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPribor.Image = global::Projekat_II.Properties.Resources.pribor;
            this.btnPribor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPribor.Location = new System.Drawing.Point(161, 342);
            this.btnPribor.Name = "btnPribor";
            this.btnPribor.Size = new System.Drawing.Size(139, 122);
            this.btnPribor.TabIndex = 8;
            this.btnPribor.Text = "Kancelarijski i školski pribor";
            this.btnPribor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPribor.UseVisualStyleBackColor = false;
            this.btnPribor.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnHigijena
            // 
            this.btnHigijena.BackColor = System.Drawing.Color.White;
            this.btnHigijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigijena.Image = global::Projekat_II.Properties.Resources.kozmetika;
            this.btnHigijena.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHigijena.Location = new System.Drawing.Point(310, 86);
            this.btnHigijena.Name = "btnHigijena";
            this.btnHigijena.Size = new System.Drawing.Size(139, 122);
            this.btnHigijena.TabIndex = 7;
            this.btnHigijena.Text = "Lična higijena i kozmetika";
            this.btnHigijena.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHigijena.UseVisualStyleBackColor = false;
            this.btnHigijena.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnOsnovno
            // 
            this.btnOsnovno.BackColor = System.Drawing.Color.White;
            this.btnOsnovno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsnovno.Image = global::Projekat_II.Properties.Resources.osnovno;
            this.btnOsnovno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOsnovno.Location = new System.Drawing.Point(161, 214);
            this.btnOsnovno.Name = "btnOsnovno";
            this.btnOsnovno.Size = new System.Drawing.Size(139, 122);
            this.btnOsnovno.TabIndex = 6;
            this.btnOsnovno.Text = "Osnovne namirnice";
            this.btnOsnovno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOsnovno.UseVisualStyleBackColor = false;
            this.btnOsnovno.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnSlatko
            // 
            this.btnSlatko.BackColor = System.Drawing.Color.White;
            this.btnSlatko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlatko.Image = global::Projekat_II.Properties.Resources.slatko;
            this.btnSlatko.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSlatko.Location = new System.Drawing.Point(310, 214);
            this.btnSlatko.Name = "btnSlatko";
            this.btnSlatko.Size = new System.Drawing.Size(139, 122);
            this.btnSlatko.TabIndex = 5;
            this.btnSlatko.Text = "Slatki i slani konditori";
            this.btnSlatko.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSlatko.UseVisualStyleBackColor = false;
            this.btnSlatko.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnVoce
            // 
            this.btnVoce.BackColor = System.Drawing.Color.White;
            this.btnVoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoce.Image = global::Projekat_II.Properties.Resources.vocepovrce;
            this.btnVoce.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoce.Location = new System.Drawing.Point(12, 214);
            this.btnVoce.Name = "btnVoce";
            this.btnVoce.Size = new System.Drawing.Size(139, 122);
            this.btnVoce.TabIndex = 4;
            this.btnVoce.Text = "Voce i povrce";
            this.btnVoce.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoce.UseVisualStyleBackColor = false;
            this.btnVoce.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnMleko
            // 
            this.btnMleko.BackColor = System.Drawing.Color.White;
            this.btnMleko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMleko.Image = global::Projekat_II.Properties.Resources.mleko;
            this.btnMleko.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMleko.Location = new System.Drawing.Point(161, 86);
            this.btnMleko.Name = "btnMleko";
            this.btnMleko.Size = new System.Drawing.Size(139, 122);
            this.btnMleko.TabIndex = 3;
            this.btnMleko.Text = "Mlecni proizvodi";
            this.btnMleko.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMleko.UseVisualStyleBackColor = false;
            this.btnMleko.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnPice
            // 
            this.btnPice.BackColor = System.Drawing.Color.White;
            this.btnPice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPice.Image = global::Projekat_II.Properties.Resources.pice;
            this.btnPice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPice.Location = new System.Drawing.Point(12, 86);
            this.btnPice.Name = "btnPice";
            this.btnPice.Size = new System.Drawing.Size(139, 122);
            this.btnPice.TabIndex = 2;
            this.btnPice.Text = "Pice, kafa i caj";
            this.btnPice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPice.UseVisualStyleBackColor = false;
            this.btnPice.Click += new System.EventHandler(this.DodajProizvod);
            // 
            // btnRacuni
            // 
            this.btnRacuni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacuni.Location = new System.Drawing.Point(748, 422);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(151, 56);
            this.btnRacuni.TabIndex = 17;
            this.btnRacuni.Text = "Prikaz svih racuna";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // FrmGlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 570);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnIsprazni);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPlati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPribor);
            this.Controls.Add(this.btnHigijena);
            this.Controls.Add(this.btnOsnovno);
            this.Controls.Add(this.btnSlatko);
            this.Controls.Add(this.btnVoce);
            this.Controls.Add(this.btnMleko);
            this.Controls.Add(this.btnPice);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.label1);
            this.Name = "FrmGlavniMeni";
            this.Text = "FrmGlavniMeni";
            this.Load += new System.EventHandler(this.FrmGlavniMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoviProizvod;
        private System.Windows.Forms.Button btnPice;
        private System.Windows.Forms.Button btnMleko;
        private System.Windows.Forms.Button btnVoce;
        private System.Windows.Forms.Button btnSlatko;
        private System.Windows.Forms.Button btnOsnovno;
        private System.Windows.Forms.Button btnHigijena;
        private System.Windows.Forms.Button btnPribor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlati;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnIsprazni;
        private System.Windows.Forms.Button btnRacuni;
    }
}