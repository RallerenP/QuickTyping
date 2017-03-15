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
            this.SuspendLayout();
            // 
            // challengeText
            // 
            this.challengeText.BackColor = System.Drawing.SystemColors.Control;
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
            this.textBoxTyping.Location = new System.Drawing.Point(12, 578);
            this.textBoxTyping.Name = "textBoxTyping";
            this.textBoxTyping.Size = new System.Drawing.Size(1230, 31);
            this.textBoxTyping.TabIndex = 2;
            this.textBoxTyping.TextChanged += new System.EventHandler(this.textBoxTyping_TextChanged);
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
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
    }
}