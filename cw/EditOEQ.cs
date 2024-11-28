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
    public partial class EditOEQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public EditOEQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_Display_Click(object sender, EventArgs e)
        {
            rt_Display.Clear();
            for (int i = 0; i < question_bank.Count; i++)
            {
                if (question_bank[i] is OpenEndedQuestion oeq)
                {
                    rt_Display.Text += $"Question {i + 1}: {oeq.QuestionText}\n";
                    rt_Display.Text += $"  Possible Correct Answers:\n";

                    for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                    {
                        rt_Display.Text += $"    - {oeq.CorrectAnswers[j]}\n";
                    }

                    rt_Display.Text += "\n";
                }
            }
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

                if (question_bank[index] is OpenEndedQuestion oeq)
                {
                    string[] correctAnswers = rt_CorrectAnswer.Lines;
                    if (correctAnswers.Length == 0)
                    {
                        MessageBox.Show("Please provide at least one valid correct answer.");
                        return;
                    }

                    oeq.CorrectAnswers = correctAnswers;
                    oeq.QuestionText = rt_Question.Text;

                    MessageBox.Show("Open-Ended Question updated successfully!");
                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong!");
            }
        }
    }
}
