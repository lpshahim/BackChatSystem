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
using Newtonsoft.Json;
using System.IO;
using System.Net;
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


            var filePath = "";
            var name = "";
            InputBox("File Name", "Save file as", ref name);
            filePath = name;
            mciSendString("save recsound " + "C:\\test\\" + filePath + ".wav", null, 0, 0);
            mciSendString("save recsound " + filePath, null, 0, 0);
         
            mciSendString("close recsound ", null, 0, 0);
       
            filePath = "C:\\test\\" + filePath + ".wav";
            long length = new System.IO.FileInfo(filePath).Length;
            string fileSize = SizeSuffix(length);
            byte[] rec = File.ReadAllBytes(filePath);
            DateTime dateValue = DateTime.Now;
         
            AddRecording r = new AddRecording(dateValue.ToString(), name, fileSize, rec, ".wav");
            addRecording(r);

           // removeRecording();
        }
        static readonly string[] SizeSuffixes =
                  { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }

            int i = 0;
            decimal dValue = (decimal)value;
            while (Math.Round(dValue / 1024) >= 1)
            {
                dValue /= 1024;
                i++;
            }

            return string.Format("{0:n1} {1}", dValue, SizeSuffixes[i]);
        }
        private void removeRecording()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("C:\\test\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        static void addRecording(AddRecording r)
        {
            string json = JsonConvert.SerializeObject(r);

            string sendPersonURL = "http://m23598840.puk.ac.za/addFile.php";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sendPersonURL);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = json.Length;

            try
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Close();

                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        //  MessageBox.Show("R : " + result);
                    }
                }
            }
            catch (WebException wex)
            {
                MessageBox.Show("Error connecting to webservice: " + wex.Message);
            }

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            mciSendString("stop recsound", "", 0, 0);
            mciSendString("close recsound", "", 0, 0);
        }
        #region Input
        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = title;
            label.Text = promptText;

            textBox.Text = value;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }
        #endregion
    }
}
