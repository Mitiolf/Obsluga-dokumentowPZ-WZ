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
    public partial class Potwierdzenie : Form
    {
        public Potwierdzenie()
        {
            InitializeComponent();
        }

        private void btnTak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnNie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
