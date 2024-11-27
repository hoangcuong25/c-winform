using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace cw
{
    public abstract class Question
    {
        public string QuestionText { get; set; }

        public Question(string question)
        {
            QuestionText = question;
        }
    }
    public class MultipleChoiceQuestion : Question
    {
        public string[] Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(string question, string[] choices, string correctAnswer) : base(question)
        {
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }
    }
    public class OpenEndedQuestion : Question
    {
        public string[] CorrectAnswers { get; set; }

        public OpenEndedQuestion(string question, string[] correctAnswers) : base(question)
        {
            CorrectAnswers = correctAnswers;
        }
    }
    public class TrueFalseQuestion : Question
    {

        public string IsTrue { get; set; }

        public TrueFalseQuestion(string question, string isTrue) : base(question)
        {
            IsTrue = isTrue;
        }
    }
}
