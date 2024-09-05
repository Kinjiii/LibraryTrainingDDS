using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGPOE
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Ability to add music to the "game" bonus marks maybe?
        /// </summary>
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
//----------------------------------------------------------Initializing Form, Disabling Buttons and adding Music------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            // change the music by commenting in or out one below
            // Please be aware that the volume of the music is based on system volume.
            // I could add more options but .wav files get really big and the project would end up increasing too much in size
            //player.SoundLocation = "backgroundMusic.wav";
            
            player.SoundLocation = "starWars.wav";
        }
        /// <summary>
        /// Button to redirect to the Dewey Decimal information screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readBooksBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeweyDecimalLanding deweydl = new DeweyDecimalLanding();
            deweydl.Show();
        }

//----------------------------------------------------------Toggle Music Button------------------------------------------------------------------------------------        
        /// <summary>
        /// Option to toggle music on or off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Music")
            {
                player.Play();
                button1.BackColor = Color.Green; //symbolizes music turned on
                button1.Text = "Music OFF";

                
            }

            else if (button1.Text == "Music OFF")
            {
                player.Stop();
                button1.BackColor = Color.White; //symbolizes music turned off
                button1.Text = "Music";
                
            }
        }

        /// <summary>
        /// Feedback from Task 2 application now closes properly on each form page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void callNoBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CallNumbers callNo = new CallNumbers();
            callNo.Show();
        }
    }
}

//----------------------------------------------------------oO0End of File0Oo------------------------------------------------------------------------------------
