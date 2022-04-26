using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Question
{
    public class Question
    {
        private int id;
        private string text;
        private List<Answer> answers = new List<Answer>();

        public Question(int id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public void addAnswer(Answer answer)
        {
            answers.Add(answer);
        }

        internal int getId()
        {
            return id;
        }

        public bool isAnswerCorrect(string answerId)
        {
            Answer answer = answers.Find(answer => answer.getId() == answerId);

            if (null == answer)
            {
                return false;
            }

            return answer.IsCorrect();      // return true or false
        }

        public void removeAnswer(string answerId)
        {
            answers.RemoveAll(answer => answer.getId() == answerId);
        }

        public void changeAnswer(Answer answer)
        {
            this.removeAnswer(answer.getId());
            this.addAnswer(answer);
        }
    }
}
