using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FormHauptmenue : Form
    {
        public FormHauptmenue()
        {
            InitializeComponent();
        }

        private void btnEinzelspieler_Click(object sender, EventArgs e)
        {
            FormSpielfeld fSpiel = new FormSpielfeld();
            fSpiel.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {

        }

        private void btnMehrspieler_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionen_Click(object sender, EventArgs e)
        {
            FormOptionen fOptionen = new FormOptionen();
            fOptionen.ShowDialog();
        }

        private void btnVerlassen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
