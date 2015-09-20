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
    public partial class Anlage : Form
    {
        public Anlage()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            var c = new CusMaSy.Project.Data.Connector();
            c.InsertOrt(77933, "Lahr/Schwarzwald");
        }
    }
}
