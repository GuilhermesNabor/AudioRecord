using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace Record
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveOut waveOut;
        private WaveFileWriter writer;
        private WaveFileReader reader;
        public Form1()
        {
            InitializeComponent();
            InitializeAudio();
        }
        private void InitializeAudio()
        {
            waveIn = new WaveInEvent();
            waveIn.DataAvailable += WaveIn_DataAvailable;

            waveOut = new WaveOut();

            waveIn.WaveFormat = new WaveFormat(44100, 16, 2);
        }
        private void BtnStartRecording_Click_Click(object sender, EventArgs e)
        {
            writer = new WaveFileWriter("output.wav", waveIn.WaveFormat);
            waveIn.StartRecording();
        }
        private void BtnStopRecording_Click_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();
            writer.Close();
        }
        private void BtnStartPlayback_Click_Click(object sender, EventArgs e)
        {
            reader = new WaveFileReader("output.wav");
            waveOut.Init(reader);
            waveOut.Play();
        }
        private void BtnStopPlayback_Click_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
            reader.Close();
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utiliza a biblioteca NAudio.\nFeito em C#\nCriado por: Guilherme Nabor\nGitHub: @GuilhermesNabor", "Sobre o programa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}