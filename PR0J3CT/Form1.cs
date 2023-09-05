/*
=============================================================
FileName: Form1.cs
Programmer: Zwelethu Jr. Nkosi
Description: This is the file with all the code written by programmer.
=============================================================
*/

using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace PR0J3CT
{
    public partial class Form1 : Form
    {
        string blocked;
        StringBuilder blockedCopy;
        string chosen;
        int incorrects;

        ArrayList correctArr = new ArrayList();
        ArrayList incorrectArr = new ArrayList();
        SortedList highScores = new SortedList();

        // words that can be guessed in the game are added into the list
        ArrayList words = new ArrayList() 
        {
            "SUCCESS",
            "MONEY",
            "ANGEL",
            "SCHOOL",
            "WATERMELON",
            "BLOOD",
            "NITROGEN",
            "LOVE",
            "CAMPUS",
            "DENTIST",
            "TURBO",
            "BEAKER"

        };

        public Form1()
        {
            InitializeComponent();
        }

        //an image array to show when you either win or lose
        private Bitmap[] game_status = new Bitmap[]
        {
            PR0J3CT.Properties.Resources.blank,
            PR0J3CT.Properties.Resources.GAMOVER,
            PR0J3CT.Properties.Resources.you_win,
        };

        //an image array of all the 10 strikes that is drawn for every strike
        private Bitmap[] picture_iterate = new Bitmap[]
        {
            PR0J3CT.Properties.Resources._1,
            PR0J3CT.Properties.Resources._2,
            PR0J3CT.Properties.Resources._3,
            PR0J3CT.Properties.Resources._4,
            PR0J3CT.Properties.Resources._5,
            PR0J3CT.Properties.Resources._6,
            PR0J3CT.Properties.Resources._7,
            PR0J3CT.Properties.Resources._8,
            PR0J3CT.Properties.Resources._9,
            PR0J3CT.Properties.Resources._10,
            PR0J3CT.Properties.Resources.full,
        };

        //Main method of the game all gameplay code is here
        private void Gameplay(char key)
        {
            if (Char.IsLetter(key))
            {
                try
                {
                    if (chosen.Contains(key))
                    {

                        for (int i = 0; i < chosen.Length; i++)
                        {
                            if (key == chosen[i])
                            {
                                correctArr.Add(key);
                                blockedCopy[i] = key;
                                wordLable.Text = blockedCopy.ToString();
                                if (blockedCopy.ToString().Contains('-') == false)
                                {
                                    KeyPreview = false;
                                    gameStatusPB.Image = game_status[2];
                                    startBtn.Text = "RESTART";
                                    buttonPanel.BringToFront();
                                    if (highScores.ContainsKey(chosen))
                                    {
                                        if ((int)highScores[chosen] > incorrects)
                                        {
                                            highScores[chosen] = incorrects;
                                            highscoreList.Items.Clear();
                                            foreach (string item in highScores.Keys)
                                            {
                                                string words = item.ToString();
                                                int value = (int)highScores[words];
                                                string totScore = $"{words}: {value}";
                                                highscoreList.Items.Add(totScore);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        highScores.Add(chosen, incorrects);
                                        highscoreList.Items.Add($"{chosen}: {incorrects}");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (incorrects < 9)
                        {
                            if (incorrectArr.Contains(key) == false)
                            {
                                incorrects++;
                                mainPB.Image = picture_iterate[incorrects];
                                incorrectArr.Add(key);
                                incorrectList.Items.Clear();
                                foreach (char letter in incorrectArr)
                                {
                                    incorrectList.Items.Add(letter);
                                }
                            }
                        }
                        else
                        {
                            KeyPreview = false;
                            mainPB.Image = picture_iterate[10];
                            gameStatusPB.Image = game_status[1];
                            startBtn.Text = "RESTART";
                            buttonPanel.BringToFront();
                        }
                    }
                }

                catch(NullReferenceException)
                {
                    MessageBox.Show("Please start game first");
                }
            }
        }
        
        private void startBtn_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            correctArr.Clear();
            incorrectArr.Clear();
            incorrectList.Items.Clear();

            buttonPanel.SendToBack();
            incorretsLable.Text = "INCORRECT";
            highscoreLable.Text = "HIGHSCORES";
            mainPB.Image = picture_iterate[0];
            gameStatusPB.Image = game_status[0];
            buttonPanel.Location = new System.Drawing.Point(132, 12);

            Random random = new Random();
            int randomIndex = random.Next(0, words.Count - 1);

            chosen = words[randomIndex].ToString();
            blocked = new String('-', chosen.Length);
            blockedCopy = new StringBuilder(blocked);

            incorrects = 0;
            wordLable.Text = blockedCopy.ToString();
        }

        // Exit button which quits the program
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // keypress event to handle the key presses
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyPressed = e.KeyChar.ToString().ToUpper();
            char keyCopy = Char.Parse(keyPressed);
            Gameplay(keyCopy);
            
        }
    }
}