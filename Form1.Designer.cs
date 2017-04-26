namespace QuickTyping
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.buttonOpenProfiles = new System.Windows.Forms.Button();
            this.comboBoxProfiles = new System.Windows.Forms.ComboBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.comboBoxRightColor = new System.Windows.Forms.ComboBox();
            this.labelRightColor = new System.Windows.Forms.Label();
            this.labelWrongColor = new System.Windows.Forms.Label();
            this.comboBoxWrongColor = new System.Windows.Forms.ComboBox();
            this.labelWrongColorInfo = new System.Windows.Forms.Label();
            this.labelRightColorInfo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxJobMode = new System.Windows.Forms.CheckBox();
            this.labelJobModeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRightColorIndex = new System.Windows.Forms.Label();
            this.labelWrongColorIndex = new System.Windows.Forms.Label();
            this.buttonNewProfile = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDefaultDiff = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(22, 21);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 67);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(24, 98);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(238, 33);
            this.comboBoxDifficulty.TabIndex = 1;
            // 
            // buttonOpenProfiles
            // 
            this.buttonOpenProfiles.Location = new System.Drawing.Point(390, 21);
            this.buttonOpenProfiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOpenProfiles.Name = "buttonOpenProfiles";
            this.buttonOpenProfiles.Size = new System.Drawing.Size(62, 44);
            this.buttonOpenProfiles.TabIndex = 2;
            this.buttonOpenProfiles.Text = ">>";
            this.buttonOpenProfiles.UseVisualStyleBackColor = true;
            this.buttonOpenProfiles.Click += new System.EventHandler(this.buttonOpenProfiles_Click);
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(490, 98);
            this.comboBoxProfiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.Size = new System.Drawing.Size(342, 33);
            this.comboBoxProfiles.TabIndex = 3;
            this.comboBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfiles_SelectedIndexChanged);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(490, 62);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(61, 25);
            this.labelProfile.TabIndex = 4;
            this.labelProfile.Text = "Profil";
            // 
            // comboBoxRightColor
            // 
            this.comboBoxRightColor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRightColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRightColor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRightColor.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRightColor.FormattingEnabled = true;
            this.comboBoxRightColor.Location = new System.Drawing.Point(490, 204);
            this.comboBoxRightColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxRightColor.Name = "comboBoxRightColor";
            this.comboBoxRightColor.Size = new System.Drawing.Size(342, 36);
            this.comboBoxRightColor.TabIndex = 5;
            this.comboBoxRightColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxRightColor_DrawItem);
            this.comboBoxRightColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxRightColor_SelectedIndexChanged);
            // 
            // labelRightColor
            // 
            this.labelRightColor.AutoSize = true;
            this.labelRightColor.Location = new System.Drawing.Point(490, 167);
            this.labelRightColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRightColor.Name = "labelRightColor";
            this.labelRightColor.Size = new System.Drawing.Size(142, 25);
            this.labelRightColor.TabIndex = 6;
            this.labelRightColor.Text = "Korrekt Farve";
            // 
            // labelWrongColor
            // 
            this.labelWrongColor.AutoSize = true;
            this.labelWrongColor.Location = new System.Drawing.Point(490, 281);
            this.labelWrongColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWrongColor.Name = "labelWrongColor";
            this.labelWrongColor.Size = new System.Drawing.Size(141, 25);
            this.labelWrongColor.TabIndex = 7;
            this.labelWrongColor.Text = "Forkert Farve";
            // 
            // comboBoxWrongColor
            // 
            this.comboBoxWrongColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxWrongColor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWrongColor.FormattingEnabled = true;
            this.comboBoxWrongColor.Location = new System.Drawing.Point(490, 312);
            this.comboBoxWrongColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxWrongColor.Name = "comboBoxWrongColor";
            this.comboBoxWrongColor.Size = new System.Drawing.Size(342, 36);
            this.comboBoxWrongColor.TabIndex = 8;
            this.comboBoxWrongColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxWrongColor_DrawItem);
            this.comboBoxWrongColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxWrongColor_SelectedIndexChanged);
            // 
            // labelWrongColorInfo
            // 
            this.labelWrongColorInfo.AutoSize = true;
            this.labelWrongColorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWrongColorInfo.Location = new System.Drawing.Point(848, 317);
            this.labelWrongColorInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWrongColorInfo.Name = "labelWrongColorInfo";
            this.labelWrongColorInfo.Size = new System.Drawing.Size(26, 27);
            this.labelWrongColorInfo.TabIndex = 9;
            this.labelWrongColorInfo.Text = "?";
            this.labelWrongColorInfo.MouseLeave += new System.EventHandler(this.labelWrongColorInfo_MouseLeave);
            this.labelWrongColorInfo.MouseHover += new System.EventHandler(this.labelWrongColorInfo_MouseHover);
            // 
            // labelRightColorInfo
            // 
            this.labelRightColorInfo.AutoSize = true;
            this.labelRightColorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRightColorInfo.Location = new System.Drawing.Point(848, 210);
            this.labelRightColorInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRightColorInfo.Name = "labelRightColorInfo";
            this.labelRightColorInfo.Size = new System.Drawing.Size(26, 27);
            this.labelRightColorInfo.TabIndex = 10;
            this.labelRightColorInfo.Text = "?";
            this.labelRightColorInfo.MouseLeave += new System.EventHandler(this.labelRightColorInfo_MouseLeave);
            this.labelRightColorInfo.MouseHover += new System.EventHandler(this.labelRightColorInfo_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(26, 152);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(93, 25);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "labelInfo";
            // 
            // checkBoxJobMode
            // 
            this.checkBoxJobMode.AutoSize = true;
            this.checkBoxJobMode.Location = new System.Drawing.Point(490, 388);
            this.checkBoxJobMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxJobMode.Name = "checkBoxJobMode";
            this.checkBoxJobMode.Size = new System.Drawing.Size(139, 29);
            this.checkBoxJobMode.TabIndex = 12;
            this.checkBoxJobMode.Text = "Job Mode";
            this.checkBoxJobMode.UseVisualStyleBackColor = true;
            // 
            // labelJobModeInfo
            // 
            this.labelJobModeInfo.AutoSize = true;
            this.labelJobModeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJobModeInfo.Location = new System.Drawing.Point(648, 390);
            this.labelJobModeInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelJobModeInfo.Name = "labelJobModeInfo";
            this.labelJobModeInfo.Size = new System.Drawing.Size(26, 27);
            this.labelJobModeInfo.TabIndex = 13;
            this.labelJobModeInfo.Text = "?";
            this.labelJobModeInfo.MouseLeave += new System.EventHandler(this.labelJobModeInfo_MouseLeave);
            this.labelJobModeInfo.MouseHover += new System.EventHandler(this.labelJobModeInfo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sværhedsgrad";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(490, 525);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(346, 44);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Gem Profil";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRightColorIndex
            // 
            this.labelRightColorIndex.AutoSize = true;
            this.labelRightColorIndex.Location = new System.Drawing.Point(734, 167);
            this.labelRightColorIndex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRightColorIndex.Name = "labelRightColorIndex";
            this.labelRightColorIndex.Size = new System.Drawing.Size(70, 25);
            this.labelRightColorIndex.TabIndex = 16;
            this.labelRightColorIndex.Text = "label2";
            // 
            // labelWrongColorIndex
            // 
            this.labelWrongColorIndex.AutoSize = true;
            this.labelWrongColorIndex.Location = new System.Drawing.Point(734, 281);
            this.labelWrongColorIndex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWrongColorIndex.Name = "labelWrongColorIndex";
            this.labelWrongColorIndex.Size = new System.Drawing.Size(70, 25);
            this.labelWrongColorIndex.TabIndex = 17;
            this.labelWrongColorIndex.Text = "label2";
            // 
            // buttonNewProfile
            // 
            this.buttonNewProfile.Location = new System.Drawing.Point(686, 42);
            this.buttonNewProfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNewProfile.Name = "buttonNewProfile";
            this.buttonNewProfile.Size = new System.Drawing.Size(150, 44);
            this.buttonNewProfile.TabIndex = 18;
            this.buttonNewProfile.Text = "Ny Profil";
            this.buttonNewProfile.UseVisualStyleBackColor = true;
            this.buttonNewProfile.Click += new System.EventHandler(this.buttonNewProfile_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(582, 46);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxName.MaxLength = 10;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 31);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.Text = "Skriv Brugernavn Her";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.Visible = false;
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // comboBoxDefaultDiff
            // 
            this.comboBoxDefaultDiff.FormattingEnabled = true;
            this.comboBoxDefaultDiff.Location = new System.Drawing.Point(490, 473);
            this.comboBoxDefaultDiff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDefaultDiff.Name = "comboBoxDefaultDiff";
            this.comboBoxDefaultDiff.Size = new System.Drawing.Size(342, 33);
            this.comboBoxDefaultDiff.TabIndex = 20;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(490, 442);
            this.labelDifficulty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(246, 25);
            this.labelDifficulty.TabIndex = 21;
            this.labelDifficulty.Text = "Standard Sværhedsgrad";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(910, 696);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.comboBoxDefaultDiff);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonNewProfile);
            this.Controls.Add(this.labelWrongColorIndex);
            this.Controls.Add(this.labelRightColorIndex);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJobModeInfo);
            this.Controls.Add(this.checkBoxJobMode);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelRightColorInfo);
            this.Controls.Add(this.labelWrongColorInfo);
            this.Controls.Add(this.comboBoxWrongColor);
            this.Controls.Add(this.labelWrongColor);
            this.Controls.Add(this.labelRightColor);
            this.Controls.Add(this.comboBoxRightColor);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.comboBoxProfiles);
            this.Controls.Add(this.buttonOpenProfiles);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 19);
            this.Text = "Hoved Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Button buttonOpenProfiles;
        private System.Windows.Forms.ComboBox comboBoxProfiles;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ComboBox comboBoxRightColor;
        private System.Windows.Forms.Label labelRightColor;
        private System.Windows.Forms.Label labelWrongColor;
        private System.Windows.Forms.ComboBox comboBoxWrongColor;
        private System.Windows.Forms.Label labelWrongColorInfo;
        private System.Windows.Forms.Label labelRightColorInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxJobMode;
        private System.Windows.Forms.Label labelJobModeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRightColorIndex;
        private System.Windows.Forms.Label labelWrongColorIndex;
        private System.Windows.Forms.Button buttonNewProfile;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxDefaultDiff;
        private System.Windows.Forms.Label labelDifficulty;
    }
}

