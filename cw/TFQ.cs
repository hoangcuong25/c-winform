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
    public partial class TFQ : Form
    {
        List<Question> question_bank = new List<Question>();
        public TFQ(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_Add_Click(object sender, EventArgs e)
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

            string isTrue = tb_CorrectAnswer.Text;
            isTrue = isTrue.Trim().ToLower();

            if (isTrue == "true" || isTrue == "false")
            {
                question_bank.Add(new TrueFalseQuestion(question, isTrue));
                MessageBox.Show("A new question was added to question bank");
            }
            else
            {
                MessageBox.Show("Answer must be True or False");
                return;
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
