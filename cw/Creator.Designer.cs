namespace cw
{
    partial class Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rt_Question = new System.Windows.Forms.RichTextBox();
            this.rt_Answer = new System.Windows.Forms.RichTextBox();
            this.rt_Display = new System.Windows.Forms.RichTextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Display = new System.Windows.Forms.Button();
            this.tb_correctAnswer = new System.Windows.Forms.TextBox();
            this.tb_index = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_QuestionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(136, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(136, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer";
            // 
            // rt_Question
            // 
            this.rt_Question.Location = new System.Drawing.Point(130, 75);
            this.rt_Question.Name = "rt_Question";
            this.rt_Question.Size = new System.Drawing.Size(285, 96);
            this.rt_Question.TabIndex = 2;
            this.rt_Question.Text = "";
            // 
            // rt_Answer
            // 
            this.rt_Answer.Location = new System.Drawing.Point(130, 204);
            this.rt_Answer.Name = "rt_Answer";
            this.rt_Answer.Size = new System.Drawing.Size(285, 96);
            this.rt_Answer.TabIndex = 3;
            this.rt_Answer.Text = "";
            // 
            // rt_Display
            // 
            this.rt_Display.Location = new System.Drawing.Point(500, 75);
            this.rt_Display.Name = "rt_Display";
            this.rt_Display.Size = new System.Drawing.Size(238, 278);
            this.rt_Display.TabIndex = 4;
            this.rt_Display.Text = "";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Lime;
            this.bt_Add.Location = new System.Drawing.Point(130, 513);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 5;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Red;
            this.bt_Delete.Location = new System.Drawing.Point(130, 401);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 6;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = false;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Cyan;
            this.bt_Edit.Location = new System.Drawing.Point(241, 401);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(75, 23);
            this.bt_Edit.TabIndex = 7;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            // 
            // bt_Display
            // 
            this.bt_Display.BackColor = System.Drawing.Color.Gray;
            this.bt_Display.Location = new System.Drawing.Point(578, 401);
            this.bt_Display.Name = "bt_Display";
            this.bt_Display.Size = new System.Drawing.Size(75, 23);
            this.bt_Display.TabIndex = 8;
            this.bt_Display.Text = "Display";
            this.bt_Display.UseVisualStyleBackColor = false;
            this.bt_Display.Click += new System.EventHandler(this.bt_Display_Click);
            // 
            // tb_correctAnswer
            // 
            this.tb_correctAnswer.Location = new System.Drawing.Point(130, 479);
            this.tb_correctAnswer.Name = "tb_correctAnswer";
            this.tb_correctAnswer.Size = new System.Drawing.Size(157, 20);
            this.tb_correctAnswer.TabIndex = 9;
            // 
            // tb_index
            // 
            this.tb_index.Location = new System.Drawing.Point(132, 365);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(77, 20);
            this.tb_index.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(129, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Delete/Edit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(127, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Correct Answer";
            // 
            // cb_QuestionType
            // 
            this.cb_QuestionType.FormattingEnabled = true;
            this.cb_QuestionType.Items.AddRange(new object[] {
            "Multiple Choice",
            "True/False",
            "Open-Ended"});
            this.cb_QuestionType.Location = new System.Drawing.Point(338, 477);
            this.cb_QuestionType.Name = "cb_QuestionType";
            this.cb_QuestionType.Size = new System.Drawing.Size(121, 21);
            this.cb_QuestionType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(344, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type of Question";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_QuestionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.tb_correctAnswer);
            this.Controls.Add(this.bt_Display);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.rt_Display);
            this.Controls.Add(this.rt_Answer);
            this.Controls.Add(this.rt_Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Creator";
            this.Text = "Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rt_Question;
        private System.Windows.Forms.RichTextBox rt_Answer;
        private System.Windows.Forms.RichTextBox rt_Display;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Display;
        private System.Windows.Forms.TextBox tb_correctAnswer;
        private System.Windows.Forms.TextBox tb_index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_QuestionType;
        private System.Windows.Forms.Label label5;
    }
}