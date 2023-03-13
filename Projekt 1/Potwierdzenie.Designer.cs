
namespace Projekt_1
{
    partial class Potwierdzenie
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
            this.btnNie = new System.Windows.Forms.Button();
            this.btnTak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNie
            // 
            this.btnNie.Location = new System.Drawing.Point(37, 75);
            this.btnNie.Name = "btnNie";
            this.btnNie.Size = new System.Drawing.Size(75, 23);
            this.btnNie.TabIndex = 0;
            this.btnNie.Text = "Nie";
            this.btnNie.UseVisualStyleBackColor = true;
            this.btnNie.Click += new System.EventHandler(this.btnNie_Click);
            // 
            // btnTak
            // 
            this.btnTak.Location = new System.Drawing.Point(148, 75);
            this.btnTak.Name = "btnTak";
            this.btnTak.Size = new System.Drawing.Size(75, 23);
            this.btnTak.TabIndex = 1;
            this.btnTak.Text = "Tak";
            this.btnTak.UseVisualStyleBackColor = true;
            this.btnTak.Click += new System.EventHandler(this.btnTak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Czy na pewno chcesz usunąć tą specyfikacje?";
            // 
            // Potwierdzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTak);
            this.Controls.Add(this.btnNie);
            this.Name = "Potwierdzenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Potwierdzenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNie;
        private System.Windows.Forms.Button btnTak;
        private System.Windows.Forms.Label label1;
    }
}