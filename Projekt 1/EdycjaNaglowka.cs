using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Projekt_1
{
    public partial class EdycjaNaglowka : Form
    {
        public EdycjaNaglowka(string worp)
        {
            InitializeComponent();
            label1.Text = $"NR_{worp}";
            label2.Text = $"DATA_{worp}";
            label3.Text = $"DOSAWCA_{worp}";

        }

        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        public string ReturnValue3 { get; set; }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateDate(boxDATA))
            {
                this.ReturnValue1 = boxNR.Text;
                this.ReturnValue2 = boxDATA.Text;
                this.ReturnValue3 = boxDOSTAWCA.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateDate(Control ctrl)
        {
            string[] formats = { "d/M/yyyy" };
            DateTime value;

            if (!DateTime.TryParseExact(ctrl.Text, formats, new CultureInfo("en-US"), DateTimeStyles.None, out value))
                {
                    MessageBox.Show("Podaj poprawną date.");
                    return false;
                }
            return true;
        }
    }
}
