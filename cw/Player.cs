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

        private void bt_Play_Click(object sender, EventArgs e)
        {
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
            }
            else if (question_bank[0] is TrueFalseQuestion tfq)
            {
                rt_Question.Text += "  True or False?\n";
            }
            else if (question_bank[0] is OpenEndedQuestion oeq)
            {
                rt_Question.Text += "  (Open-ended question, write your answer in Answer Box)\n";
            }
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            if (indexQuestion < question_bank.Count)
            {
                if (question_bank[indexQuestion] is MultipleChoiceQuestion mcq)
                {
                    if (rt_Answer.Text == mcq.CorrectAnswer)
                    {
                        grade++;
                    }
                }
                else if (question_bank[indexQuestion] is TrueFalseQuestion tfq)
                {
                    if (rt_Answer.Text == tfq.IsTrue)
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
                        rt_Question.Text += "  True or False?\n";
                    }
                    else if (question_bank[indexQuestion] is OpenEndedQuestion)
                    {
                        rt_Question.Text += "\n(Open-ended question, write your answer in Answer Box)\n";
                    }
                }
                else
                {
                   string yourGrade = $"Quiz Complete! Your Grade: {grade}/{question_bank.Count}";
                   MessageBox.Show(yourGrade);

                   indexQuestion = 0;
                   grade = 0;
                   rt_Question.Clear();
                }
                
            }
        }
    }
}

