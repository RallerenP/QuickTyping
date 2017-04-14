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
    public partial class Stats : Form
    {

        private int fails;
        private int keyStrokes;
        private TimeSpan time;
        public Stats()
        {
            
            InitializeComponent();
            FinishClass fc = new FinishClass();
            
            
        }

        public void DisplayStats()
        {
            //Af en eller anden mærklig grund vil den ikke lave Fails og Acuraccy om til Doubles i min Math.Round. Man skal lave jit variabler for at den virker. 
            double fails = Fails;
            displayFail.Text = fails.ToString();
            double keystrokes = KeyStrokes;
            displaySrt.Text = keystrokes.ToString();
            double accuracy = Math.Round(100.0-(((fails) / keystrokes) * 100.0),2);
            labelPrecision.Text = accuracy.ToString() + "%";
            TimeSpan time = Time;
            displayTime.Text = time.ToString("mm':'ss':'fff");


        }

        public int Fails
        {
            get
            {
                return fails;
            }
            set
            {
                fails = value;
            }
        }

        public int KeyStrokes
        {
            get
            {
                return keyStrokes;
            }
            set
            {
                keyStrokes = value;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
          //For at undgå bugs skal man genstarte spillet.
            Application.Exit();
        }

      
    }
}
