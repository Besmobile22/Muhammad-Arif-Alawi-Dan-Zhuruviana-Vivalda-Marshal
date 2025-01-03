using System;
using System.Media;
using System.IO;
using NAudio.Wave;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace RealDrumApp
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string tempFilePath = "tempRecording.wav"; // Lokasi sementara untuk rekaman
        private string filePath; // Variabel untuk menyimpan lokasi file yang disimpan
        private DateTime lastKeyPressTime; // Waktu penekanan tombol terakhir
        private const int DoublePressThreshold = 500; // Batas waktu untuk double press (dalam milidetik)

        public Form1()
        {
            InitializeComponent();
            filePath = "recordedAudio.wav"; // Lokasi file rekaman
            this.KeyDown += new KeyEventHandler(Form_KeyDown); // Menambahkan handler KeyDown
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1) // Tombol 1
            {
                string filePathKick1 = @"C:\Audio drum\kick1.wav";
                PlaySound(filePathKick1);
            }
            if (e.KeyCode == Keys.D2) // Tombol 2
            {
                string filePathKick2 = @"C:\Audio drum\close hh.wav";
                PlaySound(filePathKick2);
            }
            if (e.KeyCode == Keys.D3) // Tombol 2
            {
                string filePathKick2 = @"C:\Audio drum\snare.wav";
                PlaySound(filePathKick2);
            }
            if (e.KeyCode == Keys.D4) // Tombol 2
            {
                string filePathKick2 = @"C:\Audio drum\crash1.wav";
                PlaySound(filePathKick2);
            }
        }

        private void PlayKickSound(string v)
        {
            string filePath = @"C:\Audio drum\kick1.wav"; // Ubah ke path file Anda

            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Play();
                }
                else
                {
                    MessageBox.Show("File suara tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void PlayKickSound(Action<object, EventArgs> btnKick1_Click)
        {
            try
            {
                // Tentukan path file suara kick berdasarkan nama file yang diberikan
                string filePath = @"C:\Audio drum\" + fileName; // Pastikan file ini ada di lokasi yang benar
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Play(); // Memainkan suara secara langsung (asinkron)
                }
                else
                {
                    MessageBox.Show($"File suara {fileName} tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Tangani exception jika ada kesalahan saat memutar suara
                MessageBox.Show($"Terjadi kesalahan saat memutar suara: {ex.Message}");
            }
        }

        private string outputFilePath = "recordedAudio.wav"; // Lokasi file rekaman
        private string fileName;

        private void button10_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\ride.wav");
        }

        private void btnSplash_Click_1(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\splash.wav");

        }

        private void btnFloor_Click_1(object sender, EventArgs e)

        {
            PlaySound(@"C:\Audio drum\floor.wav");
        }

        private void btnCrash1_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\Crash1.wav");

        }

        private void btnCrash2_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\crash2.wav");

        }

        private void btnTom1_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\tom1.wav");
        }

        private void bnTom2_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\tom2.wav");
        }

        private void btnTom3_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\tom3.wav");
        }

        private void btnCloseHH_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\close hh.wav");
        }

        private void btnOpenHH_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\open hh.wav");
            string soundPath = "Audio/snare.wav";

        }

        private void btnKick1_Click(object sender, EventArgs e)
        {
            // Memutar suara kick1 di thread terpisah
            Task.Run(() => PlaySound(@"C:\Audio drum\kick1.wav"));
        }

        private void btnKick2_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\kick2.wav");
            string soundPath = "Audio/snare.wav";

        }

        private void btnSnare_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Audio drum\snare.wav");
            string soundPath = "Audio/snare.wav";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cari kontrol di posisi kursor mouse
            var control = this.GetChildAtPoint(pictureBox2.PointToClient(Cursor.Position));

            // Jika kontrol adalah Button, jalankan event Click
            if (control is Button button)
            {
                button.PerformClick();
            }
            pictureBox2.Enabled = false;

        }
       private void PlaySound(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Task.Run(() =>
                    {
                        using (var audioFile = new AudioFileReader(filePath))
                        using (var outputDevice = new WaveOutEvent())
                        {
                            outputDevice.Init(audioFile);
                            outputDevice.Play();
                            while (outputDevice.PlaybackState == PlaybackState.Playing)
                            {
                                System.Threading.Thread.Sleep(100);
                            }
                        }
                    });
                }
                else
                {
                    MessageBox.Show($"File suara tidak ditemukan: {filePath}",
                                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memutar suara: {ex.Message}",
                                "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void StartRecording()
        {
            try
            {
                waveIn = new WaveInEvent();
                waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1 kHz, Mono
                waveIn.DataAvailable += OnDataAvailable;
                waveIn.RecordingStopped += OnRecordingStopped;

                writer = new WaveFileWriter(tempFilePath, waveIn.WaveFormat);

                waveIn.StartRecording();
                lblStatus.Text = "Recording...";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            }
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            try
            {
                // Memastikan bahwa waveIn tidak null sebelum melakukan Dispose
                if (waveIn != null)
                {
                    waveIn.StopRecording(); // Menghentikan rekaman
                    waveIn.Dispose(); // Membersihkan sumber daya waveIn
                    waveIn = null; // Mengatur waveIn ke null setelah dibuang
                }

                // Memastikan bahwa writer tidak null sebelum melakukan Dispose
                if (writer != null)
                {
                    writer.Close(); // Menutup file rekaman
                    writer.Dispose(); // Membebaskan sumber daya
                    writer = null; // Mengatur writer ke null setelah dibuang
                }

                // Mengupdate label status
                lblStatus.Text = "Recording Stopped.";

                // Menampilkan dialog untuk menyimpan file rekaman
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "WAV Files|*.wav";
                    saveFileDialog.DefaultExt = "wav";
                    saveFileDialog.FileName = "recordedAudio";

                    // Jika pengguna memilih lokasi untuk menyimpan
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = saveFileDialog.FileName; // Menyimpan jalur file yang dipilih oleh pengguna

                        // Pastikan file sementara ada
                        if (File.Exists(tempFilePath))
                        {
                            // Menyalin file rekaman sementara ke lokasi yang dipilih oleh pengguna
                            File.Copy(tempFilePath, filePath, true);
                            MessageBox.Show($"File rekaman berhasil disimpan di: {filePath}");
                        }
                        else
                        {
                            MessageBox.Show("File rekaman sementara tidak ditemukan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani eksepsi jika terjadi error dalam proses perekaman
                MessageBox.Show($"Terjadi kesalahan saat menghentikan rekaman: {ex.Message}");
            }
        }

        // Event handler ketika data audio tersedi

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void StopRecording()
        {

            try
            {
                MessageBox.Show("Perekaman dihentikan.");

                if (waveIn != null)
                {
                    waveIn.StopRecording();
                    waveIn.Dispose();
                    waveIn = null;
                }

                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    writer = null;
                }

                MessageBox.Show("File perekaman selesai.");

                // Pastikan file sudah berhasil disalin
                if (File.Exists(tempFilePath))
                {
                    MessageBox.Show($"File sementara ditemukan di {tempFilePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void btnPlayRecording_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan file rekaman ada dan filePath sudah diatur dengan benar
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    using (var player = new SoundPlayer(filePath))
                    {
                        player.PlaySync(); // Memutar file secara sinkron
                    }
                }
                else
                {
                    MessageBox.Show("File rekaman tidak ditemukan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memutar file rekaman: {ex.Message}");
            }
        }
    
    }
}