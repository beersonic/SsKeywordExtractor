namespace SsKeywordExtractor
{
    partial class Form1
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxKeyword = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegexKeyword = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxTitle = new System.Windows.Forms.RichTextBox();
            this.textBoxRegexTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(56, 6);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(411, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // richTextBoxKeyword
            // 
            this.richTextBoxKeyword.Location = new System.Drawing.Point(15, 262);
            this.richTextBoxKeyword.Name = "richTextBoxKeyword";
            this.richTextBoxKeyword.ReadOnly = true;
            this.richTextBoxKeyword.Size = new System.Drawing.Size(455, 122);
            this.richTextBoxKeyword.TabIndex = 2;
            this.richTextBoxKeyword.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regex keyword";
            // 
            // textBoxRegexKeyword
            // 
            this.textBoxRegexKeyword.Location = new System.Drawing.Point(96, 69);
            this.textBoxRegexKeyword.Name = "textBoxRegexKeyword";
            this.textBoxRegexKeyword.Size = new System.Drawing.Size(371, 20);
            this.textBoxRegexKeyword.TabIndex = 4;
            this.textBoxRegexKeyword.Text = "<a href=\\\"\\/search\\/.+class=\"pull-left.+btn-search-pill\\\">(.+)<\\/a>";
            this.textBoxRegexKeyword.TextChanged += new System.EventHandler(this.textBoxRegex_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(56, 134);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(411, 20);
            this.textBoxStatus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keywords";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Title";
            // 
            // richTextBoxTitle
            // 
            this.richTextBoxTitle.Location = new System.Drawing.Point(16, 187);
            this.richTextBoxTitle.Name = "richTextBoxTitle";
            this.richTextBoxTitle.ReadOnly = true;
            this.richTextBoxTitle.Size = new System.Drawing.Size(455, 42);
            this.richTextBoxTitle.TabIndex = 9;
            this.richTextBoxTitle.Text = "";
            // 
            // textBoxRegexTitle
            // 
            this.textBoxRegexTitle.Location = new System.Drawing.Point(96, 43);
            this.textBoxRegexTitle.Name = "textBoxRegexTitle";
            this.textBoxRegexTitle.Size = new System.Drawing.Size(371, 20);
            this.textBoxRegexTitle.TabIndex = 11;
            this.textBoxRegexTitle.Text = "<meta property.+og:title.+content=\"(.+)\".+>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Regex title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 407);
            this.Controls.Add(this.textBoxRegexTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxRegexKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxURL);
            this.Name = "Form1";
            this.Text = "SSKeywordExtractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegexKeyword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxTitle;
        private System.Windows.Forms.TextBox textBoxRegexTitle;
        private System.Windows.Forms.Label label6;
    }
}

