using CusMaSy.Project.Data;
using CusMaSy.Project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using CusMaSy.Project.Infrastructure;

namespace CusMaSy.Project.Views
{
    public partial class Hauptansicht : Form
    {
        List<Anbieter> _anbieterList;
        List<Ort> _orte;

        IFachkonzept _fachkonzept;
        public Hauptansicht(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;

            RefreshLists();
        }

        void RefreshLists()
        {
            LoadAnbieters();
            LoadOrte();
        }

        private void btnAddAnbieter_Click(object sender, EventArgs e)
        {
            new Anlage(_fachkonzept).ShowDialog();
            RefreshLists();
        }


        void LoadAnbieters()
        {
            lstvAnbieter.Items.Clear();
            _anbieterList = _fachkonzept.GetAllAnbieter();

            foreach (var a in _anbieterList)
                lstvAnbieter.Items.Add(a.p_Anbieter_Nr + " | " + a.Firma);
        }

        private void btnDeleteAnbieter_Click(object sender, EventArgs e)
        {
            if (lstvAnbieter.SelectedItems.Count != 1)
                return;

            var anbieterNr = GetSelectedAnbieterNr(lstvAnbieter.SelectedItems);

            if (string.IsNullOrWhiteSpace(anbieterNr))
                return;

            try
            {
                _fachkonzept.RemoveAnbieter(anbieterNr);
                LoadAnbieters();
            }
            catch (Exception ex)
            {
                // loggen
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Anbieter konnte nicht gelöscht werden!", "Es ist ein Fehler aufgetreten",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRelation_Click(object sender, EventArgs e)
        {
            var anbieters = lstvAnbieter.SelectedItems; // kann nur einer sein
            var relations = lstvRelations.SelectedItems; // können mehrere sein


            var relNrs = new List<long>();

            foreach (var item in relations)
            {
                var parts = item.ToString().Split('|');
                relNrs.Add(long.Parse(parts[0].Replace(" ", string.Empty)));
            }

            long anbieterNr = 0;

            foreach (var item in anbieters)
            {
                var parts = item.ToString().Split('|');
                anbieterNr = (long.Parse(parts[0].Replace(" ", string.Empty)));
            }

            _fachkonzept.DeleteRelations(anbieterNr, relNrs);

        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {

        }

        private void lstvAnbieter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = (sender as ListView).SelectedItems;
            if (items == null || items.Count != 1)
                return;

            // hole selected stirng
            string anbieterNr = GetSelectedAnbieterNr(items);

            // hole anbieter infos
            var anbieter = _anbieterList.FirstOrDefault(a => a.p_Anbieter_Nr == int.Parse(anbieterNr));

            if (anbieter == null)
                return;

            // zeige in details anbieter details
            SetColumnHeaders(anbieter);

            LoadOrte();

            var ort = _orte.FirstOrDefault(o => o.p_Ort_Nr == anbieter.f_Ort_Nr);

            if (ort == null)
                ort = new Ort { PLZ = 0, Ort1 = "Unbekannt", Land = "Unbekannt" };

            dgvAnbieterDetails.Rows.Add(anbieter.p_Anbieter_Nr.ToString(),
                 anbieter.Firma, anbieter.Steuernummer, AnbieterTypConverter.ToAnbieterTyp(anbieter.f_AnbieterTyp_Nr),
                 anbieter.Branche, anbieter.Strasse, anbieter.Hausnummer, ort.PLZ.ToString(), ort.Ort1,
                 ort.Land, anbieter.Mailadresse, anbieter.Telefonnummer, anbieter.Homepage);
            // zeige zuordnungen in zuordnungen box
        }

        string GetSelectedAnbieterNr(ListView.SelectedListViewItemCollection items)
        {
            var selectedString = items[0].Text;

            var parts = selectedString.Split('|');
            // splitte string nach anbieternr und namen auf, nehme anbieternr
            var anbieterNr = parts.First().Replace(" ", string.Empty);
            return anbieterNr;
        }




        void SetColumnHeaders(Anbieter anbieter)
        {
            if (dgvAnbieterDetails.Columns.Count > 1)
                return;

            dgvAnbieterDetails.Columns.Add(anbieter.p_Anbieter_Nr.ToString(), "AnbieterNr");
            dgvAnbieterDetails.Columns.Add(anbieter.Firma, "Firma");
            dgvAnbieterDetails.Columns.Add(anbieter.Steuernummer, "Steuernummer");
            dgvAnbieterDetails.Columns.Add("AnbieterTyp", "AnbieterTyp");
            dgvAnbieterDetails.Columns.Add(anbieter.Branche, "Branche");
            dgvAnbieterDetails.Columns.Add(anbieter.Strasse, "Straße");
            dgvAnbieterDetails.Columns.Add(anbieter.Hausnummer, "Hausnummer");
            dgvAnbieterDetails.Columns.Add("PLZ", "PLZ");
            dgvAnbieterDetails.Columns.Add("Ort", "Ort");
            dgvAnbieterDetails.Columns.Add("Land", "Land");
            dgvAnbieterDetails.Columns.Add(anbieter.Mailadresse, "Mailadresse");
            dgvAnbieterDetails.Columns.Add(anbieter.Telefonnummer, "Telefonnummer");
            dgvAnbieterDetails.Columns.Add(anbieter.Homepage, "Homepage");
        }

        void LoadOrte()
        {
            _orte = _fachkonzept.GetOrte(_anbieterList.Select(a => a.f_Ort_Nr).ToList());
        }
    }
}
