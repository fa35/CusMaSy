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
            _anbieterList = _fachkonzept.GetAllAnbieter();

            dgvAnbieterDetails = new DataGridView();

        }

        private void btnDeleteAnbieter_Click(object sender, EventArgs e)
        {
            var col = dgvAnbieterDetails.SelectedColumns;

            var c = col.Count;
        }
    }
}
