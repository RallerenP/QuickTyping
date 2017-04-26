namespace QuickTyping
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrecision = new System.Windows.Forms.Label();
            this.labelKeystrokes = new System.Windows.Forms.Label();
            this.displaySrt = new System.Windows.Forms.Label();
            this.labelFails = new System.Windows.Forms.Label();
            this.displayFail = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.displayTime = new System.Windows.Forms.Label();
            this.labelWPM = new System.Windows.Forms.Label();
            this.displayWPM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Præcision:";
            // 
            // labelPrecision
            // 
            this.labelPrecision.AutoSize = true;
            this.labelPrecision.Location = new System.Drawing.Point(200, 31);
            this.labelPrecision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecision.Name = "labelPrecision";
            this.labelPrecision.Size = new System.Drawing.Size(116, 25);
            this.labelPrecision.TabIndex = 1;
            this.labelPrecision.Text = "displayAcc";
            // 
            // labelKeystrokes
            // 
            this.labelKeystrokes.AutoSize = true;
            this.labelKeystrokes.Location = new System.Drawing.Point(32, 73);
            this.labelKeystrokes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeystrokes.Name = "labelKeystrokes";
            this.labelKeystrokes.Size = new System.Drawing.Size(120, 25);
            this.labelKeystrokes.TabIndex = 2;
            this.labelKeystrokes.Text = "Taste Tryk:";
            // 
            // displaySrt
            // 
            this.displaySrt.AutoSize = true;
            this.displaySrt.Location = new System.Drawing.Point(200, 73);
            this.displaySrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displaySrt.Name = "displaySrt";
            this.displaySrt.Size = new System.Drawing.Size(107, 25);
            this.displaySrt.TabIndex = 3;
            this.displaySrt.Text = "displayStr";
            // 
            // labelFails
            // 
            this.labelFails.AutoSize = true;
            this.labelFails.Location = new System.Drawing.Point(32, 115);
            this.labelFails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFails.Name = "labelFails";
            this.labelFails.Size = new System.Drawing.Size(53, 25);
            this.labelFails.TabIndex = 4;
            this.labelFails.Text = "Fejl:";
            // 
            // displayFail
            // 
            this.displayFail.AutoSize = true;
            this.displayFail.Location = new System.Drawing.Point(200, 115);
            this.displayFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFail.Name = "displayFail";
            this.displayFail.Size = new System.Drawing.Size(115, 25);
            this.displayFail.TabIndex = 5;
            this.displayFail.Text = "displayFail";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(34, 158);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(48, 25);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Tid:";
            // 
            // displayTime
            // 
            this.displayTime.AutoSize = true;
            this.displayTime.Location = new System.Drawing.Point(200, 158);
            this.displayTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(127, 25);
            this.displayTime.TabIndex = 7;
            this.displayTime.Text = "displayTime";
            // 
            // labelWPM
            // 
            this.labelWPM.AutoSize = true;
            this.labelWPM.Location = new System.Drawing.Point(36, 200);
            this.labelWPM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWPM.Name = "labelWPM";
            this.labelWPM.Size = new System.Drawing.Size(124, 25);
            this.labelWPM.TabIndex = 8;
            this.labelWPM.Text = "Ord pr. min:";
            // 
            // displayWPM
            // 
            this.displayWPM.AutoSize = true;
            this.displayWPM.Location = new System.Drawing.Point(200, 200);
            this.displayWPM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayWPM.Name = "displayWPM";
            this.displayWPM.Size = new System.Drawing.Size(132, 25);
            this.displayWPM.TabIndex = 9;
            this.displayWPM.Text = "displayWPM";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.displayWPM);
            this.Controls.Add(this.labelWPM);
            this.Controls.Add(this.displayTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.displayFail);
            this.Controls.Add(this.labelFails);
            this.Controls.Add(this.displaySrt);
            this.Controls.Add(this.labelKeystrokes);
            this.Controls.Add(this.labelPrecision);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrecision;
        private System.Windows.Forms.Label labelKeystrokes;
        private System.Windows.Forms.Label displaySrt;
        private System.Windows.Forms.Label labelFails;
        private System.Windows.Forms.Label displayFail;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label displayTime;
        private System.Windows.Forms.Label labelWPM;
        private System.Windows.Forms.Label displayWPM;
    }
}