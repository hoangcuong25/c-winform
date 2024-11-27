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
    public partial class Creator : Form
    {
        public List<Question> question_bank = new List<Question>();
        public Creator()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string questionType = cb_QuestionType.Text;
                string question = rt_Question.Text;

                if (questionType == "Multiple Choice")
                {
                    string[] lines = rt_Answer.Lines;
                    if (lines.Length < 4)
                    {
                        MessageBox.Show("Please provide exactly 4 choices.");
                        return;
                    }

                    string[] choices = new string[4];

                    for (int i = 0; i < 4; i++)
                    {
                        choices[i] = lines[i];
                    }

                    string correctAnswer = rt_correctAnswer.Text;
                    question_bank.Add(new MultipleChoiceQuestion(question, choices, correctAnswer));
                }
                else if (questionType == "Open-Ended")
                {
                    string[] correctAnswers = rt_correctAnswer.Lines;

                    question_bank.Add(new OpenEndedQuestion(question, correctAnswers));
                }
                else if (questionType == "True/False")
                {
                    string isTrue = rt_correctAnswer.Text;
                    question_bank.Add(new TrueFalseQuestion(question, isTrue));
                } else
                {
                   MessageBox.Show("Something Wrong");
                    return;
                }

                MessageBox.Show("A new question was added to question bank");
            } catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void bt_Display_Click(object sender, EventArgs e)
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

                    rt_Display.Text += $"  Correct Answer: {mcq.CorrectAnswer}\n\n";
                }
                else if (question_bank[i] is OpenEndedQuestion oeq)
                {
                    rt_Display.Text += $"Question {i + 1}: {oeq.QuestionText}\n";
                    rt_Display.Text += $"  Possible Correct Answers:\n";

                    for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                    {
                        rt_Display.Text += $"    - {oeq.CorrectAnswers[j]}\n";
                    }

                    rt_Display.Text += "\n";
                }
                else if (question_bank[i] is TrueFalseQuestion tfq)
                {
                    rt_Display.Text += $"Question {i + 1}: {tfq.QuestionText}\n";

                    string correctAnswer = tfq.IsTrue.Trim().ToLower();
                    if (correctAnswer == "true" || correctAnswer == "false")
                    {
                        rt_Display.Text += $"  Correct Answer: {correctAnswer.Substring(0, 1).ToUpper() + correctAnswer.Substring(1)}\n\n";
                    }
                    else
                    {
                        rt_Display.Text += "  Correct Answer: [Invalid or Undefined]\n\n";
                    }
                }
            }
        }
    }
}
