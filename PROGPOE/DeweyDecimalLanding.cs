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
    public partial class DeweyDecimalLanding : Form
    {
        /// <summary>
        /// able to turn music on or off on any screen the button could probably be optimized through a background worker
        /// </summary>
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

//----------------------------------------------------------Initializing Form, Disabling Buttons and adding Music------------------------------------------------------------------------------------
        public DeweyDecimalLanding()
        {
            InitializeComponent();

            // change the music by commenting in or out one below
            // Please be aware that the volume of the music is based on system volume.
            //player.SoundLocation = "backgroundMusic.wav";

            player.SoundLocation = "starWars.wav";
        }

//----------------------------------------------------------Starts the Reading Books Game------------------------------------------------------------------------------------
        /// <summary>
        /// Redirects the user to the Reading Book game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books book = new Books();
            book.Show();
        }

//----------------------------------------------------------Back Button------------------------------------------------------------------------------------
        /// <summary>
        /// Redirects the user to the main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Show();
        }

//----------------------------------------------------------Toggle Music Button------------------------------------------------------------------------------------
        /// <summary>
        /// Toggle on off button for music
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
        private void DeweyDecimalLanding_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

//----------------------------------------------------------oO0End of File0Oo------------------------------------------------------------------------------------

