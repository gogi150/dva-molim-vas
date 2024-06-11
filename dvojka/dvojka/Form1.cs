using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dvojka
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }
        public string Aktivnost { get; set; }
    }

    public partial class Form1 : Form
    {
        private List<Osoba> osobe = new List<Osoba>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Uloga = cmbUloga.SelectedItem.ToString()
            };
            osobe.Add(osoba);
            txtIme.Clear();
            txtPrezime.Clear();
            cmbUloga.SelectedIndex = -1;
        }

        private void btnPrikaziOsobe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = osobe;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string uloga = cmbFiltriraj.SelectedItem.ToString();
            List<Osoba> filtriraneOsobe = osobe.FindAll(o => o.Uloga == uloga);
            dataGridView1.DataSource = filtriraneOsobe;
        }

        private void btnObradiPodatke_Click(object sender, EventArgs e)
        {
            foreach (Osoba osoba in osobe)
            {
                switch (osoba.Uloga)
                {
                    case "Učenik":
                        osoba.Aktivnost = "Uči";
                        break;
                    case "Profesor":
                        osoba.Aktivnost = "Predaje";
                        break;
                    case "Tehničko osoblje":
                        osoba.Aktivnost = "Održava";
                        break;
                }
            }
            dataGridView1.DataSource = osobe;
        }
    }
}

 
