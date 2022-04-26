using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Question
{
    public class Answer
    {
        private readonly string id;
        private readonly string text;
        private readonly bool isCorrect;

        public Answer(string answer)
        {
            if (answer.StartsWith("A ")
                || answer.StartsWith("B ")
                || answer.StartsWith("C ")
                || answer.StartsWith("D ")
            )
            {
                this.id = answer.Substring(0, 1);
                this.text = answer.Substring(2, answer.Length - 4);
                this.isCorrect = Convert.ToBoolean(Int32.Parse(answer.Substring(answer.Length - 1)));
            }
        }

        public Answer(string id, string text, bool isCorrect)
        {
            this.id = id;
            this.text = text;
            this.isCorrect = isCorrect;
        }

        public bool IsCorrect()
        {
            return isCorrect;
        }

        public string getId()
        {
            return id;
        }

        public string getText()
        {
            return text;
        }
    }
}
