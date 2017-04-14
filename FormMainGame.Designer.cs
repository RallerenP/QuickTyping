﻿namespace QuickTyping
{
    partial class FormMainGame
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
            this.components = new System.ComponentModel.Container();
            this.challengeText = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTyping = new System.Windows.Forms.TextBox();
            this.labelFinish = new System.Windows.Forms.Label();
            this.ButtonStats = new System.Windows.Forms.Button();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // challengeText
            // 
            this.challengeText.BackColor = System.Drawing.SystemColors.Control;
            this.challengeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengeText.Location = new System.Drawing.Point(12, 12);
            this.challengeText.Name = "challengeText";
            this.challengeText.Size = new System.Drawing.Size(1230, 492);
            this.challengeText.TabIndex = 0;
            this.challengeText.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 772);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxTyping
            // 
            this.textBoxTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTyping.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxTyping.Location = new System.Drawing.Point(12, 520);
            this.textBoxTyping.Name = "textBoxTyping";
            this.textBoxTyping.Size = new System.Drawing.Size(1230, 68);
            this.textBoxTyping.TabIndex = 2;
            this.textBoxTyping.TextChanged += new System.EventHandler(this.textBoxTyping_TextChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(507, 259);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(175, 44);
            this.labelFinish.TabIndex = 3;
            this.labelFinish.Text = "Finished!";
            this.labelFinish.Visible = false;
            // 
            // ButtonStats
            // 
            this.ButtonStats.Location = new System.Drawing.Point(502, 338);
            this.ButtonStats.Name = "ButtonStats";
            this.ButtonStats.Size = new System.Drawing.Size(180, 62);
            this.ButtonStats.TabIndex = 4;
            this.ButtonStats.Text = "See Stats!";
            this.ButtonStats.UseVisualStyleBackColor = true;
            this.ButtonStats.Visible = false;
            this.ButtonStats.Click += new System.EventHandler(this.ButtonStats_Click);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(12, 612);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(66, 25);
            this.labelCountdown.TabIndex = 5;
            this.labelCountdown.Text = "00:00";
     
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.ButtonStats);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.textBoxTyping);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.challengeText);
            this.Name = "FormMainGame";
            this.Text = "FormMainGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox challengeText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTyping;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button ButtonStats;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label labelCountdown;
    }
}