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

                string correctAnswer = tb_correctAnswer.Text;
                question_bank.Add(new MultipleChoiceQuestion(question, choices, correctAnswer));
            }
            
            MessageBox.Show("A new question was added to question bank");
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
            }
        }
    }
}
