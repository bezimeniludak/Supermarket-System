
namespace Projekat_II
{
    partial class FrmRacun
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
            this.components = new System.ComponentModel.Container();
            this.prodavnicaDataSet = new Projekat_II.ProdavnicaDataSet();
            this.racuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racuniTableAdapter = new Projekat_II.ProdavnicaDataSetTableAdapters.RacuniTableAdapter();
            this.tableAdapterManager = new Projekat_II.ProdavnicaDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racuniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prodavnicaDataSet
            // 
            this.prodavnicaDataSet.DataSetName = "ProdavnicaDataSet";
            this.prodavnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racuniBindingSource
            // 
            this.racuniBindingSource.DataMember = "Racuni";
            this.racuniBindingSource.DataSource = this.prodavnicaDataSet;
            // 
            // racuniTableAdapter
            // 
            this.racuniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProizvodiTableAdapter = null;
            this.tableAdapterManager.RacuniTableAdapter = this.racuniTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projekat_II.ProdavnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racuniDataGridView
            // 
            this.racuniDataGridView.AutoGenerateColumns = false;
            this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.racuniDataGridView.DataSource = this.racuniBindingSource;
            this.racuniDataGridView.Location = new System.Drawing.Point(12, 12);
            this.racuniDataGridView.Name = "racuniDataGridView";
            this.racuniDataGridView.Size = new System.Drawing.Size(924, 546);
            this.racuniDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ukupna_cena";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ukupna_cena";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Trenutno_vreme";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trenutno_vreme";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum_izdavanja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum_izdavanja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 570);
            this.Controls.Add(this.racuniDataGridView);
            this.Name = "FrmRacun";
            this.Text = "FrmRacun";
            this.Load += new System.EventHandler(this.FrmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProdavnicaDataSet prodavnicaDataSet;
        private System.Windows.Forms.BindingSource racuniBindingSource;
        private ProdavnicaDataSetTableAdapters.RacuniTableAdapter racuniTableAdapter;
        private ProdavnicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView racuniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}