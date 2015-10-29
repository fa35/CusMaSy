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
        List<Anbieter_Zuordnung> _zuordnungen;

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
            LoadZuordnungen();
        }

        private void LoadZuordnungen()
        {
            _zuordnungen = _fachkonzept.GetAllZuordnungenByAnbieterNr(_anbieterList.Select(a => a.p_Anbieter_Nr).ToList());
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

            var anbieterNr = GetAnbieterNrFromListViewItem(lstvAnbieter.SelectedItems[0]);

            try
            {
                _fachkonzept.RemoveAnbieter(anbieterNr);
                LoadAnbieters();
                dgvAnbieterDetails.Rows.Clear();
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
            var anbieterNr = GetAnbieterNrFromListViewItem(lstvAnbieter.SelectedItems[0]);
            var relationsNrs = new List<long>();

            foreach (ListViewItem rel in lstvRelations.CheckedItems)
                relationsNrs.Add(GetAnbieterNrFromListViewItem(rel));

            _fachkonzept.DeleteRelations(anbieterNr, relationsNrs);

            LoadZuordnungen();
            ShowRelations(anbieterNr);
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            var anbieterNr = GetAnbieterNrFromListViewItem(lstvAnbieter.SelectedItems[0]);

            var relations = _anbieterList.Where(a => a.p_Anbieter_Nr != anbieterNr).ToList();

            new RelationChoose(_fachkonzept, anbieterNr, relations).ShowDialog();

            LoadZuordnungen();
            ShowRelations(anbieterNr);
        }

        private void lstvAnbieter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = (sender as ListView).SelectedItems;
            if (items == null || items.Count != 1)
                return;

            // hole selected stirng
            var anbieterNr = GetAnbieterNrFromListViewItem(items[0]);

            // hole anbieter infos
            var anbieter = _anbieterList.FirstOrDefault(a => a.p_Anbieter_Nr == anbieterNr);

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

            ShowRelations(anbieter.p_Anbieter_Nr);

        }

        private void ShowRelations(long anbieterNr)
        {
            lstvRelations.Items.Clear();

            var relationsNrs = _zuordnungen.Where(z => z.pf_HostAnbieter_Nr == anbieterNr).Select(q => q.pf_ClientAnbieter_Nr).ToList();

            foreach (var relNr in relationsNrs)
            {
                var rel = _anbieterList.FirstOrDefault(a => a.p_Anbieter_Nr == relNr);

                if (rel == null)
                    continue;

                lstvRelations.CheckBoxes = true;
                lstvRelations.Items.Add(rel.p_Anbieter_Nr + " | " + rel.Firma);
            }
        }

        long GetAnbieterNrFromListViewItem(ListViewItem item)
        {
            var parts = item.Text.Split('|');
            // splitte string nach anbieternr und namen auf, nehme anbieternr
            var anbieterNr = parts.First().Replace(" ", string.Empty);
            return long.Parse(anbieterNr);
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
