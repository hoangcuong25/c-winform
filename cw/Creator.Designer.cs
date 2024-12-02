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
            this.rt_Display = new System.Windows.Forms.RichTextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.tb_index = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_QuestionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_Display
            // 
            this.rt_Display.Location = new System.Drawing.Point(36, 33);
            this.rt_Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_Display.Name = "rt_Display";
            this.rt_Display.Size = new System.Drawing.Size(393, 467);
            this.rt_Display.TabIndex = 4;
            this.rt_Display.Text = "";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Lime;
            this.bt_Add.Location = new System.Drawing.Point(693, 54);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(100, 28);
            this.bt_Add.TabIndex = 5;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Red;
            this.bt_Delete.Location = new System.Drawing.Point(503, 204);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(100, 28);
            this.bt_Delete.TabIndex = 6;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Cyan;
            this.bt_Edit.Location = new System.Drawing.Point(841, 54);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(100, 28);
            this.bt_Edit.TabIndex = 7;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // tb_index
            // 
            this.tb_index.Location = new System.Drawing.Point(503, 158);
            this.tb_index.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(101, 22);
            this.tb_index.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(521, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Delete";
            // 
            // cb_QuestionType
            // 
            this.cb_QuestionType.FormattingEnabled = true;
            this.cb_QuestionType.Items.AddRange(new object[] {
            "Multiple Choice",
            "True/False",
            "Open-Ended"});
            this.cb_QuestionType.Location = new System.Drawing.Point(503, 57);
            this.cb_QuestionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_QuestionType.Name = "cb_QuestionType";
            this.cb_QuestionType.Size = new System.Drawing.Size(160, 24);
            this.cb_QuestionType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(527, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type of Question";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Red;
            this.bt_Exit.Location = new System.Drawing.Point(693, 204);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(100, 28);
            this.bt_Exit.TabIndex = 16;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 689);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_QuestionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.rt_Display);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Creator";
            this.Text = "Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rt_Display;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.TextBox tb_index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_QuestionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Exit;
    }
}