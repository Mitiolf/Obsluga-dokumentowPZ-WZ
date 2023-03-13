
namespace Projekt_1
{
    partial class EdycjaNaglowka
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.boxNR = new System.Windows.Forms.TextBox();
            this.boxDATA = new System.Windows.Forms.TextBox();
            this.boxDOSTAWCA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(45, 97);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 0;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(476, 97);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // boxNR
            // 
            this.boxNR.Location = new System.Drawing.Point(43, 58);
            this.boxNR.MaxLength = 12;
            this.boxNR.Name = "boxNR";
            this.boxNR.Size = new System.Drawing.Size(142, 20);
            this.boxNR.TabIndex = 3;
            // 
            // boxDATA
            // 
            this.boxDATA.Location = new System.Drawing.Point(223, 58);
            this.boxDATA.Name = "boxDATA";
            this.boxDATA.Size = new System.Drawing.Size(142, 20);
            this.boxDATA.TabIndex = 4;
            // 
            // boxDOSTAWCA
            // 
            this.boxDOSTAWCA.Location = new System.Drawing.Point(407, 58);
            this.boxDOSTAWCA.MaxLength = 50;
            this.boxDOSTAWCA.Name = "boxDOSTAWCA";
            this.boxDOSTAWCA.Size = new System.Drawing.Size(142, 20);
            this.boxDOSTAWCA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NR_PZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DATA_PZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOSTAWCA_PZ";
            // 
            // EdycjaNaglowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDOSTAWCA);
            this.Controls.Add(this.boxDATA);
            this.Controls.Add(this.boxNR);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAnuluj);
            this.Name = "EdycjaNaglowka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdycjaNaglowka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox boxNR;
        private System.Windows.Forms.TextBox boxDATA;
        private System.Windows.Forms.TextBox boxDOSTAWCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}