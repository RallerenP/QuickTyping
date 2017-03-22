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
        string[] text = { };


        public FormMainGame()
        {
           
            InitializeComponent();
            this.ActiveControl = textBoxTyping;
            StartGame();
        }

       public void StartGame()
        {
            
            text = cst.PrepareText(1);
            cst.DisplayText(currentWord,text,challengeText,labelFinish);

          
            
        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTyping.Text == text[currentWord] + " ")
                {
                    currentWord++;
                    cst.DisplayText(currentWord, text, challengeText, labelFinish);
                    textBoxTyping.Clear();

                }
            }
            catch (IndexOutOfRangeException)
            {

            }
           
        }
    }
}
