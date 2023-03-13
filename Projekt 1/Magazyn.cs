using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt_1
{
    public partial class Magazyn : Form
    {
        public Magazyn()
        {
            InitializeComponent();
        }

        private void Magazyn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnpowrot_Click(object sender, EventArgs e)
        {
            (new Menu()).Show(); this.Hide();
        }

        private void btnSzczegoły_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\magazyn.txt");
            MessageBox.Show(text);
        }

        private void Magazyn_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader1 = new StreamReader(@"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\magazyn.txt"))
                {
                    string line1;
                    while ((line1 = reader1.ReadLine()) != null)
                    {
                        dataGridView1.Rows.Add(line1.Split('#')[0], line1.Split('#')[1], line1.Split('#')[2], Math.Abs(decimal.Parse(line1.Split('#')[2])*decimal.Parse(line1.Split('#')[3])));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
