using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using FormFader;
using static System.Windows.Forms.DataFormats;

namespace UICaro
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            PlayMusic("Risk Of Rain 2.wav");

        }

        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Fader.FadeIn(this, Fader.FadeSpeed.Slow);
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
