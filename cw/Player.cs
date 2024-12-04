using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class Player : Form
    {
        List<Question> question_bank = new List<Question>();
        public Player(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        int grade = 0;
        int indexQuestion = 0;
        Stopwatch stopwatch = new Stopwatch();
        private void bt_Play_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            if (question_bank.Count == 0)
            {
                Console.WriteLine("No questions available.");
                return;
            }

            rt_Question.Clear();
            rt_Question.Text = $"Question 1: {question_bank[0].QuestionText}\n";

            if (question_bank[0] is MultipleChoiceQuestion mcq)
            {
                for (int j = 0; j < mcq.Choices.Length; j++)
                {
                    rt_Question.Text += $"  Choice {j + 1}: {mcq.Choices[j]}\n";
                }
                rt_Question.Text += "Please Choose 1-4";
            }
            else if (question_bank[0] is TrueFalseQuestion tfq)
            {
                rt_Question.Text += "\nPlease choose True or False?\n";
            }
            else if (question_bank[0] is OpenEndedQuestion oeq)
            {
                rt_Question.Text += "\n(Open-ended question, write your answer in Answer Box)\n";
            }
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexQuestion < question_bank.Count)
                {
                    if (question_bank[indexQuestion] is MultipleChoiceQuestion mcq)
                    {
                        if(Convert.ToInt32(rt_Answer.Text) <0 || Convert.ToInt32(rt_Answer.Text) > 4)
                        {
                            MessageBox.Show("Please Choose 1-4");
                            return;
                        }
                        if (Convert.ToInt32(rt_Answer.Text) == mcq.CorrectAnswer + 1)
                        {
                            grade++;
                        }
                    }
                    else if (question_bank[indexQuestion] is TrueFalseQuestion tfq)
                    {
                        if (rt_Answer.Text.Trim().ToLower() == tfq.IsTrue)
                        {
                            grade++;
                        }
                    }
                    else if (question_bank[indexQuestion] is OpenEndedQuestion oeq)
                    {
                        for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                        {
                            if (rt_Answer.Text == oeq.CorrectAnswers[j])
                            {
                                grade++;
                                break;
                            }
                        }
                    }

                    rt_Answer.Clear();

                    indexQuestion++;

                    if (indexQuestion < question_bank.Count)
                    {
                        rt_Question.Text = question_bank[indexQuestion].QuestionText;

                        if (question_bank[indexQuestion] is MultipleChoiceQuestion MCQ)
                        {
                            for (int j = 0; j < MCQ.Choices.Length; j++)
                            {
                                rt_Question.Text += $"  Choice {j + 1}: {MCQ.Choices[j]}\n";
                            }
                        }
                        else if (question_bank[indexQuestion] is TrueFalseQuestion)
                        {
                            rt_Question.Text += "\nPlease enter true or false?\n";
                        }
                        else if (question_bank[indexQuestion] is OpenEndedQuestion)
                        {
                            rt_Question.Text += "\n(Open-ended question, write your answer in Answer Box)\n";
                        }
                    }
                    else
                    {
                        stopwatch.Stop();
                        string yourGrade = $"Quiz Complete! Your Grade: {grade}/{question_bank.Count}; Time spent: {stopwatch.Elapsed.TotalMinutes:F2} minutes.";
                        MessageBox.Show(yourGrade);

                        indexQuestion = 0;
                        grade = 0;
                        rt_Question.Clear();
                    }
                }
            } catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void bt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ShowQuestion_Click(object sender, EventArgs e)
        {
            if (question_bank.Count == 0)
            {
                MessageBox.Show("No questions available to show.");
                return;
            }

            rt_Question.Clear();

            for (int i = 0; i < question_bank.Count; i++)
            {
                rt_Question.Text += $"Question {i + 1}: {question_bank[i].QuestionText}\n";

                if (question_bank[i] is MultipleChoiceQuestion mcq)
                {
                    for (int j = 0; j < mcq.Choices.Length; j++)
                    {
                        rt_Question.Text += $"  Choice {j + 1}: {mcq.Choices[j]}\n";
                    }
                    rt_Question.Text += $"  Correct Choice: {mcq.CorrectAnswer + 1}\n\n";
                }
                else if (question_bank[i] is TrueFalseQuestion tfq)
                {
                    rt_Question.Text += $"  True or False?\n";
                    rt_Question.Text += $"  Correct Answer: {(tfq.IsTrue.ToLower() == "true" ? "True" : "False")}\n\n";
                }
                else if (question_bank[i] is OpenEndedQuestion oeq)
                {
                    rt_Question.Text += "(Open-ended question)\n";
                    rt_Question.Text += "  Possible Correct Answers:\n";

                    for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                    {
                        rt_Question.Text += $"    - {oeq.CorrectAnswers[j]}\n";
                    }
                    rt_Question.Text += "\n";
                }
            }
        }
    }
}

