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
    public partial class EditTFQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public EditTFQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;

            display();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void display()
        {
            rt_Display.Clear();
            for (int i = 0; i < question_bank.Count; i++)
            {
                if (question_bank[i] is TrueFalseQuestion tfq)
                {
                    rt_Display.Text += $"Question {i + 1}: {tfq.QuestionText}\n";

                    string correctAnswer = tfq.IsTrue;
                    rt_Display.Text += $"  Correct Answer: {correctAnswer}\n\n";

                }
            }
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

                if (question_bank[index] is TrueFalseQuestion tfq)
                {
                    string correctAnswer = tb_CorrectAnswer.Text.Trim().ToLower();
                    if (correctAnswer != "true" && correctAnswer != "false")
                    {
                        MessageBox.Show("Correct answer must be 'true' or 'false'.");
                        return;
                    }

                    tfq.IsTrue = correctAnswer;
                    tfq.QuestionText = rt_Question.Text;

                    MessageBox.Show("True False Question updated successfully!");
                    display();
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong!");
            }
        }
    }
}
