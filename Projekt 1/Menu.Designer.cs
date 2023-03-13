
namespace Projekt_1
{
    partial class Menu
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
            this.btnDokumentyPZ = new System.Windows.Forms.Button();
            this.btnDokumentyWZ = new System.Windows.Forms.Button();
            this.btnMagazyn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDokumentyPZ
            // 
            this.btnDokumentyPZ.Location = new System.Drawing.Point(65, 70);
            this.btnDokumentyPZ.Name = "btnDokumentyPZ";
            this.btnDokumentyPZ.Size = new System.Drawing.Size(160, 30);
            this.btnDokumentyPZ.TabIndex = 0;
            this.btnDokumentyPZ.Text = "Dokumenty PZ";
            this.btnDokumentyPZ.UseVisualStyleBackColor = true;
            this.btnDokumentyPZ.Click += new System.EventHandler(this.btnDokumentyPZ_Click);
            // 
            // btnDokumentyWZ
            // 
            this.btnDokumentyWZ.Location = new System.Drawing.Point(65, 125);
            this.btnDokumentyWZ.Name = "btnDokumentyWZ";
            this.btnDokumentyWZ.Size = new System.Drawing.Size(160, 30);
            this.btnDokumentyWZ.TabIndex = 1;
            this.btnDokumentyWZ.Text = "Dokumenty WZ";
            this.btnDokumentyWZ.UseVisualStyleBackColor = true;
            this.btnDokumentyWZ.Click += new System.EventHandler(this.btnDokumentyWZ_Click);
            // 
            // btnMagazyn
            // 
            this.btnMagazyn.Location = new System.Drawing.Point(65, 180);
            this.btnMagazyn.Name = "btnMagazyn";
            this.btnMagazyn.Size = new System.Drawing.Size(160, 30);
            this.btnMagazyn.TabIndex = 2;
            this.btnMagazyn.Text = "Magazyn";
            this.btnMagazyn.UseVisualStyleBackColor = true;
            this.btnMagazyn.Click += new System.EventHandler(this.btnMagazyn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kto się zalogował: {name}";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMagazyn);
            this.Controls.Add(this.btnDokumentyWZ);
            this.Controls.Add(this.btnDokumentyPZ);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDokumentyPZ;
        private System.Windows.Forms.Button btnDokumentyWZ;
        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Label label1;
    }
}