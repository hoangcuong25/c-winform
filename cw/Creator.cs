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

                if (string.IsNullOrWhiteSpace(rt_Question.Text))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(rt_correctAnswer.Text))
                {
                    MessageBox.Show("Correct Answer cannot be empty.");
                    return;
                }

                if (questionType == "Multiple Choice")
                {
                    if (string.IsNullOrWhiteSpace(rt_Answer.Text))
                    {
                        MessageBox.Show("Answers cannot be empty.");
                        return;
                    }

                    string[] lines = rt_Answer.Lines;
                    if (lines.Length != 4)
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
                    isTrue = isTrue.Trim().ToLower();

                    if (isTrue == "true" || isTrue == "false")
                    {
                        question_bank.Add(new TrueFalseQuestion(question, isTrue));
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong");
                        return;
                    }

                } else
                {
                   MessageBox.Show("Something Wrong");
                    return;
                }

                MessageBox.Show("A new question was added to question bank");
            } catch
            {
                MessageBox.Show("Choose Type Of Question You Want To Add.");
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

                    string correctAnswer = tfq.IsTrue;
                    rt_Display.Text += $"  Correct Answer: {correctAnswer}\n\n";

                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(tb_index.Text) - 1;

                if (question_bank.Count == 0)
                {
                    MessageBox.Show("No questions available to delete.");
                    return;
                }

                if (index < 0 && index > question_bank.Count)
                {
                    MessageBox.Show("Invalid question number.");
                    return;
                }

                question_bank.RemoveAt(index);
                MessageBox.Show("Deleted successful");
            } catch 
            {
                MessageBox.Show("Something Wrong");
            }
            
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(tb_index.Text) - 1;

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

                if (index < 0  && index > question_bank.Count)
                {
                    MessageBox.Show("Invalid question number.");
                    return;
                }

                question_bank[index].QuestionText = rt_Question.Text;

                if (question_bank[index] is MultipleChoiceQuestion mcq)
                {
                    string[] lines = rt_Answer.Lines;

                    if (string.IsNullOrWhiteSpace(rt_Answer.Text))
                    {
                        MessageBox.Show("Answers cannot be empty.");
                        return;
                    }

                    if (lines.Length < 4)
                    {
                        MessageBox.Show("Please provide exactly 4 choices.");
                        return;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        mcq.Choices[i] = lines[i];
                    }

                    //if (!lines.Contains(rt_correctAnswer.Text))
                    //{
                    //    MessageBox.Show("The correct answer must match one of the provided choices.");
                    //    return;
                    //}

                    mcq.CorrectAnswer = rt_correctAnswer.Text;
                }
                else if (question_bank[index] is OpenEndedQuestion oeq)
                {
                    string[] correctAnswers = rt_correctAnswer.Lines;
                    if (correctAnswers.Length == 0)
                    {
                        MessageBox.Show("Please provide at least one valid correct answer.");
                        return;
                    }

                    oeq.CorrectAnswers = correctAnswers;
                }
                else if (question_bank[index] is TrueFalseQuestion tfq)
                {
                    string correctAnswer = rt_correctAnswer.Text.Trim().ToLower();
                    if (correctAnswer != "true" && correctAnswer != "false")
                    {
                        MessageBox.Show("Correct answer must be 'true' or 'false'.");
                        return;
                    }

                    tfq.IsTrue = correctAnswer;
                }

                MessageBox.Show("Question updated.");
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }
    }
}
