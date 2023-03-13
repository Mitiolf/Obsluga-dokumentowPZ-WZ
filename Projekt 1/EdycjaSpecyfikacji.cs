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
    public partial class EdycjaSpecyfikacji : Form
    {
        public string ReturnValueIDTowaru { get; set; }
        public string ReturnValueNazwaTowaru { get; set; }
        public string ReturnValueIlosc { get; set; }
        public string ReturnValueCena { get; set; }
        public string worpBig { get; }
        public List<string> magazynLista { get; }


        public EdycjaSpecyfikacji(string worp, List<string> magazynList)
        {
            InitializeComponent();
            magazynLista = magazynList;
            worpBig = worp;
            if (worp == "WZ")
            {
                CENA_ZAKUPU.Text = "CENA_SPRZEDAŻY";
                boxNazwaTowaru.ReadOnly = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(ValidateIdInStock())
            {
                this.ReturnValueIDTowaru = boxIDTowaru.Text;
                this.ReturnValueNazwaTowaru = (worpBig == "WZ") ? zwrocNazwe() : boxNazwaTowaru.Text;
                this.ReturnValueIlosc = boxIlosc.Text;
                this.ReturnValueCena = boxCena.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string zwrocNazwe()
        {
            foreach (var element in magazynLista)
            {
                if (boxIDTowaru.Text == element.Split('#')[0])
                {
                    return element.Split('#')[1];
                }
            }
            return boxNazwaTowaru.Text;
        }

        public bool ValidateIdInStock()
        {
            if (worpBig == "PZ")
            {
                foreach (var element in magazynLista)
                {
                    if (boxIDTowaru.Text == element.Split('#')[0])
                    {
                        if(boxNazwaTowaru.Text == element.Split('#')[1] && boxCena.Text == element.Split('#')[3])
                        {
                            return true;
                        }
                        MessageBox.Show($"Produkt o takim id jest już w magazynie. \nJego nazwa to {element.Split('#')[1]}, a cena zakupu {element.Split('#')[3]}.");
                        return false;
                    }
                }
                return true;
            }
            foreach (var element in magazynLista)
            {
                if (boxIDTowaru.Text == element.Split('#')[0] && Convert.ToDecimal(boxIlosc.Text) <= Convert.ToDecimal(element.Split('#')[2]))
                {
                    return true;
                }
                if (boxIDTowaru.Text == element.Split('#')[0] && Convert.ToDecimal(boxIlosc.Text) > Convert.ToDecimal(element.Split('#')[2]))
                {
                    MessageBox.Show($"Dostępna ilość produktu to {element.Split('#')[2]}");
                    return false;
                }
            }
            MessageBox.Show("Brak produktu w magazynie.");
            return false;
        }

        private void boxIDTowaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789" + (char)8;
            if (st.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void boxIlosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789," + (char)8;
            if (boxIlosc.Text.IndexOf(",") != -1 && e.KeyChar.ToString() == "," ) 
            {
                e.Handled = true;
            }
            if (st.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void boxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789," + (char)8;
            if (boxCena.Text.IndexOf(",") != -1 && e.KeyChar.ToString() == ",")
            {
                e.Handled = true;
            }
            if (st.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }
    }
}
