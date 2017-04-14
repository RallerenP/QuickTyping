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
        ClassTextEdit cst = new ClassTextEdit();
        int currentWord = 0;
        int currentChar = 0;
        string[] text = { };
        bool ended = false;


        public FormMainGame()
        {
           
            InitializeComponent();
            this.ActiveControl = textBoxTyping;
            labelWin.Visible = false;
            StartGame();
        }

       public void StartGame()
        {
            
            text = cst.PrepareText(1);
            cst.DisplayText(currentWord,text,challengeText);

          
            
        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
         
            if (ended == false  && textBoxTyping.Text == text[currentWord] + " ")
                {
                    currentWord++;
                    ended = cst.DisplayText(currentWord, text, challengeText);
                    textBoxTyping.Clear();

            }
         
           
        }
    }
}
