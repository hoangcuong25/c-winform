namespace cw
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.rt_Answer = new System.Windows.Forms.RichTextBox();
            this.rt_Question = new System.Windows.Forms.RichTextBox();
            this.bt_Play = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_Answer
            // 
            this.rt_Answer.Location = new System.Drawing.Point(104, 105);
            this.rt_Answer.Name = "rt_Answer";
            this.rt_Answer.Size = new System.Drawing.Size(213, 96);
            this.rt_Answer.TabIndex = 0;
            this.rt_Answer.Text = "";
            // 
            // rt_Question
            // 
            this.rt_Question.Location = new System.Drawing.Point(386, 105);
            this.rt_Question.Name = "rt_Question";
            this.rt_Question.Size = new System.Drawing.Size(222, 96);
            this.rt_Question.TabIndex = 1;
            this.rt_Question.Text = "";
            // 
            // bt_Play
            // 
            this.bt_Play.BackColor = System.Drawing.Color.Lime;
            this.bt_Play.Location = new System.Drawing.Point(116, 260);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(75, 23);
            this.bt_Play.TabIndex = 2;
            this.bt_Play.Text = "Play Game";
            this.bt_Play.UseVisualStyleBackColor = false;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Next.Location = new System.Drawing.Point(218, 259);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(99, 23);
            this.bt_Next.TabIndex = 3;
            this.bt_Next.Text = "Next Question";
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question";
            // 
            // bt_Quit
            // 
            this.bt_Quit.BackColor = System.Drawing.Color.Aqua;
            this.bt_Quit.Location = new System.Drawing.Point(359, 259);
            this.bt_Quit.Name = "bt_Quit";
            this.bt_Quit.Size = new System.Drawing.Size(75, 23);
            this.bt_Quit.TabIndex = 7;
            this.bt_Quit.Text = "Quit Game";
            this.bt_Quit.UseVisualStyleBackColor = false;
            this.bt_Quit.Click += new System.EventHandler(this.bt_Quit_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Quit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.bt_Play);
            this.Controls.Add(this.rt_Question);
            this.Controls.Add(this.rt_Answer);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_Answer;
        private System.Windows.Forms.RichTextBox rt_Question;
        private System.Windows.Forms.Button bt_Play;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Quit;
    }
}