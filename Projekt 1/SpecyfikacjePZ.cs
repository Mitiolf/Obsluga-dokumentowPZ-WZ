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
    public partial class SpecyfikacjePZ : Form
    {

        public List<string> pzList = new List<string>();
        public List<string> magazynList = new List<string>();

        public string dokument { get; set; }
        public string fileName { get; set; }

        public SpecyfikacjePZ(string idDokumentu)
        {
            InitializeComponent();
            dokument = idDokumentu;
            fileName = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\pz2.txt";
        }


        private void SpecyfikacjePZ_Load(object sender, EventArgs e)
        {
            ladowanie_danych();
            refreshGrid();
        }
        public void refreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < pzList.Count; i++)
            {
                if (pzList[i].Split('#')[0] == dokument)
                {
                    dataGridView1.Rows.Add(pzList[i].Split('#')[1], pzList[i].Split('#')[2], pzList[i].Split('#')[3], pzList[i].Split('#')[4]);
                }
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            using (var edycjaSpecyfikacji = new EdycjaSpecyfikacji("PZ", magazynList))
            {
                var result = edycjaSpecyfikacji.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string IDTowaru = edycjaSpecyfikacji.ReturnValueIDTowaru;
                    string NazwaTowaru = edycjaSpecyfikacji.ReturnValueNazwaTowaru;
                    string Ilosc = edycjaSpecyfikacji.ReturnValueIlosc;
                    string Cena = edycjaSpecyfikacji.ReturnValueCena;

                    edycja_list_dodawanie(IDTowaru, NazwaTowaru, Ilosc, Cena);

                    zapis_danych_do_pliku();
                }
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string IDTowaru = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string NazwaTowaru = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ilosc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Cena = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                using (var potwierdzenie = new Potwierdzenie())
                {
                    var result2 = potwierdzenie.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        edycja_list_usuwanie(IDTowaru, NazwaTowaru, Ilosc, Cena);
                    }
                }
                zapis_danych_do_pliku();
                refreshGrid();
            }
        }
        private void SpecyfikacjePZ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
                (new DokumentyPZ()).Show(); this.Hide();
        }

        public void ladowanie_danych()
        {
            pzList.Clear();
            magazynList.Clear();


            try
            {
                using (StreamReader reader1 = new StreamReader(fileName))
                {
                    string line1;
                    while ((line1 = reader1.ReadLine()) != null)
                    {
                        if(line1 != "")
                        {
                            pzList.Add(line1);
                        }
                    }
                }

                using (StreamReader reader1 = new StreamReader(@"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\magazyn.txt"))
                {
                    string line;
                    while ((line = reader1.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            magazynList.Add(line);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public void edycja_list_dodawanie(string id, string nazwa, string ilosc, string cena)
        {
            bool dodanoPZ = false;
            bool dodanoMagazyn = false;

            for (int i = 0; i < pzList.Count; i++)
            {
                if (dokument == pzList[i].Split('#')[0] && id == pzList[i].Split('#')[1] && nazwa == pzList[i].Split('#')[2] && cena == pzList[i].Split('#')[4])
                {
                    decimal nowaIlosc = Convert.ToDecimal(pzList[i].Split('#')[3]) + Convert.ToDecimal(ilosc);
                    pzList[i] = dokument + "#" + id + "#" + nazwa + "#" + nowaIlosc + "#" + cena;
                    dodanoPZ = true;
                }
            }
            for (int i = 0; i < magazynList.Count; i++)
            {
                if (id == magazynList[i].Split('#')[0] && nazwa == magazynList[i].Split('#')[1] && cena == magazynList[i].Split('#')[3])
                {
                        decimal nowaIlosc = Convert.ToDecimal(magazynList[i].Split('#')[2]) + Convert.ToDecimal(ilosc);
                        magazynList[i] = id + "#" + nazwa + "#" + nowaIlosc + "#" + cena;
                        dodanoMagazyn = true;
                }
            }

            if (dodanoPZ && dodanoMagazyn) { refreshGrid(); }
            if (dodanoPZ && !dodanoMagazyn)
            {
                magazynList.Add(id + "#" + nazwa + "#" + ilosc + "#" + cena);
                refreshGrid();
            }
            if (!dodanoPZ && dodanoMagazyn) 
            {
                pzList.Add(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + cena);
                dataGridView1.Rows.Add(id, nazwa, ilosc, cena);
            }
            if (!dodanoPZ && !dodanoMagazyn) 
            {
                dataGridView1.Rows.Add(id, nazwa, ilosc, cena);
                pzList.Add(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + cena);
                magazynList.Add(id + "#" + nazwa + "#" + ilosc + "#" + cena);
            }
        }
        public void edycja_list_usuwanie(string id, string nazwa, string ilosc, string cena)
        {

            bool usunientoMagazyn = false;
            for (int i = 0; i < magazynList.Count; i++)
            {
                if (id == magazynList[i].Split('#')[0] && nazwa == magazynList[i].Split('#')[1] && cena == magazynList[i].Split('#')[3])
                {
                    decimal nowaIlosc = Convert.ToDecimal(magazynList[i].Split('#')[2]) - Convert.ToDecimal(ilosc);
                    if (nowaIlosc < 0)
                    {
                        MessageBox.Show("Nie można usunąć. Produkt został sprzedany.");
                    }
                    else
                    {
                        magazynList[i] = id + "#" + nazwa + "#" + nowaIlosc + "#" + cena;
                        pzList.Remove(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + cena);
                    }
                    usunientoMagazyn = true;
                    break;
                }
            }
            if (!usunientoMagazyn) 
            { 
                magazynList.Remove(id + "#" + nazwa + "#" + ilosc + "#" + cena);
                pzList.Remove(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + cena);
            }
        }
        public void zapis_danych_do_pliku()
        {
            using (StreamWriter writer = new StreamWriter(fileName, append: false))
            {
                for (int i = 0; i < pzList.Count; i++)
                {
                    writer.WriteLine(pzList[i]);
                }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\magazyn.txt", append: false))
            {
                for (int i = 0; i < magazynList.Count; i++)
                {
                    writer.WriteLine(magazynList[i]);
                }
            }
        }




    }
}
