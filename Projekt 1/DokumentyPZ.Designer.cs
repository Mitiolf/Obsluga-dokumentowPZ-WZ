
namespace Projekt_1
{
    partial class DokumentyPZ
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnSpecyfikacje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOSTAWCA_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARTOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpowrot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 237);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(106, 237);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.usun_Click);
            // 
            // btnSpecyfikacje
            // 
            this.btnSpecyfikacje.Location = new System.Drawing.Point(199, 237);
            this.btnSpecyfikacje.Name = "btnSpecyfikacje";
            this.btnSpecyfikacje.Size = new System.Drawing.Size(82, 23);
            this.btnSpecyfikacje.TabIndex = 2;
            this.btnSpecyfikacje.Text = "Specyfikacje";
            this.btnSpecyfikacje.UseVisualStyleBackColor = true;
            this.btnSpecyfikacje.Click += new System.EventHandler(this.specyfikacje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PZ,
            this.NR_PZ,
            this.DATA_PZ,
            this.DOSTAWCA_PZ,
            this.WARTOSC});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID_PZ
            // 
            this.ID_PZ.HeaderText = "ID_PZ";
            this.ID_PZ.Name = "ID_PZ";
            this.ID_PZ.ReadOnly = true;
            this.ID_PZ.Width = 300;
            // 
            // NR_PZ
            // 
            this.NR_PZ.HeaderText = "NR_PZ";
            this.NR_PZ.Name = "NR_PZ";
            this.NR_PZ.ReadOnly = true;
            // 
            // DATA_PZ
            // 
            this.DATA_PZ.HeaderText = "DATA_PZ";
            this.DATA_PZ.Name = "DATA_PZ";
            this.DATA_PZ.ReadOnly = true;
            // 
            // DOSTAWCA_PZ
            // 
            this.DOSTAWCA_PZ.HeaderText = "DOSTAWCA_PZ";
            this.DOSTAWCA_PZ.Name = "DOSTAWCA_PZ";
            this.DOSTAWCA_PZ.ReadOnly = true;
            // 
            // WARTOSC
            // 
            this.WARTOSC.HeaderText = "WARTOSC";
            this.WARTOSC.Name = "WARTOSC";
            this.WARTOSC.ReadOnly = true;
            // 
            // btnpowrot
            // 
            this.btnpowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpowrot.Location = new System.Drawing.Point(12, 12);
            this.btnpowrot.Name = "btnpowrot";
            this.btnpowrot.Size = new System.Drawing.Size(48, 31);
            this.btnpowrot.TabIndex = 4;
            this.btnpowrot.Text = "<";
            this.btnpowrot.UseVisualStyleBackColor = true;
            this.btnpowrot.Click += new System.EventHandler(this.btnpowrot_Click);
            // 
            // DokumentyPZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 281);
            this.Controls.Add(this.btnpowrot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpecyfikacje);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DokumentyPZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokumentyPZ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DokumentyPZ_FormClosed);
            this.Load += new System.EventHandler(this.DokumentyPZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnSpecyfikacje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOSTAWCA_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARTOSC;
        private System.Windows.Forms.Button btnpowrot;
    }
}