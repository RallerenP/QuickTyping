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
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(11, 11);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(54, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(12, 51);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDifficulty.TabIndex = 1;
            // 
            // buttonOpenProfiles
            // 
            this.buttonOpenProfiles.Location = new System.Drawing.Point(195, 11);
            this.buttonOpenProfiles.Name = "buttonOpenProfiles";
            this.buttonOpenProfiles.Size = new System.Drawing.Size(31, 23);
            this.buttonOpenProfiles.TabIndex = 2;
            this.buttonOpenProfiles.Text = ">>";
            this.buttonOpenProfiles.UseVisualStyleBackColor = true;
            this.buttonOpenProfiles.Click += new System.EventHandler(this.buttonOpenProfiles_Click);
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(245, 51);
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.Size = new System.Drawing.Size(173, 21);
            this.comboBoxProfiles.TabIndex = 3;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(245, 32);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(30, 13);
            this.labelProfile.TabIndex = 4;
            this.labelProfile.Text = "Profil";
            // 
            // comboBoxRightColor
            // 
            this.comboBoxRightColor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRightColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRightColor.FormattingEnabled = true;
            this.comboBoxRightColor.Location = new System.Drawing.Point(245, 106);
            this.comboBoxRightColor.Name = "comboBoxRightColor";
            this.comboBoxRightColor.Size = new System.Drawing.Size(173, 21);
            this.comboBoxRightColor.TabIndex = 5;
            this.comboBoxRightColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxRightColor_DrawItem);
            this.comboBoxRightColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxRightColor_SelectedIndexChanged);
            // 
            // labelRightColor
            // 
            this.labelRightColor.AutoSize = true;
            this.labelRightColor.Location = new System.Drawing.Point(245, 87);
            this.labelRightColor.Name = "labelRightColor";
            this.labelRightColor.Size = new System.Drawing.Size(71, 13);
            this.labelRightColor.TabIndex = 6;
            this.labelRightColor.Text = "Korrekt Farve";
            // 
            // labelWrongColor
            // 
            this.labelWrongColor.AutoSize = true;
            this.labelWrongColor.Location = new System.Drawing.Point(245, 146);
            this.labelWrongColor.Name = "labelWrongColor";
            this.labelWrongColor.Size = new System.Drawing.Size(70, 13);
            this.labelWrongColor.TabIndex = 7;
            this.labelWrongColor.Text = "Forkert Farve";
            // 
            // comboBoxWrongColor
            // 
            this.comboBoxWrongColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxWrongColor.FormattingEnabled = true;
            this.comboBoxWrongColor.Location = new System.Drawing.Point(245, 162);
            this.comboBoxWrongColor.Name = "comboBoxWrongColor";
            this.comboBoxWrongColor.Size = new System.Drawing.Size(173, 21);
            this.comboBoxWrongColor.TabIndex = 8;
            this.comboBoxWrongColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxWrongColor_DrawItem);
            this.comboBoxWrongColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxWrongColor_SelectedIndexChanged);
            // 
            // labelWrongColorInfo
            // 
            this.labelWrongColorInfo.AutoSize = true;
            this.labelWrongColorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWrongColorInfo.Location = new System.Drawing.Point(424, 165);
            this.labelWrongColorInfo.Name = "labelWrongColorInfo";
            this.labelWrongColorInfo.Size = new System.Drawing.Size(15, 15);
            this.labelWrongColorInfo.TabIndex = 9;
            this.labelWrongColorInfo.Text = "?";
            this.labelWrongColorInfo.MouseLeave += new System.EventHandler(this.labelWrongColorInfo_MouseLeave);
            this.labelWrongColorInfo.MouseHover += new System.EventHandler(this.labelWrongColorInfo_MouseHover);
            // 
            // labelRightColorInfo
            // 
            this.labelRightColorInfo.AutoSize = true;
            this.labelRightColorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRightColorInfo.Location = new System.Drawing.Point(424, 109);
            this.labelRightColorInfo.Name = "labelRightColorInfo";
            this.labelRightColorInfo.Size = new System.Drawing.Size(15, 15);
            this.labelRightColorInfo.TabIndex = 10;
            this.labelRightColorInfo.Text = "?";
            this.labelRightColorInfo.MouseLeave += new System.EventHandler(this.labelRightColorInfo_MouseLeave);
            this.labelRightColorInfo.MouseHover += new System.EventHandler(this.labelRightColorInfo_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 79);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(47, 13);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "labelInfo";
            // 
            // checkBoxJobMode
            // 
            this.checkBoxJobMode.AutoSize = true;
            this.checkBoxJobMode.Location = new System.Drawing.Point(245, 202);
            this.checkBoxJobMode.Name = "checkBoxJobMode";
            this.checkBoxJobMode.Size = new System.Drawing.Size(73, 17);
            this.checkBoxJobMode.TabIndex = 12;
            this.checkBoxJobMode.Text = "Job Mode";
            this.checkBoxJobMode.UseVisualStyleBackColor = true;
            // 
            // labelJobModeInfo
            // 
            this.labelJobModeInfo.AutoSize = true;
            this.labelJobModeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJobModeInfo.Location = new System.Drawing.Point(324, 203);
            this.labelJobModeInfo.Name = "labelJobModeInfo";
            this.labelJobModeInfo.Size = new System.Drawing.Size(15, 15);
            this.labelJobModeInfo.TabIndex = 13;
            this.labelJobModeInfo.Text = "?";
            this.labelJobModeInfo.MouseLeave += new System.EventHandler(this.labelJobModeInfo_MouseLeave);
            this.labelJobModeInfo.MouseHover += new System.EventHandler(this.labelJobModeInfo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sværhedsgrad";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(245, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(173, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Gem Profil";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRightColorIndex
            // 
            this.labelRightColorIndex.AutoSize = true;
            this.labelRightColorIndex.Location = new System.Drawing.Point(367, 87);
            this.labelRightColorIndex.Name = "labelRightColorIndex";
            this.labelRightColorIndex.Size = new System.Drawing.Size(35, 13);
            this.labelRightColorIndex.TabIndex = 16;
            this.labelRightColorIndex.Text = "label2";
            // 
            // labelWrongColorIndex
            // 
            this.labelWrongColorIndex.AutoSize = true;
            this.labelWrongColorIndex.Location = new System.Drawing.Point(367, 146);
            this.labelWrongColorIndex.Name = "labelWrongColorIndex";
            this.labelWrongColorIndex.Size = new System.Drawing.Size(35, 13);
            this.labelWrongColorIndex.TabIndex = 17;
            this.labelWrongColorIndex.Text = "label2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(455, 362);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
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
    }
}

