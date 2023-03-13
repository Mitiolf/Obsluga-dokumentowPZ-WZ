
namespace Projekt_1
{
    partial class SpecyfikacjeWZ
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
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_TOWARU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA_TOWARU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ILOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENA_ZAKUPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENA_SPRZEDAZY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpowrot
            // 
            this.btnpowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpowrot.Location = new System.Drawing.Point(12, 12);
            this.btnpowrot.Name = "btnpowrot";
            this.btnpowrot.Size = new System.Drawing.Size(48, 31);
            this.btnpowrot.TabIndex = 7;
            this.btnpowrot.Text = "<";
            this.btnpowrot.UseVisualStyleBackColor = true;
            this.btnpowrot.Click += new System.EventHandler(this.btnpowrot_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(104, 236);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 236);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TOWARU,
            this.NAZWA_TOWARU,
            this.ILOSC,
            this.CENA_ZAKUPU,
            this.CENA_SPRZEDAZY});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID_TOWARU
            // 
            this.ID_TOWARU.HeaderText = "ID_TOWARU";
            this.ID_TOWARU.Name = "ID_TOWARU";
            this.ID_TOWARU.ReadOnly = true;
            // 
            // NAZWA_TOWARU
            // 
            this.NAZWA_TOWARU.HeaderText = "NAZWA_TOWARU";
            this.NAZWA_TOWARU.Name = "NAZWA_TOWARU";
            this.NAZWA_TOWARU.ReadOnly = true;
            this.NAZWA_TOWARU.Width = 120;
            // 
            // ILOSC
            // 
            this.ILOSC.HeaderText = "ILOSC";
            this.ILOSC.Name = "ILOSC";
            this.ILOSC.ReadOnly = true;
            // 
            // CENA_ZAKUPU
            // 
            this.CENA_ZAKUPU.HeaderText = "CENA_ZAKUPU";
            this.CENA_ZAKUPU.Name = "CENA_ZAKUPU";
            this.CENA_ZAKUPU.ReadOnly = true;
            // 
            // CENA_SPRZEDAZY
            // 
            this.CENA_SPRZEDAZY.HeaderText = "CENA_SPRZEDAZY";
            this.CENA_SPRZEDAZY.Name = "CENA_SPRZEDAZY";
            this.CENA_SPRZEDAZY.ReadOnly = true;
            this.CENA_SPRZEDAZY.Width = 120;
            // 
            // SpecyfikacjeWZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.btnpowrot);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpecyfikacjeWZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecyfikacjeWZ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpecyfikacjeWZ_FormClosed);
            this.Load += new System.EventHandler(this.SpecyfikacjeWZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpowrot;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TOWARU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_TOWARU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ILOSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENA_ZAKUPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENA_SPRZEDAZY;
    }
}