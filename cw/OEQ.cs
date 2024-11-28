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
    public partial class OEQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public OEQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            string[] correctAnswers = rt_CorrectAnswer.Lines;
            string question = rt_Question.Text.Trim();

            if (string.IsNullOrWhiteSpace(rt_Question.Text))
            {
                MessageBox.Show("Question cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(rt_CorrectAnswer.Text))
            {
                MessageBox.Show("Correct Answer cannot be empty.");
                return;
            }

            question_bank.Add(new OpenEndedQuestion(question, correctAnswers));
            MessageBox.Show("A new question was added to question bank");
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
