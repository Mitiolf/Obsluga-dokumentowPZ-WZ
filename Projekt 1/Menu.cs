using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_1
{
    public partial class Menu : Form
    {
        public Menu(string nazwa = "")
        {
            InitializeComponent();
            label1.Text = $"Kto się zalogował: {nazwa}";
        }

        private void btnDokumentyPZ_Click(object sender, EventArgs e)
        {
            (new DokumentyPZ()).Show(); this.Hide();
        }

        private void btnDokumentyWZ_Click(object sender, EventArgs e)
        {
            (new DokumentyWZ()).Show(); this.Hide();
        }

        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            (new Magazyn()).Show(); this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
