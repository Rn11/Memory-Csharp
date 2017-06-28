using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;


namespace Memory
{
    public partial class FormHauptmenue : Form
    {
        public static readonly String currVer = "v0.0.2";
        


        static SoundPlayer snd0 = new SoundPlayer(Properties.Resources.soundtrack);
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public FormHauptmenue()
        {
            InitializeComponent();
            FormHauptmenue.play(2);
        }

        private void btnEinzelspieler_Click(object sender, EventArgs e)
        {
            FormSpielfeld fSpiel = new FormSpielfeld();
            fSpiel.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            FormCredits fCredits = new FormCredits();
            fCredits.Show();
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


        private void FormHauptmenue_Load(object sender, EventArgs e)
        {

        }

        public static void play(int volume)
        {
            // By the default set the volume to 0
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            FormOptionen.SliderValue = CalcVol / (ushort.MaxValue / 10);
            snd0.PlayLooping();
        }

        public static void stop()
        {
            snd0.Stop();
        }
    }
}

