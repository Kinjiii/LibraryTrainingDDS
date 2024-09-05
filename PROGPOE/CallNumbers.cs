using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROGPOE.CallNumbers;


namespace PROGPOE
{
    public partial class CallNumbers : Form
    {
//----------------------------------------------------------Initializing Lists and Variables------------------------------------------------------------------------------------
        /// <summary>
        /// declaring variables
        /// </summary>
        private Button[] choices;
        private Label Question;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

//----------------------------------------------------------Initializing Form, Controls and Functionality------------------------------------------------------------------------------------

        public CallNumbers()
        {
            InitializeComponent();
            InitializeGame();
        }
//----------------------------------------------------------Method to start the game------------------------------------------------------------------------------------
        /// <summary>
        /// declaring variables, and methods from separate class
        /// </summary>
        private void InitializeGame()
        {

            choices = new Button[] { choice1, choice2, choice3, choice4 };
            Question = label1;
            CallNumbersTree.totalPoints = 0;
            highscore.Text = CallNumbersTree.highScore.ToString();
            CallNumbersTree.GenerateRandomQuestion();
            CallNumbersTree.InsertDataIntoNodes(choices);
            CallNumbersTree.FindLabel(Question);

            // change the music by commenting in or out one below
            // Please be aware that the volume of the music is based on system volume.
            //player.SoundLocation = "backgroundMusic.wav";

            player.SoundLocation = "starWars.wav";
        }

//------------------------------------------------------------------Toggle Music Button------------------------------------------------------------------------------------

        private void musicBtn_Click(object sender, EventArgs e)
        {
            if (musicBtn.Text == "Music")
            {
                player.Play();
                musicBtn.BackColor = Color.Green; //symbolizes music turned on
                musicBtn.Text = "Music OFF";

            }

            else if (musicBtn.Text == "Music OFF")
            {
                player.Stop();
                musicBtn.BackColor = Color.White; //symbolizes music turned off
                musicBtn.Text = "Music";

            }
        }

//---------------------------------------------------------------------Back Button------------------------------------------------------------------------------------

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Show();
        }

//---------------------------------------------------------------------Help Button------------------------------------------------------------------------------------

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the correct root on the left that you think " + "\ncorresponds to the phrase shown above",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

            Form form = new Form();
            form.Size = new Size(1100, 800);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.ImageLocation = "https://www.salinecountylibrary.org/wp-content/uploads/2022/06/3cdda41e2aeae0b42f5e948823d56a2d.jpg";
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            form.Controls.Add(pictureBox);

            form.ShowDialog();

        }

//----------------------------------------------------------Button Choice Actions------------------------------------------------------------------------------------

        private void choice1_Click(object sender, EventArgs e)
        {
            if (CallNumbersTree.InitButton(sender, choices, currentPoints))
            {
                InitializeGame();
            };
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            if (CallNumbersTree.InitButton(sender, choices, currentPoints))
            {
                InitializeGame();
            };
        }

        private void choice3_Click(object sender, EventArgs e)
        {
            if (CallNumbersTree.InitButton(sender, choices, currentPoints))
            {
                InitializeGame();
            };
        }

        private void choice4_Click(object sender, EventArgs e)
        {
            if (CallNumbersTree.InitButton(sender, choices, currentPoints))
            {
                InitializeGame();
            };
        }

//----------------------------------------------------------Closing form------------------------------------------------------------------------------------
        /// <summary>
        /// Feedback from Task 2 application now closes properly on each form page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

//----------------------------------------------------------oO0End of File0Oo------------------------------------------------------------------------------------
