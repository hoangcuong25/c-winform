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

            if (questionType == "Multiple Choice")
            {
                MCQ form_MCQ = new MCQ(question_bank);
                form_MCQ.ShowDialog();
                display();
            }
            else if (questionType == "Open-Ended")
            {
                OEQ form_OEQ = new OEQ(question_bank);
                form_OEQ.ShowDialog();
                display();
            }
            else if (questionType == "True/False")
            {
                TFQ form_TFQ = new TFQ(question_bank);
                form_TFQ.ShowDialog();
                display();
            } else
            {
                MessageBox.Show("Chose Type Of Question You Want To Add");
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
                display();
            } catch 
            {
                MessageBox.Show("Something Wrong");
            }
            
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            string questionType = cb_QuestionType.Text;

            if (questionType == "Multiple Choice")
            {
                EditMCQ form_EditMCQ = new EditMCQ(question_bank);
                form_EditMCQ.ShowDialog();
                display();
            }
            else if (questionType == "Open-Ended")
            {
                EditOEQ form_EditOEQ = new EditOEQ(question_bank);
                form_EditOEQ.ShowDialog();
                display();
            }
            else if (questionType == "True/False")
            {
                EditTFQ form_EditTFQ = new EditTFQ(question_bank);
                form_EditTFQ.ShowDialog();
                display();
            }
            else
            {
                MessageBox.Show("Chose Type Of Question You Want To Edit");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /
    }
}
