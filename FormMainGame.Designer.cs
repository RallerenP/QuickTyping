namespace QuickTyping
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
            this.challengeText = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTyping = new System.Windows.Forms.TextBox();
            this.labelWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // challengeText
            // 
            this.challengeText.BackColor = System.Drawing.SystemColors.Control;
            this.challengeText.Location = new System.Drawing.Point(6, 6);
            this.challengeText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.challengeText.Name = "challengeText";
            this.challengeText.Size = new System.Drawing.Size(617, 258);
            this.challengeText.TabIndex = 0;
            this.challengeText.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 401);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxTyping
            // 
            this.textBoxTyping.Location = new System.Drawing.Point(6, 301);
            this.textBoxTyping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTyping.Name = "textBoxTyping";
            this.textBoxTyping.Size = new System.Drawing.Size(617, 20);
            this.textBoxTyping.TabIndex = 2;
            this.textBoxTyping.TextChanged += new System.EventHandler(this.textBoxTyping_TextChanged);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Location = new System.Drawing.Point(281, 130);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(49, 13);
            this.labelWin.TabIndex = 3;
            this.labelWin.Text = "Finished!";
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 337);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.textBoxTyping);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.challengeText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainGame";
            this.Text = "FormMainGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox challengeText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTyping;
        private System.Windows.Forms.Label labelWin;
    }
}