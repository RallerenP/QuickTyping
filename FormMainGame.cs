﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        DateTime start;
        DateTime end;

        //100 lines of code... 

        
       
        
        int currentWord = 0;
        int currentChar = 0;
        bool destructive = false;
        bool started = false;
        string[] text = { };
        TimeSpan timeSpent;
       
       
        public void FormMainGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                destructive = true;
            }
            else
            {
                destructive = false;
               
            }
        }

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
                start = DateTime.Now;
                var sw = Stopwatch.StartNew();
                
            }

            currentChar = textBoxTyping.Text.ToCharArray().Length;
            cst.RightWrong(textBoxTyping, text, currentWord, currentChar, Color.LightGreen, Color.Red, destructive);
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
                
                textBoxTyping.ReadOnly = true;
                end = DateTime.Now;
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
            timeLeft--;
        }
    }
}
