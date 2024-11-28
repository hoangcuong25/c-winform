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
    public partial class MCQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public MCQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string question = rt_Question.Text.Trim();

                if (string.IsNullOrWhiteSpace(rt_Question.Text))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tb_CorrectAnswer.Text))
                {
                    MessageBox.Show("Correct Answer cannot be empty.");
                    return;
                }

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

                question_bank.Add(new MultipleChoiceQuestion(question, choices, correctAnswer));

                MessageBox.Show("A new question was added to question bank");

            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
