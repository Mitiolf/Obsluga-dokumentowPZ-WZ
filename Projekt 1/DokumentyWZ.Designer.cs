
namespace Projekt_1
{
    partial class DokumentyWZ
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
            this.btnpowrot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_WZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_WZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_WZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOSTAWCA_WZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARTOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSpecyfikacje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpowrot
            // 
            this.btnpowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpowrot.Location = new System.Drawing.Point(12, 12);
            this.btnpowrot.Name = "btnpowrot";
            this.btnpowrot.Size = new System.Drawing.Size(48, 31);
            this.btnpowrot.TabIndex = 9;
            this.btnpowrot.Text = "<";
            this.btnpowrot.UseVisualStyleBackColor = true;
            this.btnpowrot.Click += new System.EventHandler(this.btnpowrot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_WZ,
            this.NR_WZ,
            this.DATA_WZ,
            this.DOSTAWCA_WZ,
            this.WARTOSC});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // ID_WZ
            // 
            this.ID_WZ.HeaderText = "ID_WZ";
            this.ID_WZ.Name = "ID_WZ";
            this.ID_WZ.ReadOnly = true;
            this.ID_WZ.Width = 300;
            // 
            // NR_WZ
            // 
            this.NR_WZ.HeaderText = "NR_WZ";
            this.NR_WZ.Name = "NR_WZ";
            this.NR_WZ.ReadOnly = true;
            // 
            // DATA_WZ
            // 
            this.DATA_WZ.HeaderText = "DATA_WZ";
            this.DATA_WZ.Name = "DATA_WZ";
            this.DATA_WZ.ReadOnly = true;
            // 
            // DOSTAWCA_WZ
            // 
            this.DOSTAWCA_WZ.HeaderText = "DOSTAWCA_WZ";
            this.DOSTAWCA_WZ.Name = "DOSTAWCA_WZ";
            this.DOSTAWCA_WZ.ReadOnly = true;
            // 
            // WARTOSC
            // 
            this.WARTOSC.HeaderText = "WARTOSC";
            this.WARTOSC.Name = "WARTOSC";
            this.WARTOSC.ReadOnly = true;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(106, 235);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 235);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSpecyfikacje
            // 
            this.btnSpecyfikacje.Location = new System.Drawing.Point(200, 235);
            this.btnSpecyfikacje.Name = "btnSpecyfikacje";
            this.btnSpecyfikacje.Size = new System.Drawing.Size(79, 23);
            this.btnSpecyfikacje.TabIndex = 7;
            this.btnSpecyfikacje.Text = "Specyfikacje";
            this.btnSpecyfikacje.UseVisualStyleBackColor = true;
            this.btnSpecyfikacje.Click += new System.EventHandler(this.btnSpecyfikacje_Click);
            // 
            // DokumentyWZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 281);
            this.Controls.Add(this.btnpowrot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpecyfikacje);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DokumentyWZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokumentyWZ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DokumentyWZ_FormClosed);
            this.Load += new System.EventHandler(this.DokumentyWZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpowrot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_WZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_WZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_WZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOSTAWCA_WZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARTOSC;
        private System.Windows.Forms.Button btnSpecyfikacje;
    }
}