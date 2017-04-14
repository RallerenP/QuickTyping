using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTyping
{
    class ClassTextEdit
    {
        Stats st = new Stats();
        int fail = 0;
        int keyStrokes = 0;
        double failPerc = 0;
        int numOfChars = 0;
        string challengeText = "";

        //Sets the specified text color to the specified color
        public void AppendTextBox(RichTextBox textBox, Color color, string text,bool clear)
        {
            if (clear == true)
            {
                textBox.Clear();
            }
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;

            textBox.SelectionColor = color;
            textBox.AppendText(text);
            textBox.SelectionColor = textBox.ForeColor;
        }

        public String[] PrepareText(int difficulty)
        {
            int maxChallenges;
            string path = "";
            Random rd = new Random();

            //Choose difficulty
            if (difficulty == 1)
            {
                path = @"Challenges/1";
                maxChallenges = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
                
            }
            else if (difficulty == 2)
            {
                path = @"Challenges/2";
                maxChallenges = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
            }
            else if (difficulty == 3)
            {
                path = @"Challenges/3";
                maxChallenges = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
            }
            else
            {
                maxChallenges = Directory.GetFiles(@"Challenges/Error", "*", SearchOption.TopDirectoryOnly).Length;
            }
           
            //Choose file
            int challenge = rd.Next(1, maxChallenges + 1);
            string challengeNumber = path + "/Challenge " + challenge.ToString() + ".txt";

            //Convert file to string[]
            
            StreamReader sr = new StreamReader(challengeNumber, System.Text.Encoding.Default);


            challengeText = "";
            string[] challengeTextArr = sr.ReadLine().Split('\n');
            for (int i = 0; i < challengeTextArr.Length; i++)
            {
                if (challengeTextArr[i][0] != '$')
                {
                    challengeText += challengeTextArr[i];
                }
            }
            
            string[] arrayToReturn = challengeText.Split(' ');
            return arrayToReturn;
        }

        //Displays the text on the given textbox
        public void DisplayText(int current, string[] displayText, RichTextBox textBox, Label win, Button finish)
        {
            
            string textToDisplay = "";
            for (int j = 0; j < displayText.Length; j++)
            {
                if (j - current >= 1)
                {
                    textToDisplay += " " + displayText[j];
                }
            }
            try
            {
                AppendTextBox(textBox, Color.Gray, displayText[current], true);
                AppendTextBox(textBox, Color.Black, textToDisplay, false);
            }
            catch (IndexOutOfRangeException)
            {
                win.Visible = true;
                finish.Visible = true; 
                textBox.Clear();
            }
        }


        //Sets color arcording to if right or wrong.
        public void RightWrong(TextBox textBox, string[] text, int currentWord, int currentChar, Color right, Color wrong, bool destructive)
        {
            
            string word = text[currentWord];
            
            string tempWord = "";
            if (!destructive)
            {
                keyStrokes++;
            }
            try
            {
                for (int i = 0; i < currentChar; i++)
                {
                    tempWord += word[i];

                }
                if (textBox.Text == tempWord)
                {
                    textBox.BackColor = right;
                    
                }
                else
                {
                    textBox.BackColor = wrong;
                    fail++;
                    
                }
               
            }
            catch (IndexOutOfRangeException)
            {

                
            }
         
        }

        public void SendStats(TimeSpan time)
        {
            st.Fails = fail;
            st.KeyStrokes = keyStrokes;
            st.Time = time;
            st.DisplayStats();
            
            st.Show();
        }
    }
}
