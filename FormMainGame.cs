using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;



namespace QuickTyping
{
    public partial class FormMainGame : Form
    {
        
        FinishClass fc = new FinishClass();
        ClassTextEdit cst = new ClassTextEdit();
        DateTime start;
        DateTime end;
        Color rightColor;
        Color wrongColor;

        
        int currentWord = 0;
        int currentChar = 0;
        bool started = false;
        string lastChange = "";
        string[] text = { };
        int timer;
        TimeSpan timeSpent;
       
       
        public void FormMainGame_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public FormMainGame()
        {
           
            InitializeComponent();
            this.ActiveControl = textBoxTyping;
            StartGame();
        }

       public void StartGame()
        {
            var parser = new FileIniDataParser();
            IniData ColorData = parser.ReadFile(@"Profiles\TempProfile.ini");
            rightColor = Color.FromName(ColorData["Profile"]["rightColor"]);
            wrongColor = Color.FromName(ColorData["Profile"]["wrongColor"]);
            text = cst.PrepareText();
            cst.DisplayText(currentWord,text,challengeText,labelFinish,ButtonStats,labelAuthor);

        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
            if (!started)
            {
                started = true;
                start = DateTime.Now;
                timerCountdown.Enabled = true; 
                
            }

            currentChar = textBoxTyping.Text.ToCharArray().Length;
            
            try
            {
               
                    if (textBoxTyping.Text == text[currentWord])
                    {
                        currentWord++;
                        cst.DisplayText(currentWord, text, challengeText, labelFinish, ButtonStats,labelAuthor);
                        textBoxTyping.Clear();

                    }
                    if (lastChange.Length > textBoxTyping.Text.Length)
                    {
                        cst.RightWrong(textBoxTyping, text, currentWord, currentChar, rightColor, wrongColor, true);
                    }
                    else
                    {
                        cst.RightWrong(textBoxTyping, text, currentWord, currentChar, rightColor, wrongColor, false);
                    }

                    lastChange = textBoxTyping.Text;
                
            
            }
            catch (IndexOutOfRangeException)
            {
                
                textBoxTyping.ReadOnly = true;
                end = DateTime.Now;
                timerCountdown.Stop();
            }
           
        }

        private void ButtonStats_Click(object sender, EventArgs e)
        {
            timeSpent = (start - end);
            cst.SendStats(timeSpent);
          
        }

        private void timerWPM_Tick(object sender, EventArgs e)
        {
     
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            timer++;
            TimeSpan ts = TimeSpan.FromSeconds(timer);
            labelCountdown.Text = string.Format("{0}", new DateTime(ts.Ticks).ToString("mm:ss"));
        }
    }
}
