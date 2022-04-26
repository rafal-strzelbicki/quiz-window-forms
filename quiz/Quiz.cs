using System;
using System.Collections.Generic;
using System.Text;

namespace quiz
{
    public class Quiz
    {
        private List<Question.Question> questions = new List<Question.Question>();

        public Quiz()
        { }

        public Quiz(string quizFilePath)
        {
            string questionIdToken = "id ";
            string questionTextToken = "pytanie ";
            string questionText = null;
            int questionId = 0;
            Question.Question question = null;

            // TODO: decrypt file
            foreach (string line in System.IO.File.ReadLines(quizFilePath))
            {
                if (line.StartsWith(questionIdToken))
                {
                    questionId = Int32.Parse(line.Replace(questionIdToken, ""));
                }
                if (line.StartsWith(questionTextToken))
                {
                    questionText = line.Replace(questionTextToken, "");
                    question = new Question.Question(questionId, questionText);
                }

                if (null != question && line != "")
                {
                    question.addAnswer(new Question.Answer(line));
                }

                if (line == "")
                {
                    addQuestion(question);
                    question = null;
                }
            }
        }

        public void addQuestion(Question.Question question)
        {
            questions.Add(question);
        }

        public bool IsEmpty()
        {
            return questions.Count == 0;
        }

        public void removeQuestion(int questionId)
        {
            questions.RemoveAll(question => question.getId() == questionId);
        }

        public void changeQuestion(Question.Question question)
        {
            removeQuestion(question.getId());
            addQuestion(question);
        }

        public bool checkAnswers(int questionId, string[] answers)
        {
            Question.Question question = questions.Find(question => question.getId() == questionId);

            if (null == question)
            {
                return false;
            }

            foreach (string answerId in answers)
            {
                if (false == question.isAnswerCorrect(answerId))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
