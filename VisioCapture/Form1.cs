

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VisioForge.Core;
using VisioForge.Core.MediaPlayer;
using VisioForge.Core.Types;
using VisioForge.Core.Types.MediaPlayer;

namespace VisioCapture
{
    public partial class Form1 : Form
    {
        
        private MediaPlayerCore mp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            mp = new MediaPlayerCore(videoView1 as IVideoView);
        }

        private FileStream memoryFileStream;

        private void LoadToMemory()
        {
            if (memoryFileStream != null)
            {
                memoryFileStream.Dispose();
                memoryFileStream = null;
            }

            memoryFileStream = new FileStream(textBox1.Text, FileMode.Open);
            ManagedIStream stream = new ManagedIStream(memoryFileStream);

            // specifing settings
            // video and audio present in file. tune this settings to play audio files or video files without audio
            mp.Source_MemoryStream = new MemoryStreamSource(stream, true, true, memoryFileStream.Length);
        }

        private void setScreen()
        {
            switch (cbscreen.SelectedIndex)
            {
                case 0:
                    mp = new MediaPlayerCore(videoView1 as IVideoView);
                    break;
                case 1:
                    mp = new MediaPlayerCore(videoView2 as IVideoView);
                    break;
            }
        }

        private void SetSourceMode()
        {
            switch (cbSourceMode.SelectedIndex)
            {
                case 0:
                    mp.Source_Mode = MediaPlayerSourceMode.LAV;
                    break;
                case 1:
                    mp.Source_Mode = MediaPlayerSourceMode.GPU;
                    mp.Source_GPU_Mode = LAVGPUDecoder.NvidiaCUVID;
                    break;
                case 2:
                    mp.Source_Mode = MediaPlayerSourceMode.FFMPEG;
                    break;
                case 3:
                    mp.Source_Mode = MediaPlayerSourceMode.File_DS;
                    break;
                case 4:
                    mp.Source_Mode = MediaPlayerSourceMode.File_VLC;
                    break;
                case 5:
                    mp.Source_Mode = MediaPlayerSourceMode.BluRay;
                    break;
                case 6:
                    mp.Source_Mode = MediaPlayerSourceMode.Memory_DS;
                    LoadToMemory();
                    break;
                case 7:
                    mp.Source_Mode = MediaPlayerSourceMode.MMS_WMV_DS;
                    break;
                case 8:
                    mp.Source_Mode = MediaPlayerSourceMode.HTTP_RTSP_VLC;
                    break;
                case 9:
                    mp.Source_Mode = MediaPlayerSourceMode.Encrypted_File_DS;
                    break;
                case 10:
                    mp.Source_Mode = MediaPlayerSourceMode.MIDI;
                    break;
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            setScreen();
            SetSourceMode();
            mp.Source_GPU_Mode = LAVGPUDecoder.NvidiaCUVID;
            

            if (mp.Playlist_Add(textBox1.Text))
            {
                await mp.PlayAsync();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            await mp.StopAsync();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            videoView2.BackColor= Color.Transparent;
            Bitmap bitmap = new Bitmap("C:\\Users\\Usuario\\Pictures\\error_video3.jpg");
            videoView2.BackgroundImage = bitmap;
            videoView2.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
