using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Record : Form
    {
        public Form2 frm2;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        public Record()
        {
            InitializeComponent();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            mciSendString("open new Type waveaudio Alias recsound", null, 0, 0);
            mciSendString("set recsound time format ms bitspersample 16 channels 2 samplespersec 48000 bytespersec 192000 alignment 4", null, 0, 0);
            mciSendString("record recsound", null, 0, 0);
            MessageBox.Show("Recording");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mciSendString("stop recsound", "", 0, 0);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mciSendString("stop recsound", "", 0, 0);

            mciSendString("play recsound from 0", "", 0, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var filePath = "C:\\test\\result.wav";
            mciSendString("save recsound " + filePath, null, 0, 0);
            mciSendString("close recsound ", null, 0, 0);
            MessageBox.Show("File Created");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            mciSendString("stop recsound", "", 0, 0);
            mciSendString("close recsound", "", 0, 0);
        }
    }
}
