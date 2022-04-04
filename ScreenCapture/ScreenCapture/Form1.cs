using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        VideoFileWriter vf;
        Rectangle screenSize;
        public Form1()
        {
            InitializeComponent();
            screenSize = GetSize();
            lblDimensions.Text = "width: " + screenSize.Width + " Height: " + screenSize.Height;
            btnStartRecording.Text = "Set new filepath";
        }

        private Rectangle GetSize()
        {
            //return Screen.FromControl(this).Bounds;
            //return new Rectangle(0, 0, 600, 600);
            return Screen.FromControl(this).WorkingArea;
        }

        private string GetSavePath()
        {
            return txtPath.Text + @"\"+ txtFilename.Text + "." + txtExtension.Text;
        }
        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            string savepath;

            if (timer1.Enabled)
            {
                timer1.Stop();
                vf.Close();
                btnStartRecording.Text = "Start recording";
            }
            else
            {
                try
                {
                    if (txtPath.Text == "") throw new InvalidOperationException();
                    savepath = Path.GetFullPath(GetSavePath());
                    if (File.Exists(savepath)) throw new FileLoadException();

                    screenSize = GetSize();
                    vf = new VideoFileWriter();
                    vf.Open(savepath, screenSize.Width, screenSize.Height, 25, VideoCodec.H264, 4000000);
                    timer1.Start();
                    btnStartRecording.Text = "Stop recording";
                }
                catch (Exception)
                {
                    saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Video (*.mp4)|*.mp4";
                    saveFileDialog1.DefaultExt = "mp4";
                    saveFileDialog1.AddExtension = true;
                    saveFileDialog1.FileName = DateTime.Now.ToString("yyyy.MM.dd_hh.mm.ss");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFile = saveFileDialog1.FileName.ToString();
                        txtExtension.Text = Path.GetExtension(sourceFile);
                        txtFilename.Text = Path.GetFileNameWithoutExtension(sourceFile);
                        txtPath.Text = Path.GetDirectoryName(sourceFile);

                    }
                    btnStartRecording.Text = "Start recording";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(screenSize.Width, screenSize.Height);
            Graphics gr = Graphics.FromImage(bp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bp.Width, bp.Height));

            if (chkIncludeCursor.Checked)
            {
                Rectangle cursor = new Rectangle(GetMousePosition(), new Size(10, 10));
                System.Windows.Forms.Cursor.Current.Draw(gr, cursor);
            }
            
            pictureBox1.Image = bp;
            vf.WriteVideoFrame(bp);
        }


        #region GetGlobalMousePosition

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };
        public static Point GetMousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }



        #endregion

        private void btnRunFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(GetSavePath());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
