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
    public partial class DokumentyPZ : Form
    {
        public DokumentyPZ()
        {
            InitializeComponent();
        }

        string fileName1 = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\pz1.txt";
        string fileName2 = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\pz2.txt";


        private void dodaj_Click(object sender, EventArgs e)
        {
            using (var edycjaNaglowka = new EdycjaNaglowka("PZ"))
            {
                var result = edycjaNaglowka.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val1 = edycjaNaglowka.ReturnValue1;
                    string val2 = edycjaNaglowka.ReturnValue2;
                    string val3 = edycjaNaglowka.ReturnValue3;

                    System.Guid newID = Guid.NewGuid();
                    dataGridView1.Rows.Add(newID, val1, val2, val3, 0);
                    using (StreamWriter writer = new StreamWriter(fileName1, append: true))
                    {
                        writer.WriteLine(newID + "#" + val1 + "#" + val2 + "#" + val3);
                    }

                }
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (czy_moge_usunac())
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                using (StreamWriter writer = new StreamWriter(fileName1, append: false))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        writer.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                }

            }
            else
            {
                if (dataGridView1.CurrentRow != null)
                {
                    MessageBox.Show("Nie można usunąć! Dokument zawiera specyfikacje.");
                }
            }
        }

        public bool czy_moge_usunac()
        {
            bool answer = true;
            if (dataGridView1.CurrentRow == null)
            {
                return false;
            }
            using (StreamReader reader = new StreamReader(fileName2))
            {
                string line;
                string idDokumentu = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Split('#')[0] == idDokumentu)
                    {
                        answer = false;
                    }
                }
            }
            return answer;
        }

        private void specyfikacje_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                string idDokumentu = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                (new SpecyfikacjePZ(idDokumentu)).Show(); this.Hide();
            }
        }

        private void DokumentyPZ_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader1 = new StreamReader(fileName1))
                {
                    string line1;
                    while ((line1 = reader1.ReadLine()) != null)
                    {
                        dataGridView1.Rows.Add(line1.Split('#')[0], line1.Split('#')[1], line1.Split('#')[2], line1.Split('#')[3], oblicz_wartosc(line1.Split('#')[0]));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public decimal oblicz_wartosc(string id)
        {
            decimal wartosc = 0;
            using (StreamReader reader2 = new StreamReader(fileName2))
            {
                string line2;
                while ((line2 = reader2.ReadLine()) != null)
                {
                    if (id == line2.Split('#')[0])
                    {
                        wartosc += decimal.Parse(line2.Split('#')[3]) * decimal.Parse(line2.Split('#')[4]);
                    }
                }
            }
            return wartosc;
        }

        private void DokumentyPZ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnpowrot_Click(object sender, EventArgs e)
        {
            (new Menu()).Show(); this.Hide();
        }
    }
}
