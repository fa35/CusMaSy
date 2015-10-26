using CusMaSy.Project.Models;
using CusMaSy.Project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CusMaSy.Project.Views
{
    public partial class Hauptansicht : Form
    {
        List<Anbieter> _anbieterList;
        IFachkonzept _fachkonzept;
        public Hauptansicht(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;

            if (_anbieterList == null || _anbieterList.Count < 1)
                RefreshAnbieterList();
        }

        private void btnAddAnbieter_Click(object sender, EventArgs e)
        {
            new Anlage(_fachkonzept).ShowDialog();
            RefreshAnbieterList();
        }


        void RefreshAnbieterList()
        {
            //_anbieterList = _fachkonzept.GetAllAnbieter();

            //lstvAnbieterDetails.Items = _anbieterList;

            // wenn prozeduren / connection mit db passt
        }

        private void btnDeleteAnbieter_Click(object sender, EventArgs e)
        {
            // wenn prozeduren / connection mit db passt
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
    }
}
