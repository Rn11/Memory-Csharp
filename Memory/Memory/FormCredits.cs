﻿using System;
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
            lblVerValue.Text = FormHauptmenue.currVer;
            Memory.Update.runUpdate();
        }

        private void FormCredits_Load(object sender, EventArgs e)
        {

        }
    }
}
