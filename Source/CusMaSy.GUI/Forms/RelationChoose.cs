using CusMaSy.Shared.Data;
using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CusMaSy.GUI.Forms
{
    public partial class RelationChoose : Form
    {
        List<Anbieter> _anbieters;
        IFachkonzept _fachkonzept;
        long _hostNr;


        public RelationChoose(IFachkonzept fachkonzept, long hostNr, List<Anbieter> anbieters)
        {
            InitializeComponent();

            _anbieters = anbieters;
            _hostNr = hostNr;
            _fachkonzept = fachkonzept;
            this.Text = Helper.GetTitle("Anbieter-Zuordnung");


            FillList();
        }

        void FillList()
        {
            foreach (var a in _anbieters)
            {
                lstVAnbieters.Items.Add(new ListViewItem
                {
                    Text = a.p_Anbieter_Nr + " | " + a.Firma,
                    Checked = false
                });

                lstVAnbieters.CheckBoxes = true;
            }
        }

        private void btnAddRelations_Click(object sender, EventArgs e)
        {
            var checkedItems = lstVAnbieters.CheckedItems;

            if (checkedItems == null || checkedItems.Count < 1)
                return;

            var anbieterNrs = new List<long>();

            foreach (ListViewItem ci in checkedItems)
            {
                var parts = ci.Text.ToString().Split('|');
                anbieterNrs.Add(long.Parse(parts[0].Replace(" ", string.Empty)));
            }

            _fachkonzept.SaveZuordnungen(_hostNr, anbieterNrs);
            this.Close();
        }
    }
}
