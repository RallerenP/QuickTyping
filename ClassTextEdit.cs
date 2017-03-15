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
        //Sets the specified text color to the specified color
        public void AppendTextBox(RichTextBox textBox, Color color, string text)
        {
            textBox.Clear();
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
            string challengeText = "";
            string[] text = File.ReadAllLines(challengeNumber);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i][0] != '$')
                {
                    challengeText = text[i];
                }
            }

            
            string[] arrayToReturn = challengeText.Split(' ');
            return arrayToReturn;
        }

        public void DisplayText(int current, string[] displayText, RichTextBox textBox)
        {
            
            string textToDisplay = "";
            for (int j = 0; j < displayText.Length; j++)
            {
                if (j - current >= 1)
                {
                    textToDisplay += " " + displayText[j];
                }
            }

            AppendTextBox(textBox, Color.Gray, displayText[current]);
            AppendTextBox(textBox, Color.Black, textToDisplay);
         
   



        }
    }
}
