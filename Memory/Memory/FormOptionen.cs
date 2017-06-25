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

namespace Memory
{
    public partial class FormOptionen : Form
    {
        private static int sliderValue = 0;

        public static int SliderValue
        {
            get
            {
                return sliderValue;
            }

            set
            {
                sliderValue = value;
            }
        }

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public FormOptionen()
        {
            InitializeComponent();
            tbVolume.Value = sliderValue;
            lblVolumeValue.Text = tbVolume.Value.ToString();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeValue.Text = tbVolume.Value.ToString();
            sliderValue = tbVolume.Value;
            // Calculate the volume that's being set. BTW: this is a trackbar!
            int NewVolume = ((ushort.MaxValue / 10) * tbVolume.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            sliderValue = tbVolume.Value;
        }

        private void FormOptionen_Load(object sender, EventArgs e)
        {

        }
    }
}
