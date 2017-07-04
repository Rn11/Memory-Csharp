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
    public partial class FormCredits : Form
    {

        public FormCredits()
        {
            InitializeComponent();
            lblVerValue.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Memory.Update.runUpdate();
        }
        private void lblVerValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Rn11/Memory-Csharp/releases/latest");
        }
    }
}
