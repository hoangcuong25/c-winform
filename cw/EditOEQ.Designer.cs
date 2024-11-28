namespace cw
{
    partial class EditOEQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOEQ));
            this.bt_Display = new System.Windows.Forms.Button();
            this.rt_Display = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rt_Question = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Index = new System.Windows.Forms.TextBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rt_CorrectAnswer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_Display
            // 
            this.bt_Display.BackColor = System.Drawing.Color.Gray;
            this.bt_Display.Location = new System.Drawing.Point(559, 358);
            this.bt_Display.Name = "bt_Display";
            this.bt_Display.Size = new System.Drawing.Size(136, 23);
            this.bt_Display.TabIndex = 31;
            this.bt_Display.Text = "Display All Question";
            this.bt_Display.UseVisualStyleBackColor = false;
            this.bt_Display.Click += new System.EventHandler(this.bt_Display_Click);
            // 
            // rt_Display
            // 
            this.rt_Display.Location = new System.Drawing.Point(471, 38);
            this.rt_Display.Name = "rt_Display";
            this.rt_Display.Size = new System.Drawing.Size(307, 279);
            this.rt_Display.TabIndex = 30;
            this.rt_Display.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Question";
            // 
            // rt_Question
            // 
            this.rt_Question.Location = new System.Drawing.Point(67, 38);
            this.rt_Question.Name = "rt_Question";
            this.rt_Question.Size = new System.Drawing.Size(321, 96);
            this.rt_Question.TabIndex = 32;
            this.rt_Question.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Edit Question Number:";
            // 
            // tb_Index
            // 
            this.tb_Index.Location = new System.Drawing.Point(67, 315);
            this.tb_Index.Name = "tb_Index";
            this.tb_Index.Size = new System.Drawing.Size(124, 20);
            this.tb_Index.TabIndex = 38;
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Exit.Location = new System.Drawing.Point(247, 384);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(77, 23);
            this.bt_Exit.TabIndex = 37;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Edit.Location = new System.Drawing.Point(249, 313);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(75, 23);
            this.bt_Edit.TabIndex = 34;
            this.bt_Edit.Text = "EDIT";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Correct Question";
            // 
            // rt_CorrectAnswer
            // 
            this.rt_CorrectAnswer.Location = new System.Drawing.Point(67, 191);
            this.rt_CorrectAnswer.Name = "rt_CorrectAnswer";
            this.rt_CorrectAnswer.Size = new System.Drawing.Size(321, 69);
            this.rt_CorrectAnswer.TabIndex = 40;
            this.rt_CorrectAnswer.Text = "";
            // 
            // EditOEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rt_CorrectAnswer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Index);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_Question);
            this.Controls.Add(this.bt_Display);
            this.Controls.Add(this.rt_Display);
            this.Name = "EditOEQ";
            this.Text = "EditOEQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Display;
        private System.Windows.Forms.RichTextBox rt_Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rt_Question;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Index;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rt_CorrectAnswer;
    }
}