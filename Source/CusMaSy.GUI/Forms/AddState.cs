using CusMaSy.Shared.Infrastructure;
using CusMaSy.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CusMaSy.GUI.Forms
{
    public partial class AddState : Form
    {
        IFachkonzept _fachkonzept;
        List<string> _existingStates;
        public AddState(IFachkonzept fachkonzept)
        {
            InitializeComponent();
            _fachkonzept = fachkonzept;
            this.Text = Helper.GetTitle("Land hinzufügen");

            _existingStates = (_fachkonzept as FachkonzeptA).GetAllStates();

        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbState.Text))
                return;

            var input = txbState.Text;

            // land in db checken 

            if (_existingStates.Contains(input))
            {
                lblWarning.Visible = true;
                return;
            }

            _fachkonzept.SaveState(input);
            this.Close();
        }
    }
}
