using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuickTyping
{
    public partial class FormMainGame : Form
    {
        FinishClass fc = new FinishClass();
        ClassTextEdit cst = new ClassTextEdit();
        int currentWord = 0;
        int currentChar = 0;
        bool started = false;
        string[] text = { };
        double timeSpent = 0;
       
       


        public FormMainGame()
        {
           
            InitializeComponent();
            this.ActiveControl = textBoxTyping;
            StartGame();
        }

       public void StartGame()
        {
            
            text = cst.PrepareText(1);
            cst.DisplayText(currentWord,text,challengeText,labelFinish,ButtonStats);

        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
            if (!started)
            {
                started = true;
                timerWPM.Start();
            }

            currentChar = textBoxTyping.Text.ToCharArray().Length;
            cst.RightWrong(textBoxTyping, text, currentWord, currentChar, Color.LightGreen, Color.Red);
            try
            {
                
                if (textBoxTyping.Text == text[currentWord] + " ")
                {
                    currentWord++;
                    cst.DisplayText(currentWord, text, challengeText, labelFinish, ButtonStats);
                    textBoxTyping.Clear();
                    
                }
            }
            catch (IndexOutOfRangeException)
            {
                timerWPM.Stop();
                textBoxTyping.ReadOnly = true;
            }
           
        }

        private void ButtonStats_Click(object sender, EventArgs e)
        {
            fc.EndGame(timeSpent);
        }

        private void timerWPM_Tick(object sender, EventArgs e)
        {
            timeSpent += 0.001;
        }
    }
}
