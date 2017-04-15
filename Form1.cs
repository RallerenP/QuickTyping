using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace QuickTyping
{
    public partial class FormMain : Form
    {

        bool profilesOpen = false;

        public FormMain()
        {
            InitializeComponent();
            comboBoxDifficulty.Items.Add("Nem");
            comboBoxDifficulty.Items.Add("Middel");
            comboBoxDifficulty.Items.Add("Svær");

            //Jeg bruger ini parser af rickyah
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(@"Profiles\Profile 1.ini");

          

            comboBoxProfiles.Items.Add("Demo");
            comboBoxProfiles.SelectedIndex = 0;


            labelRightColor.Visible = false;
            labelWrongColor.Visible = false;
            labelWrongColorInfo.Visible = false;
            labelRightColorInfo.Visible = false;
            labelProfile.Visible = false;
            labelJobModeInfo.Visible = false;
            labelRightColorIndex.Visible = false;
            labelWrongColorIndex.Visible = false;
            labelInfo.Visible = false;

            buttonSave.Visible = false;

            checkBoxJobMode.Visible = false;

            comboBoxProfiles.Visible = false;
            comboBoxRightColor.Visible = false;
            comboBoxWrongColor.Visible = false;


            //Taget fra https://www.codeproject.com/Articles/34332/Color-Picker-Combo-Box
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);

            //Han bruger Reflections til at undgå at få farverne der tilhører systemet. Det er muligt at udskifte med KnownColor for at få alle farver, selv systemfarver
            PropertyInfo[] propInfoListRight = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoListRight)
            {
                this.comboBoxRightColor.Items.Add(c.Name);
                
            }

            PropertyInfo[] propInfoListWrong = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoListWrong)
            {
                this.comboBoxWrongColor.Items.Add(c.Name);

            }

            
            comboBoxRightColor.SelectedIndex = int.Parse(data["Profile"]["rightColor"]);
            comboBoxWrongColor.SelectedIndex = int.Parse(data["Profile"]["wrongColor"]);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormMainGame fmg = new FormMainGame();
            if (comboBoxDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Vælg en sværhedsgrad");
            }
            else
            {
                fmg.Show();
            
            }
         
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBoxRightColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
            }
        }



        private void labelRightColorInfo_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = "Hvis du har tastet alle karaktererne korrekt \nvises denne farve.";
            labelInfo.Visible = true;
        }

        private void labelRightColorInfo_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
        }

        private void labelWrongColorInfo_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = "Hvis du har tastet forkert vises denne farve.";
            labelInfo.Visible = true;
        }

        private void labelWrongColorInfo_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
        }

        private void buttonOpenProfiles_Click(object sender, EventArgs e)
        {
            if (!profilesOpen)
            {
                labelRightColor.Visible = true;
                labelWrongColor.Visible = true;
                labelWrongColorInfo.Visible = true;
                labelRightColorInfo.Visible = true;
                labelProfile.Visible = true;
                labelJobModeInfo.Visible = true;
                labelRightColorIndex.Visible = true;
                labelWrongColorIndex.Visible = true;

                buttonSave.Visible = true;

                checkBoxJobMode.Visible = true;

                comboBoxProfiles.Visible = true;
                comboBoxRightColor.Visible = true;
                comboBoxWrongColor.Visible = true;

                profilesOpen = true;
                buttonOpenProfiles.Text = "<<";
                
                
                

            }
            else
            {
                labelRightColor.Visible = false;
                labelWrongColor.Visible = false;
                labelWrongColorInfo.Visible = false;
                labelRightColorInfo.Visible = false;
                labelProfile.Visible = false;
                labelJobModeInfo.Visible = false;
                labelRightColorIndex.Visible = false;
                labelWrongColorIndex.Visible = false;

                buttonSave.Visible = false;

                checkBoxJobMode.Visible = false;

                comboBoxProfiles.Visible = false;
                comboBoxRightColor.Visible = false;
                comboBoxWrongColor.Visible = false;
                profilesOpen = false;
                buttonOpenProfiles.Text = ">>";
            }
        }

        private void labelJobModeInfo_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = "Til nogle jobs bruger de en anden måde til at \nudrenge ord pr. minut. Hvis du vælger denne \nmulighed simulerer programmet samme måde \nsom standarten for jobs.";
            labelInfo.Visible = true;
        }

        private void labelJobModeInfo_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
        }

        private void comboBoxRightColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRightColorIndex.Text = "Indeks: " + comboBoxRightColor.SelectedIndex.ToString(); 
        }

        private void comboBoxWrongColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelWrongColorIndex.Text = "Indeks: " + comboBoxWrongColor.SelectedIndex.ToString();
        }

        private void comboBoxWrongColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
