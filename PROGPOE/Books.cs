using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROGPOE
{
    public partial class Books : Form
    {

//----------------------------------------------------------Initializing Lists and Variables------------------------------------------------------------------------------------

        // Variables I attempted to use to add authors to the call numbers more info at the bottom
        /*String characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

          Random strRandom = new Random(); 

          Dictionary<double, string> list = new Dictionary<double, string>();*/

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        Random rand = new Random();

        List<double> list = new List<double>();

        List<double> unsortedUserList = new List<double>();

        List<double> sortedList = new List<double>();

        double index = 0;
        int _ticks;

//----------------------------------------------------------Initializing Form, Controls and Functionality------------------------------------------------------------------------------------
        /// <summary>
        /// Just calling methods here and initilizing the gamification feature and drag and drop functionality
        /// </summary>
        public Books()
        {
            InitializeComponent();
            GenerateDeweyDecimal();

            // change the music by commenting in or out one below
            // Please be aware that the volume of the music is based on system volume.

            //player.SoundLocation = "backgroundMusic.wav";

            player.SoundLocation = "starWars.wav";

            timer1.Start();

            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            topShelf.AllowDrop = true;
            bottomShelf.AllowDrop = true;

            topShelf.DragEnter += panel_DragEnter;
            bottomShelf.DragEnter += panel_DragEnter;

            topShelf.DragDrop += panel_DragDrop;
            bottomShelf.DragDrop += panel_DragDrop;

            foreach (Control c in this.bottomShelf.Controls)
            {
                c.MouseDown += new MouseEventHandler(c_MouseDown);
            }

        }

//----------------------------------------------------------Implementing All Drag and Drops------------------------------------------------------------------------------------
        /// <summary>
        /// Basic Drag and Drop functionalities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void c_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            c.DoDragDrop(c, DragDropEffects.Move);
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (c != null)
            {
                c.Location = this.topShelf.PointToClient(new Point(e.X, e.Y));
                this.topShelf.Controls.Add(c);
                progressBar1.Increment(1);
            }
        }

        // Overriding the NextDouble function to allow for decimals to appear in the list
        public double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }

//----------------------------------------------------------Generate Random Numbers------------------------------------------------------------------------------------
        /// <summary>
        /// Method to generate the 10 random call numbers and and them to a list
        /// </summary>
        public void GenerateDeweyDecimal()
        {
            try
            {
                while (true)
                {
                    double randomNum = NextDouble(rand, 000, 1000, 2);
                    list.Add(randomNum);
                    if (index == 10)
                    {
                        break;
                    }
                    index++;
                }

                // I know I could have used a foreach loop and the control function for this but when I did it I got lots of errors

                label1.Text = list[1].ToString();
                label2.Text = list[2].ToString();
                label3.Text = list[3].ToString();
                label4.Text = list[4].ToString();
                label5.Text = list[5].ToString();
                label6.Text = list[6].ToString();
                label7.Text = list[7].ToString();
                label8.Text = list[8].ToString();
                label9.Text = list[9].ToString();
                label10.Text = list[10].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

//----------------------------------------------------------Submit Button------------------------------------------------------------------------------------
        /// <summary>
        /// User clicks the submit button which will then add the top panel items to two new lists,
        /// one that gets sorted and one that holds the users data as it is on the app
        /// there are then compared and the resulting end game dialog will be displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();

                foreach (Control ct in topShelf.Controls)
                {
                    unsortedUserList.Add(Convert.ToDouble(ct.Text));
                    sortedList.Add(Convert.ToDouble(ct.Text));
                }

                SortAndCompare();
            }
            //catch any errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

//----------------------------------------------------------Sort Method------------------------------------------------------------------------------------
        /// <summary>
        /// Method to see whether users list is the same as the sorted list
        /// if the lists are the same the users wins, else the user loses
        /// </summary>
        private void SortAndCompare()
        {
            try
            {
                // ****Changes from Part 1****
                // now checks if users have added any books
                // previously the code ran without having any books place and would just display a Won message
                if (topShelf.Controls.Count <= 0)
                {
                    MessageBox.Show("Please re-arrange the books!");
                }
                else
                {
                    //used to see user inputted list
                    var message = string.Join(Environment.NewLine, unsortedUserList);
                    MessageBox.Show("This is what you entered: " + "\n" + message);

                    sortedList.Sort();

                    // used to see correct list
                    var sorted = string.Join(Environment.NewLine, sortedList);
                    MessageBox.Show("And this is the correct order " + "\n" + sorted);

                    if (unsortedUserList.SequenceEqual(sortedList))
                    {
                        // user wins
                        // Game end dialog
                        MessageBox.Show("You Won!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("You have reordered the books in the current order", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult result = MessageBox.Show("Do you want to continue playing?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // if yes reload form
                            Books books = new Books();
                            books.Show();
                            this.Dispose(false);
                        }
                        else if (result == DialogResult.No)
                        {
                            // if no take them back to home page
                            this.Visible = false;
                            Form1 f1 = new Form1();
                            f1.Show();

                        }
                    }

                    else
                    {
                        // user loses
                        // Game end dialog
                        MessageBox.Show("Game Over!", "You Lost!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show("Sadly you have not reordered the books in the correct order", "You Lost!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        DialogResult result = MessageBox.Show("Do you want to continue playing?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // if yes reload form
                            Books books = new Books();
                            books.Show();
                            this.Dispose(false);
                        }
                        else if (result == DialogResult.No)
                        {
                            // if no take them back to home page
                            this.Visible = false;
                            Form1 f1 = new Form1();
                            f1.Show();

                        }
                    }
                }
            }
            // catch any errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

//----------------------------------------------------------Reset Button------------------------------------------------------------------------------------
        /// <summary>
        ///  Reset Button to reset the form which then generates new numbers and resets the panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Dispose(false);
        }

//----------------------------------------------------------Toggle Music Button------------------------------------------------------------------------------------
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

//----------------------------------------------------------Back Button------------------------------------------------------------------------------------
        private void backBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Visible = false;
            DeweyDecimalLanding deweydl = new DeweyDecimalLanding();
            deweydl.Show();
        }

//----------------------------------------------------------Timer Function------------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            timer.Text = _ticks.ToString();

            if (_ticks == 60)
            {
                
                timer1.Stop();

                DialogResult dr = MessageBox.Show("Sadly you've run out of time would you like to try again?", "Times up!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    // if yes reload form
                    Books books = new Books();
                    books.Show();
                    this.Dispose(false);
                }
                else if (dr == DialogResult.No)
                {
                    // if no take them back to home page
                    this.Visible = false;
                    Form1 f1 = new Form1();
                    f1.Show();
                }
            }
        }
        /// <summary>
        /// Feedback from Task 2 application now closes properly on each form page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

//----------------------------------------------------------oO0End of File0Oo------------------------------------------------------------------------------------
