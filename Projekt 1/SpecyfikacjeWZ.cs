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
    public partial class SpecyfikacjeWZ : Form
    {
        public List<string> magazynList = new List<string>();
        public List<string> wzList = new List<string>();



        public string dokument { get; set; }
        public string fileName { get; set; }
        public SpecyfikacjeWZ(string idDokumentu)
        {
            InitializeComponent();
            dokument = idDokumentu;
            fileName = @"C:\Users\praktykant\source\repos\Projekt 1\Projekt 1\Dane\wz2.txt";
        }

        private void btnpowrot_Click(object sender, EventArgs e)
        {
            (new DokumentyWZ()).Show(); this.Hide();
        }
        private void SpecyfikacjeWZ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SpecyfikacjeWZ_Load(object sender, EventArgs e)
        {
            ladowanie_danych();
            refreshGrid();
        }
        public void ladowanie_danych()
        {
            wzList.Clear();
            magazynList.Clear();

            try
            {
                using (StreamReader reader1 = new StreamReader(fileName))
                {
                    string line1;
                    while ((line1 = reader1.ReadLine()) != null)
                    {
                        if (line1 != "")
                        {
                            wzList.Add(line1);
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
        public void refreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < wzList.Count; i++)
            {
                if (wzList[i].Split('#')[0] == dokument)
                {
                    dataGridView1.Rows.Add(wzList[i].Split('#')[1], wzList[i].Split('#')[2], wzList[i].Split('#')[3], wzList[i].Split('#')[4], wzList[i].Split('#')[5]);
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var edycjaSpecyfikacji = new EdycjaSpecyfikacji("WZ", magazynList))
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
        public void edycja_list_dodawanie(string id, string nazwa, string ilosc, string cena)
        {
            bool dodanoWZ = false;
            bool dodanoMagazyn = false;

            for (int i = 0; i < wzList.Count; i++)
            {
                if (dokument == wzList[i].Split('#')[0] && id == wzList[i].Split('#')[1] && nazwa == wzList[i].Split('#')[2] && cena == wzList[i].Split('#')[5])
                {
                    decimal nowaIlosc = Convert.ToDecimal(wzList[i].Split('#')[3]) + Convert.ToDecimal(ilosc);
                    wzList[i] = dokument + "#" + id + "#" + nazwa + "#" + nowaIlosc + "#" + znajdzCenaZakupu(id) + "#" + cena;
                    dodanoWZ = true;
                }
            }
            for (int i = 0; i < magazynList.Count; i++)
            {
                if (id == magazynList[i].Split('#')[0] && nazwa == magazynList[i].Split('#')[1] && znajdzCenaZakupu(id) == magazynList[i].Split('#')[3])
                {
                    decimal nowaIlosc = Convert.ToDecimal(magazynList[i].Split('#')[2]) - Convert.ToDecimal(ilosc);
                    magazynList[i] = id + "#" + nazwa + "#" + nowaIlosc + "#" + znajdzCenaZakupu(id);
                    dodanoMagazyn = true;
                }
            }

            if (dodanoWZ && dodanoMagazyn) { refreshGrid(); }
            if (dodanoWZ && !dodanoMagazyn)
            {
                magazynList.Add(id + "#" + nazwa + "#-" + ilosc + "#" + znajdzCenaZakupu(id));
                refreshGrid();
            }
            if (!dodanoWZ && dodanoMagazyn)
            {
                wzList.Add(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + znajdzCenaZakupu(id) + "#" + cena);
                dataGridView1.Rows.Add(id, nazwa, ilosc, znajdzCenaZakupu(id), cena);
            }
            if (!dodanoWZ && !dodanoMagazyn)
            {
                dataGridView1.Rows.Add(id, nazwa, ilosc, znajdzCenaZakupu(id), cena);
                wzList.Add(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + znajdzCenaZakupu(id) + "#" + cena);
                magazynList.Add(id + "#" + nazwa + "#-" + ilosc + "#" + znajdzCenaZakupu(id));
            }
        }
        public void edycja_list_usuwanie(string id, string nazwa, string ilosc, string cenaZakupu, string cenaSprzedazy)
        {

            wzList.Remove(dokument + "#" + id + "#" + nazwa + "#" + ilosc + "#" + cenaZakupu + "#" + cenaSprzedazy);

            bool usunientoMagazyn = false;
            for (int i = 0; i < magazynList.Count; i++)
            {
                if (id == magazynList[i].Split('#')[0] && nazwa == magazynList[i].Split('#')[1] && cenaZakupu == magazynList[i].Split('#')[3])
                {
                    decimal nowaIlosc = Convert.ToDecimal(magazynList[i].Split('#')[2]) + Convert.ToDecimal(ilosc);
                    magazynList[i] = id + "#" + nazwa + "#" + nowaIlosc + "#" + cenaZakupu;
                    usunientoMagazyn = true;
                }
            }
            if (!usunientoMagazyn) { magazynList.Remove(id + "#" + nazwa + "#" + ilosc + "#" + cenaZakupu); }
        }
        public void zapis_danych_do_pliku()
        {
            using (StreamWriter writer = new StreamWriter(fileName, append: false))
            {
                for (int i = 0; i < wzList.Count; i++)
                {
                    writer.WriteLine(wzList[i]);
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
        public string znajdzCenaZakupu(string id)
        {
            string wynik = "";
            foreach (var element in magazynList)
            {
                if (id == element.Split('#')[0]) 
                {
                    wynik = element.Split('#')[3];
                }
            }
            return wynik;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string IDTowaru = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string NazwaTowaru = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ilosc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string CenaZakupu = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string CenaSprzedazy = dataGridView1.CurrentRow.Cells[4].Value.ToString();


                using (var potwierdzenie = new Potwierdzenie())
                {
                    var result2 = potwierdzenie.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        edycja_list_usuwanie(IDTowaru, NazwaTowaru, Ilosc, CenaZakupu, CenaSprzedazy);
                    }
                }
                zapis_danych_do_pliku();
                refreshGrid();
            }
        }
    }
}