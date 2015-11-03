using CusMaSy.Shared.Data;
using CusMaSy.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using CusMaSy.Shared.Infrastructure;

namespace CusMaSy.GUI.Forms
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
            this.Text = Helper.GetTitle("Hauptansicht");
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
            _zuordnungen = _fachkonzept.GetAllZuordnungenByAnbietersNrs(_anbieterList.Select(a => a.p_Anbieter_Nr).ToList());
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
            var clientNrs = new List<long>();

            foreach (ListViewItem rel in lstvRelations.CheckedItems)
                clientNrs.Add(GetAnbieterNrFromListViewItem(rel));

            if (clientNrs.Count == 1)
                _fachkonzept.RemoveZuordnung(anbieterNr, clientNrs.First());

            if (_fachkonzept is FachkonzeptA)
                (_fachkonzept as FachkonzeptA).RemoveZuordnungen(anbieterNr, clientNrs);
            else
            {
                foreach (var clientNr in clientNrs)
                    _fachkonzept.RemoveZuordnung(anbieterNr, clientNr);
            }

            LoadZuordnungen();
            ShowRelations(anbieterNr);
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            var anbieterNr = GetAnbieterNrFromListViewItem(lstvAnbieter.SelectedItems[0]);
            var currRelNrs = _zuordnungen.Where(q => q.pf_HostAnbieter_Nr == anbieterNr).Select(q => q.pf_ClientAnbieter_Nr).ToList();

            // selbst + bestehende zuordnungen rausnehmen;
            var relations = _anbieterList.Where(a => a.p_Anbieter_Nr != anbieterNr && !currRelNrs.Contains(a.p_Anbieter_Nr)).ToList();
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
            ShowAnbieterDetails(anbieter);

            // zeige zuordnungen in zuordnungen box

            ShowRelations(anbieter.p_Anbieter_Nr);

            lblRelationsText.Text = "Zuordnungen von: " + anbieter.Firma;

        }

        private void ShowAnbieterDetails(Anbieter anbieter)
        {
            dgvAnbieterDetails.Rows.Clear();

            SetColumnHeaders(anbieter);

            LoadOrte();

            var ort = _orte.FirstOrDefault(o => o.p_Ort_Nr == anbieter.f_Ort_Nr);

            if (ort == null)
                ort = new Ort { PLZ = 0, Ort1 = "Unbekannt", Land = "Unbekannt" };

            dgvAnbieterDetails.Rows.Add(anbieter.p_Anbieter_Nr.ToString(),
                 anbieter.Firma, anbieter.Homepage, anbieter.Mailadresse, anbieter.Telefonnummer,
                 anbieter.Steuernummer, anbieter.Branche, anbieter.Strasse, anbieter.Hausnummer, 
                 ort.PLZ.ToString(), ort.Ort1, ort.Land, AnbieterTypConverter.ToAnbieterTyp(anbieter.f_AnbieterTyp_Nr));
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
            dgvAnbieterDetails.Columns.Add(anbieter.Homepage, "Homepage");
            dgvAnbieterDetails.Columns.Add(anbieter.Mailadresse, "Mailadresse");
            dgvAnbieterDetails.Columns.Add(anbieter.Telefonnummer, "Telefonnummer");
            dgvAnbieterDetails.Columns.Add(anbieter.Steuernummer, "Steuernummer");            
            dgvAnbieterDetails.Columns.Add(anbieter.Branche, "Branche");
            dgvAnbieterDetails.Columns.Add(anbieter.Strasse, "Straße");
            dgvAnbieterDetails.Columns.Add(anbieter.Hausnummer, "Hausnummer");
            dgvAnbieterDetails.Columns.Add("PLZ", "PLZ");
            dgvAnbieterDetails.Columns.Add("Ort", "Ort");
            dgvAnbieterDetails.Columns.Add("Land", "Land");
            dgvAnbieterDetails.Columns.Add("AnbieterTyp", "AnbieterTyp");           
        }

        void LoadOrte()
        {
            _orte = _fachkonzept.GetOrte(_anbieterList.Select(a => a.f_Ort_Nr).ToList());
        }

        private void txbSearchAnbieter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
                return;

            long anbieterNr;

            long.TryParse(txbSearchAnbieter.Text, out anbieterNr);

            Anbieter searchedAnbieter;

            if (anbieterNr > 0)
                searchedAnbieter = _anbieterList.FirstOrDefault(a => a.p_Anbieter_Nr == anbieterNr);
            else
                searchedAnbieter = _anbieterList.FirstOrDefault(a => a.Firma.Equals(txbSearchAnbieter.Text));

            if (searchedAnbieter == null)
            {
                MessageBox.Show("Anbieter konnte nicht gefunden werden.");
                return;             
            }
                
            txbSearchAnbieter.Text = string.Empty;
            dgvAnbieterDetails.Focus();

            ShowAnbieterDetails(searchedAnbieter);
        }

        private void dgvAnbieterDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var s = sender as DataGridView;

            var rows = s.Rows;

            foreach (DataGridViewRow row in rows)
            {
                try
                {
                    var ort = new Ort
                    {
                        PLZ = int.Parse(row.Cells[7].Value.ToString()),
                        Ort1 = row.Cells[8].Value.ToString(),
                        Land = row.Cells[9].Value.ToString()
                    };

                    // nach ort suchen
                    var ortNr = _fachkonzept.GetOrtNr(ort);

                    var anbieter = new Anbieter
                    {
                        p_Anbieter_Nr = long.Parse(row.Cells[0].Value.ToString()),
                        Firma = row.Cells[1].Value.ToString(),
                        Steuernummer = row.Cells[2].Value.ToString(),
                        f_AnbieterTyp_Nr = AnbieterTypConverter.ToAnbieterTypNr(row.Cells[3].Value.ToString()),
                        Branche = row.Cells[4].Value.ToString(),
                        Strasse = row.Cells[5].Value.ToString(),
                        f_Ort_Nr = ortNr,
                        Hausnummer = row.Cells[6].Value.ToString(),
                        Mailadresse = row.Cells[10].Value.ToString(),
                        Telefonnummer = row.Cells[11].Value.ToString(),
                        Homepage = row.Cells[12].Value.ToString()
                    };

                    _fachkonzept.UpdateAnbieter(anbieter);

                    RefreshLists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anbieter konnte nicht bearbeitet werden.");
                }
            }
        }
    }
}
