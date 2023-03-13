
namespace Projekt_1
{
    partial class Logowanie
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
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.boxNazwa = new System.Windows.Forms.TextBox();
            this.boxHaslo = new System.Windows.Forms.TextBox();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(55, 184);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(75, 23);
            this.btnZaloguj.TabIndex = 0;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // boxNazwa
            // 
            this.boxNazwa.Location = new System.Drawing.Point(55, 86);
            this.boxNazwa.Name = "boxNazwa";
            this.boxNazwa.Size = new System.Drawing.Size(170, 20);
            this.boxNazwa.TabIndex = 1;
            // 
            // boxHaslo
            // 
            this.boxHaslo.Location = new System.Drawing.Point(55, 140);
            this.boxHaslo.Name = "boxHaslo";
            this.boxHaslo.Size = new System.Drawing.Size(170, 20);
            this.boxHaslo.TabIndex = 2;
            this.boxHaslo.PasswordChar = '*';
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.Location = new System.Drawing.Point(150, 184);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.btnZarejestruj.TabIndex = 3;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = true;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(100, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logowanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Użytkownik";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.boxHaslo);
            this.Controls.Add(this.boxNazwa);
            this.Controls.Add(this.btnZaloguj);
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logowanie_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.TextBox boxNazwa;
        private System.Windows.Forms.TextBox boxHaslo;
        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

