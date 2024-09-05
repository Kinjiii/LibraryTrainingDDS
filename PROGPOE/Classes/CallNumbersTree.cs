using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PROGPOE
{
    internal class CallNumbersTree
    {
//----------------------------------------------------------Initializing Lists and Variables------------------------------------------------------------------------------------

        // declaring variables and constants
        public static int TOP_LEVELS = 7;
        public static int LEVELS = 3;
        public static int OPTIONS = 4;
        public static int totalPoints = 0; 
        public static int deduct = -250;
        public static int add = 500;
        public static int highScore = 0;

        public static int currentLevel;
        public static int TopLevelNodes;
        public static int[] selected = new int[LEVELS];
        public static string[] answers = new string[LEVELS];
        static Node root;
        public static Random random = new Random();
        public static List<int> L1 = new List<int>();

        //declaring file path, the file is stored in the bin->debug folder
        private static string FILE_PATH = "tree.txt";
//----------------------------------------------------------Methods to be used for data insertion into tree and on form------------------------------------------------------------------------------------

        /// <summary>
        /// Inserting data from file into the tree
        /// </summary>
        /// <param name="buttons"></param>
        public static void InsertDataIntoNodes(Button[] buttons)
        {
            // Declaring the root within the tree
            root = newNode("Dewey Decimal", "System");

            // reset current level to 0 when populating tree
            currentLevel = 0;

            // get file to read tree data
            string[] lines = File.ReadAllLines(FILE_PATH);

            int q = 0; 
            int w = 0;

            foreach (string line in lines)
            {
                string[] words = line.Split('+');

                // case is the number associated with call number level (level 1, 2, 3)
                switch (words[0])
                {
                    case "1":
                        root.child.Add(newNode(words[1], words[2]));
                        w = 0;
                        q++;
                        break;
                    case "2":
                        root.child[q - 1].child.Add(newNode(words[1], words[2]));
                        w++;
                        break;
                    case "3":
                        root.child[q - 1].child[w - 1].child.Add(newNode(words[1], words[2]));
                        break;
                }
            }
            TopLevelNodes = q;
            AddAnswersToButtons(buttons);
        }

        /// <summary>
        /// Node class
        /// </summary>
        public class Node
        {
            public string key;
            public string value;
            public List<Node> child = new List<Node>();
        };

        /// <summary>
        /// function to create a new tree node
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Node newNode(string key, string value)
        {
            Node temp = new Node();
            temp.key = key;
            temp.value = value;
            return temp;
        }

        /// <summary>
        /// Adds choices to buttons with call numbers and descriptions from tree
        /// </summary>
        /// <param name="buttons"></param>
        public static void AddAnswersToButtons(Button[] buttons)
        {
            string[] calls = new string[OPTIONS];

            switch (currentLevel)
            {
                case 0:
                    for (int i = 0; i < OPTIONS; i++)
                    {
                        calls[i] = root.child[L1[i]].key + "\n" + root.child[L1[i]].value;
                    }
                    break;
                case 1:
                    for (int i = 0; i < OPTIONS; i++)
                    {
                        calls[i] = root.child[selected[0]].child[i].key + "\n" + root.child[selected[0]].child[i].value;
                    }
                    break;
                case 2:
                    for (int i = 0; i < OPTIONS; i++)
                    {
                        calls[i] = root.child[selected[0]].child[selected[1]].child[i].key + "\n" + root.child[selected[0]].child[selected[1]].child[i].value;
                    }
                    break;
            }

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = calls[i];
            }
        }

        /// <summary>
        /// Generates a random question 
        /// </summary>
        public static void GenerateRandomQuestion()
        {
            L1.Clear();
            while (L1.Count != 4)
            {
                int r = random.Next(0, TOP_LEVELS);
                if (!L1.Contains(r))
                {
                    L1.Add(r);
                }
            }
            L1.Sort();
        }

        /// <summary>
        /// Array is checked with the tree to see if button clicked matches question
        /// </summary>
        public static void SetAnswers()
        {
            try
            {
                answers[0] = root.child[selected[0]].key + "\n" + root.child[selected[0]].value;
                answers[1] = root.child[selected[0]].child[selected[1]].key + "\n" + root.child[selected[0]].child[selected[1]].value;
                answers[2] = root.child[selected[0]].child[selected[1]].child[selected[2]].key + "\n" + root.child[selected[0]].child[selected[1]].child[selected[2]].value;
            }
            catch (Exception ex)
            {
                
            }
           
        }

        /// <summary>
        /// Generates the question asked
        /// </summary>
        /// <param name="label"></param>
        public static void FindLabel(Label label)
        {
            while (true)
            {
                int r = random.Next(0, TOP_LEVELS);
                if (L1.Contains(r))
                {
                    selected[0] = r;
                    break;
                }
            }

            for (int i = 1; i < LEVELS; i++)
            {
                selected[i] = random.Next(0, LEVELS);
            }

            SetAnswers();
            label.Text = "Where do you think\n" + root.child[selected[0]].child[selected[1]].child[selected[2]].value + " belongs?";
        }

        /// <summary>
        /// When button choice is selected this method will be called
        /// </summary>
        /// <param name="btnSender"></param>
        /// <param name="buttons"></param>
        /// <param name="label"></param>
        /// <returns></returns>

 //----------------------------------------------------------Methods to add answers to buttons and check answers------------------------------------------------------------------------------------

        public static bool InitButton(object btnSender, Button[] buttons, Label label)
        {
            Button btn = (Button)btnSender;

            if (CheckAnswer(btn.Text))
            {
                currentLevel++;
                AddPoints(label);
                if (currentLevel == 3)
                {
                    MessageBox.Show("Good Job!" + "\nYou scored: " + totalPoints, "Winner!");
                    return true;
                }
                AddAnswersToButtons(buttons);
            }
            else
            {
                currentLevel++;
                MinusPoints(label);
                MessageBox.Show("Whoops!" + "\nCorrect answer was:\n\n" + answers[currentLevel - 1], "Incorrect!");
                if (currentLevel == 3)
                {
                    return true;
                }
                AddAnswersToButtons(buttons);
            }
            return false;
        }

        /// <summary>
        /// Checks if the correct answer was picked
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public static bool CheckAnswer(string answer)
        {
            if (!answer.Equals(answers[currentLevel]))
            {
                return false;
            }
            return true;
        }


//----------------------------------------------------------Gamificiation Functionality------------------------------------------------------------------------------------

        /// <summary>
        /// Deducts points if user picked incorrect answer
        /// </summary>
        /// <param name="label"></param>
        public static void MinusPoints(Label label)
        {
            // minus points
            totalPoints += deduct;
            label.Text = totalPoints.ToString();
        }

        /// <summary>
        /// Adds points if user picked correct answer
        /// </summary>
        /// <param name="label"></param>
        public static void AddPoints(Label label)
        {
            // calculate points
            totalPoints += add;

            HighScore(totalPoints);

            // add points
            label.Text = totalPoints.ToString();
        }

        /// <summary>
        /// Updates highscore based on users current score
        /// </summary>
        /// <param name="score"></param>
        public static void HighScore(int score)
        {
            // check if it is a new high score
            if (score > highScore)
            {
                highScore = score;
            }
        }
    }
}

//----------------------------------------------------------oO0End of File0Oo------------------------------------------------------------------------------------
