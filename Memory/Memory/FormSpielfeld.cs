using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Memory;

namespace Memory
{
    public partial class FormSpielfeld : Form
    {
        private List<Image> bilder = new List<Image>();
        public static List<PictureBox> pb = new List<PictureBox>();
        private Image tmpImg;
        private static int tmpID = 0;
        private static int punkte = 0;

        public static int Punkte
        {
            get
            {
                return punkte;
            }

            set
            {
                punkte = value;
            }
        }

        public FormSpielfeld()
        {
            InitializeComponent();
            bilder = Logik.mischen();

            var pictureBoxes = Controls.OfType<PictureBox>();
            pb.Add(pb1);
            pb.Add(pb2);
            pb.Add(pb3);
            pb.Add(pb4);
            pb.Add(pb5);
            pb.Add(pb6);
            pb.Add(pb7);
            pb.Add(pb8);
            pb.Add(pb9);
            pb.Add(pb10);
            pb.Add(pb11);
            pb.Add(pb12);
            pb.Add(pb13);
            pb.Add(pb14);
            pb.Add(pb15);
            pb.Add(pb16);
            pb.Add(pb17);
            pb.Add(pb18);
            pb.Add(pb19);
            pb.Add(pb20);
            pb.Add(pb21);
            pb.Add(pb22);
            pb.Add(pb23);
            pb.Add(pb24);

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
        }

        private void klick(PictureBox p, int id)
        {
            Logik.Zug++;
            p.Image = bilder[id];
            if (Logik.Zug == 1)
            {
                tmpImg = p.Image;
                tmpID = id;
            }
            else if (Logik.Zug == 2)
            {
                if (Logik.checkCards(p.Image, tmpImg, id, tmpID))
                {
                    lblPunkteVaule.Text = Punkte.ToString();
                }
            }

        }
        private void pb1_Click(object sender, EventArgs e)
        {
            klick(pb1, 0);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            klick(pb2, 1);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            klick(pb3, 2);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            klick(pb4, 3);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            klick(pb5, 4);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            klick(pb6, 5);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            klick(pb7, 6);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            klick(pb8, 7);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            klick(pb9, 8);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            klick(pb10, 9);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            klick(pb11, 10);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            klick(pb12, 11);
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            klick(pb13, 12);
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            klick(pb14, 13);
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            klick(pb15, 14);
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            klick(pb16, 15);
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            klick(pb17, 16);
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            klick(pb18, 17);
        }

        private void pb19_Click(object sender, EventArgs e)
        {
            klick(pb19, 18);
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            klick(pb20, 19);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            klick(pb21, 20);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            klick(pb22, 21);
        }

        private void pb23_Click(object sender, EventArgs e)
        {
            klick(pb23, 22);
        }

        private void pb24_Click(object sender, EventArgs e)
        {
            klick(pb24, 23);
        }

    }
}
