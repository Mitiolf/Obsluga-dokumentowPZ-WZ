
namespace Projekt_1
{
    partial class EdycjaSpecyfikacji
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
            this.ILOSC = new System.Windows.Forms.Label();
            this.NAZWA_TOWARU = new System.Windows.Forms.Label();
            this.ID_TOWARU = new System.Windows.Forms.Label();
            this.boxIlosc = new System.Windows.Forms.TextBox();
            this.boxNazwaTowaru = new System.Windows.Forms.TextBox();
            this.boxIDTowaru = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.CENA_ZAKUPU = new System.Windows.Forms.Label();
            this.boxCena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ILOSC
            // 
            this.ILOSC.AutoSize = true;
            this.ILOSC.Location = new System.Drawing.Point(395, 30);
            this.ILOSC.Name = "ILOSC";
            this.ILOSC.Size = new System.Drawing.Size(38, 13);
            this.ILOSC.TabIndex = 16;
            this.ILOSC.Text = "ILOSC";
            // 
            // NAZWA_TOWARU
            // 
            this.NAZWA_TOWARU.AutoSize = true;
            this.NAZWA_TOWARU.Location = new System.Drawing.Point(211, 30);
            this.NAZWA_TOWARU.Name = "NAZWA_TOWARU";
            this.NAZWA_TOWARU.Size = new System.Drawing.Size(102, 13);
            this.NAZWA_TOWARU.TabIndex = 15;
            this.NAZWA_TOWARU.Text = "NAZWA_TOWARU";
            // 
            // ID_TOWARU
            // 
            this.ID_TOWARU.AutoSize = true;
            this.ID_TOWARU.Location = new System.Drawing.Point(30, 30);
            this.ID_TOWARU.Name = "ID_TOWARU";
            this.ID_TOWARU.Size = new System.Drawing.Size(73, 13);
            this.ID_TOWARU.TabIndex = 14;
            this.ID_TOWARU.Text = "ID_TOWARU";
            // 
            // boxIlosc
            // 
            this.boxIlosc.Location = new System.Drawing.Point(398, 48);
            this.boxIlosc.MaxLength = 8;
            this.boxIlosc.Name = "boxIlosc";
            this.boxIlosc.Size = new System.Drawing.Size(142, 20);
            this.boxIlosc.TabIndex = 13;
            this.boxIlosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIlosc_KeyPress);
            // 
            // boxNazwaTowaru
            // 
            this.boxNazwaTowaru.Location = new System.Drawing.Point(214, 48);
            this.boxNazwaTowaru.MaxLength = 20;
            this.boxNazwaTowaru.Name = "boxNazwaTowaru";
            this.boxNazwaTowaru.Size = new System.Drawing.Size(142, 20);
            this.boxNazwaTowaru.TabIndex = 12;
            // 
            // boxIDTowaru
            // 
            this.boxIDTowaru.Location = new System.Drawing.Point(34, 48);
            this.boxIDTowaru.MaxLength = 12;
            this.boxIDTowaru.Name = "boxIDTowaru";
            this.boxIDTowaru.Size = new System.Drawing.Size(142, 20);
            this.boxIDTowaru.TabIndex = 11;
            this.boxIDTowaru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIDTowaru_KeyPress);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(649, 94);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(34, 94);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // CENA_ZAKUPU
            // 
            this.CENA_ZAKUPU.AutoSize = true;
            this.CENA_ZAKUPU.Location = new System.Drawing.Point(579, 30);
            this.CENA_ZAKUPU.Name = "CENA_ZAKUPU";
            this.CENA_ZAKUPU.Size = new System.Drawing.Size(86, 13);
            this.CENA_ZAKUPU.TabIndex = 18;
            this.CENA_ZAKUPU.Text = "CENA_ZAKUPU";
            // 
            // boxCena
            // 
            this.boxCena.Location = new System.Drawing.Point(582, 48);
            this.boxCena.MaxLength = 8;
            this.boxCena.Name = "boxCena";
            this.boxCena.Size = new System.Drawing.Size(142, 20);
            this.boxCena.TabIndex = 17;
            this.boxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCena_KeyPress);
            // 
            // EdycjaSpecyfikacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 143);
            this.Controls.Add(this.CENA_ZAKUPU);
            this.Controls.Add(this.boxCena);
            this.Controls.Add(this.ILOSC);
            this.Controls.Add(this.NAZWA_TOWARU);
            this.Controls.Add(this.ID_TOWARU);
            this.Controls.Add(this.boxIlosc);
            this.Controls.Add(this.boxNazwaTowaru);
            this.Controls.Add(this.boxIDTowaru);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAnuluj);
            this.Name = "EdycjaSpecyfikacji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdycjaSpecyfikacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ILOSC;
        private System.Windows.Forms.Label NAZWA_TOWARU;
        private System.Windows.Forms.Label ID_TOWARU;
        private System.Windows.Forms.TextBox boxIlosc;
        private System.Windows.Forms.TextBox boxNazwaTowaru;
        private System.Windows.Forms.TextBox boxIDTowaru;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label CENA_ZAKUPU;
        private System.Windows.Forms.TextBox boxCena;
    }
}