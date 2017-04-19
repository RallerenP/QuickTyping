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
using System.IO;

namespace QuickTyping
{
    public partial class FormMain : Form
    {

        int selectedIndex = 0;
        bool profilesOpen = false;
        

        public FormMain()
        {
            InitializeComponent();
            comboBoxDifficulty.Items.Add("Demo");
            comboBoxDifficulty.Items.Add("Nem");
            comboBoxDifficulty.Items.Add("Middel");
            comboBoxDifficulty.Items.Add("Svær");

            comboBoxDefaultDiff.Items.Add("Demo");
            comboBoxDefaultDiff.Items.Add("Nem");
            comboBoxDefaultDiff.Items.Add("Middel");
            comboBoxDefaultDiff.Items.Add("Svær");


            //Jeg bruger ini parser af rickyah
            var parser = new FileIniDataParser();
            IniData demoData = parser.ReadFile(@"Profiles\Demo.ini");
            IniData profileData = parser.ReadFile(@"Profiles\Profiles.ini");

            for (int i = 0; i < int.Parse(profileData["Profiles"]["amountOfProfiles"]); i++)
            {
                comboBoxProfiles.Items.Add(profileData["Profiles"]["index" + i]);
            }
           
         


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
            labelDifficulty.Visible = false;
            buttonNewProfile.Visible = false;
            comboBoxDefaultDiff.Visible = false;
         

            comboBoxProfiles.Visible = false;
            comboBoxRightColor.Visible = false;
            comboBoxWrongColor.Visible = false;
            checkBoxJobMode.Visible = false;

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
            comboBoxProfiles.SelectedIndex = 0;

            comboBoxRightColor.SelectedIndex = int.Parse(demoData["Profile"]["rightColorIndex"]);
            comboBoxWrongColor.SelectedIndex = int.Parse(demoData["Profile"]["wrongColorIndex"]);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            


          
            if (comboBoxDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Vælg en sværhedsgrad");
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(@"Profiles\Demo.ini");

                data["Profile"]["rightColorIndex"] = comboBoxRightColor.SelectedIndex.ToString();
                data["Profile"]["wrongColorIndex"] = comboBoxWrongColor.SelectedIndex.ToString();

                data["Profile"]["rightColor"] = comboBoxRightColor.Text;
                data["Profile"]["wrongColorIndex"] = comboBoxWrongColor.Text;

                data["Profile"]["jobMode"] = checkBoxJobMode.ToString();
                data["Profile"]["defaultDiff"] = comboBoxDifficulty.SelectedIndex.ToString();

                parser.WriteFile(@"Profiles\tempProfile.ini", data);

                FormMainGame fmg = new FormMainGame();
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
                labelDifficulty.Visible = true;
                buttonNewProfile.Visible = true;
                comboBoxDefaultDiff.Visible = true;

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
                labelDifficulty.Visible = false;
                buttonNewProfile.Visible = false;
                comboBoxDefaultDiff.Visible = false;
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
            var parser = new FileIniDataParser();
            string pathToProfile = "Profiles\\" + comboBoxProfiles.Text + ".ini";
            IniData data = parser.ReadFile(pathToProfile);

            data["Profile"]["rightColorIndex"] = comboBoxRightColor.SelectedIndex.ToString();
            data["Profile"]["wrongColorIndex"] = comboBoxWrongColor.SelectedIndex.ToString();

            data["Profile"]["rightColor"] = comboBoxRightColor.Text;
            data["Profile"]["wrongColorIndex"] = comboBoxWrongColor.Text;

            data["Profile"]["jobMode"] = checkBoxJobMode.ToString();
            data["Profile"]["defaultDiff"] = comboBoxDefaultDiff.SelectedIndex.ToString();
            parser.WriteFile(pathToProfile, data);


        }

        private void comboBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxProfiles.SelectedIndex;
            var parser = new FileIniDataParser();
            string pathToProfile = "profiles\\" + comboBoxProfiles.Text + ".ini";
            IniData data = parser.ReadFile(pathToProfile);

            IniData profileData = parser.ReadFile(@"Profiles\Profiles.ini");
            profileData["Profiles"]["activeProfile"] = comboBoxProfiles.Text;
            comboBoxRightColor.SelectedIndex = int.Parse(data["Profile"]["rightColorIndex"]);
            comboBoxWrongColor.SelectedIndex = int.Parse(data["Profile"]["wrongColorIndex"]);


        }

        private void buttonNewProfile_Click(object sender, EventArgs e)
        {
            textBoxName.Visible = true;
            textBoxName.SelectAll();
        
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var parser = new FileIniDataParser();

                string pathToNewProfile = "Profiles\\" + textBoxName.Text + ".ini";
                IniData data = parser.ReadFile(@"Profiles\Demo.ini");
                data["Profile"]["name"] = textBoxName.Text;
                
                parser.WriteFile(pathToNewProfile, data);

                IniData profileData = parser.ReadFile(@"Profiles\Profiles.ini");
                profileData["Profiles"].AddKey("index" + int.Parse(profileData["Profiles"]["amountOfProfiles"]),textBoxName.Text);
                profileData["Profiles"]["amountOfProfiles"] = (int.Parse(profileData["Profiles"]["amountOfProfiles"]) + 1).ToString();

                parser.WriteFile(@"Profiles\Profiles.ini", profileData);

                textBoxName.Visible = false;
                comboBoxProfiles.Items.Add(textBoxName.Text);
                textBoxName.Text = "Skriv Brugernavn Her";
               
            }
        }
    }
}
