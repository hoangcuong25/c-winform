namespace cw
{
    partial class EditTFQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTFQ));
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CorrectAnswer = new System.Windows.Forms.TextBox();
            this.rt_Question = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Index = new System.Windows.Forms.TextBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.rt_Display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Exit.Location = new System.Drawing.Point(427, 454);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(100, 28);
            this.bt_Exit.TabIndex = 11;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "True/False";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question";
            // 
            // tb_CorrectAnswer
            // 
            this.tb_CorrectAnswer.Location = new System.Drawing.Point(204, 274);
            this.tb_CorrectAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CorrectAnswer.Name = "tb_CorrectAnswer";
            this.tb_CorrectAnswer.Size = new System.Drawing.Size(156, 22);
            this.tb_CorrectAnswer.TabIndex = 7;
            // 
            // rt_Question
            // 
            this.rt_Question.Location = new System.Drawing.Point(204, 84);
            this.rt_Question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_Question.Name = "rt_Question";
            this.rt_Question.Size = new System.Drawing.Size(520, 126);
            this.rt_Question.TabIndex = 6;
            this.rt_Question.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Edit Question Number:";
            // 
            // tb_Index
            // 
            this.tb_Index.Location = new System.Drawing.Point(411, 274);
            this.tb_Index.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Index.Name = "tb_Index";
            this.tb_Index.Size = new System.Drawing.Size(164, 22);
            this.tb_Index.TabIndex = 41;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Edit.Location = new System.Drawing.Point(625, 271);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(100, 28);
            this.bt_Edit.TabIndex = 40;
            this.bt_Edit.Text = "EDIT";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // rt_Display
            // 
            this.rt_Display.Location = new System.Drawing.Point(784, 84);
            this.rt_Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_Display.Name = "rt_Display";
            this.rt_Display.Size = new System.Drawing.Size(408, 342);
            this.rt_Display.TabIndex = 43;
            this.rt_Display.Text = "";
            // 
            // EditTFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 551);
            this.Controls.Add(this.rt_Display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Index);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CorrectAnswer);
            this.Controls.Add(this.rt_Question);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTFQ";
            this.Text = "EditTFQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CorrectAnswer;
        private System.Windows.Forms.RichTextBox rt_Question;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Index;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.RichTextBox rt_Display;
    }
}