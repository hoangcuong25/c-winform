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
            string question = rt_Question.Text;
            string answer = rt_Answer.Text;

            Question new_question = new Question(question, answer);
            question_bank.Add(new_question);
            MessageBox.Show("A new question was added to question bank");
        }
    }
}
