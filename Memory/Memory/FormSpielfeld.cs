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
    public partial class FormSpielfeld : Form
    {
        public FormSpielfeld()
        {
            InitializeComponent();
        }

        private void FormSpielfeld_Load(object sender, EventArgs e)
        {
            String username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String output = "";
            if (username.Contains(@"\"))
            {
                output = username.Substring(username.IndexOf('\\') + 1);
            }
            lblUserNameValue.Text = output;
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sind Sie sicher, dass Sie das Spiel verlassen möchten?", "Spiel beenden?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
