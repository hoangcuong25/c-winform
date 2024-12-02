using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class EditMCQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public EditMCQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;

            display();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(tb_Index.Text) - 1;

                if (question_bank.Count == 0)
                {
                    MessageBox.Show("No questions available to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(rt_Question.Text))
                {
                    MessageBox.Show("Question text cannot be empty.");
                    return;
                }

                if (index < 0 && index > question_bank.Count)
                {
                    MessageBox.Show("Invalid question number.");
                    return;
                }

                if (question_bank[index] is MultipleChoiceQuestion mcq)
                {
                    string[] choices = new string[4];
                    choices[0] = rt_Choice1.Text.Trim();
                    choices[1] = rt_Choice2.Text.Trim();
                    choices[2] = rt_Choice3.Text.Trim();
                    choices[3] = rt_Choice4.Text.Trim();

                    if (choices.Any(string.IsNullOrWhiteSpace))
                    {
                        MessageBox.Show("All choices must be provided and cannot be empty.");
                        return;
                    }

                    int correctAnswer = Convert.ToInt32(tb_CorrectAnswer.Text) -1;

                    mcq.QuestionText = rt_Question.Text;
                    mcq.Choices = choices;
                    mcq.CorrectAnswer = correctAnswer;

                    MessageBox.Show("Multiple Choice Question updated successfully!");
                    display();

                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            } catch
            {
                MessageBox.Show("Something Wrong!");
            }
            
        }

        private void display()
        {
            rt_Display.Clear();
            for (int i = 0; i < question_bank.Count; i++)
            {

                if (question_bank[i] is MultipleChoiceQuestion mcq)
                {
                    rt_Display.Text += $"Question {i + 1}: {mcq.QuestionText}\n";

                    for (int j = 0; j < mcq.Choices.Length; j++)
                    {
                        rt_Display.Text += $"  Choice {j + 1}: {mcq.Choices[j]}\n";
                    }

                    rt_Display.Text += $"  Correct Choice: {mcq.CorrectAnswer + 1}\n\n";
                }
            }
        }
    }
}
