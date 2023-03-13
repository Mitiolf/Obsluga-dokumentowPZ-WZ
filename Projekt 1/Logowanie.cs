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
    public partial class Logowanie : Form
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        public Logowanie()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\login.txt";
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        openWith.Add(line.Split('#')[0], line.Split('#')[1]);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (openWith.ContainsKey(boxNazwa.Text))
            {
                if(openWith[boxNazwa.Text] == boxHaslo.Text)
                {
                    (new Menu(boxNazwa.Text)).Show(); this.Hide();
                }
                else
                {
                    MessageBox.Show("Błędne hasło!");
                }
            }
            else
            {
                MessageBox.Show("Brak użytkownika w bazie.");
            }
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            if (openWith.ContainsKey(boxNazwa.Text))
            { 
                MessageBox.Show("Nazwa użytkownika jest już w bazie."); 
            }
            else
            {
                string fileName = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\login.txt";
                using (StreamWriter writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(boxNazwa.Text + "#" + boxHaslo.Text);
                    openWith.Add(boxNazwa.Text, boxHaslo.Text);
                    MessageBox.Show("Zarejestrowano.");
                }

            }
        }

        private void Logowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
