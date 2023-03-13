
namespace Projekt_1
{
    partial class Magazyn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSzczegoły = new System.Windows.Forms.Button();
            this.btnpowrot = new System.Windows.Forms.Button();
            this.ID_TOWARU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA_TOWARU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ILOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARTOSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TOWARU,
            this.NAZWA_TOWARU,
            this.ILOSC,
            this.WARTOSC});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnSzczegoły
            // 
            this.btnSzczegoły.Location = new System.Drawing.Point(12, 237);
            this.btnSzczegoły.Name = "btnSzczegoły";
            this.btnSzczegoły.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoły.TabIndex = 11;
            this.btnSzczegoły.Text = "Szczegóły";
            this.btnSzczegoły.UseVisualStyleBackColor = true;
            this.btnSzczegoły.Click += new System.EventHandler(this.btnSzczegoły_Click);
            // 
            // btnpowrot
            // 
            this.btnpowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpowrot.Location = new System.Drawing.Point(12, 12);
            this.btnpowrot.Name = "btnpowrot";
            this.btnpowrot.Size = new System.Drawing.Size(48, 31);
            this.btnpowrot.TabIndex = 13;
            this.btnpowrot.Text = "<";
            this.btnpowrot.UseVisualStyleBackColor = true;
            this.btnpowrot.Click += new System.EventHandler(this.btnpowrot_Click);
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
            // WARTOSC
            // 
            this.WARTOSC.HeaderText = "WARTOSC";
            this.WARTOSC.Name = "WARTOSC";
            this.WARTOSC.ReadOnly = true;
            this.WARTOSC.Width = 90;
            // 
            // Magazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 281);
            this.Controls.Add(this.btnpowrot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSzczegoły);
            this.Name = "Magazyn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Magazyn_FormClosed);
            this.Load += new System.EventHandler(this.Magazyn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSzczegoły;
        private System.Windows.Forms.Button btnpowrot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TOWARU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_TOWARU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ILOSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARTOSC;
    }
}