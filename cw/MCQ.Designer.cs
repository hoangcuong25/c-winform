namespace cw
{
    partial class MCQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCQ));
            this.rt_Question = new System.Windows.Forms.RichTextBox();
            this.rt_Choice1 = new System.Windows.Forms.RichTextBox();
            this.rt_Choice2 = new System.Windows.Forms.RichTextBox();
            this.rt_Choice3 = new System.Windows.Forms.RichTextBox();
            this.rt_Choice4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_CorrectAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_Question
            // 
            this.rt_Question.Location = new System.Drawing.Point(118, 37);
            this.rt_Question.Name = "rt_Question";
            this.rt_Question.Size = new System.Drawing.Size(321, 96);
            this.rt_Question.TabIndex = 0;
            this.rt_Question.Text = "";
            // 
            // rt_Choice1
            // 
            this.rt_Choice1.Location = new System.Drawing.Point(118, 191);
            this.rt_Choice1.Name = "rt_Choice1";
            this.rt_Choice1.Size = new System.Drawing.Size(127, 46);
            this.rt_Choice1.TabIndex = 1;
            this.rt_Choice1.Text = "";
            // 
            // rt_Choice2
            // 
            this.rt_Choice2.Location = new System.Drawing.Point(312, 191);
            this.rt_Choice2.Name = "rt_Choice2";
            this.rt_Choice2.Size = new System.Drawing.Size(127, 46);
            this.rt_Choice2.TabIndex = 2;
            this.rt_Choice2.Text = "";
            // 
            // rt_Choice3
            // 
            this.rt_Choice3.Location = new System.Drawing.Point(118, 270);
            this.rt_Choice3.Name = "rt_Choice3";
            this.rt_Choice3.Size = new System.Drawing.Size(127, 46);
            this.rt_Choice3.TabIndex = 3;
            this.rt_Choice3.Text = "";
            // 
            // rt_Choice4
            // 
            this.rt_Choice4.Location = new System.Drawing.Point(312, 270);
            this.rt_Choice4.Name = "rt_Choice4";
            this.rt_Choice4.Size = new System.Drawing.Size(127, 46);
            this.rt_Choice4.TabIndex = 4;
            this.rt_Choice4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choice 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choice 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choice 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choice 4";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Add.Location = new System.Drawing.Point(118, 396);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 10;
            this.bt_Add.Text = "ADD";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tb_CorrectAnswer
            // 
            this.tb_CorrectAnswer.Location = new System.Drawing.Point(118, 360);
            this.tb_CorrectAnswer.Name = "tb_CorrectAnswer";
            this.tb_CorrectAnswer.Size = new System.Drawing.Size(124, 20);
            this.tb_CorrectAnswer.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correct Choice (1-4)";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Exit.Location = new System.Drawing.Point(312, 357);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(77, 23);
            this.bt_Exit.TabIndex = 13;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // MCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_CorrectAnswer);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_Choice4);
            this.Controls.Add(this.rt_Choice3);
            this.Controls.Add(this.rt_Choice2);
            this.Controls.Add(this.rt_Choice1);
            this.Controls.Add(this.rt_Question);
            this.Name = "MCQ";
            this.Text = "MCQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_Question;
        private System.Windows.Forms.RichTextBox rt_Choice1;
        private System.Windows.Forms.RichTextBox rt_Choice2;
        private System.Windows.Forms.RichTextBox rt_Choice3;
        private System.Windows.Forms.RichTextBox rt_Choice4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_CorrectAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_Exit;
    }
}