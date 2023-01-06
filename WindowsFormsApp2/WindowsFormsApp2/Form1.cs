using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            for (int i =0; i<openFileDialog1.SafeFileNames.Length; i++)
            {
                listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString()); //the name of the song (the part before .mp3)
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString()); //URL address of the song
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex; // equalizes the song and their URL addresses
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); // pauses the music
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play(); // plays the music
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); //stops the music
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5; //increases the sound
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5; //decreases the sound
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value; // trackbar volume
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();     //deletes the music list
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();  //closes the player
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
