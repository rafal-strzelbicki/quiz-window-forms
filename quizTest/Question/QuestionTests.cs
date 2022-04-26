using Microsoft.VisualStudio.TestTools.UnitTesting;
using quiz.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Question.Tests
{
    [TestClass()]
    public class QuestionTests
    {
        [TestMethod()]
        public void CorrectAnswerTest()
        {
            Question question = new Question(1, "ryba");
            Answer correctAnswer = new Answer("A", "dupa", true);
            question.addAnswer(correctAnswer);
            Assert.IsTrue(question.isAnswerCorrect(correctAnswer.getId()));
        }

        [TestMethod()]
        public void IncorrectAnswerTest()
        {
            Question question = new Question(1, "ryba");
            Answer incorrectAnswer = new Answer("A", "dupa", false);
            question.addAnswer(incorrectAnswer);
            Assert.IsFalse(question.isAnswerCorrect(incorrectAnswer.getId()));
        }

        [TestMethod()]
        public void ItReturnsFalseWhenAnswerDoesNotExistTest()
        {
            Question question = new Question(1, "ryba");
            // we do not add any answer to the question
            Assert.IsFalse(question.isAnswerCorrect("A"));
        }

        [TestMethod()]
        public void RemoveAnswerTest()
        {
            Question question = new Question(1, "ryba");
            Answer correctAnswer = new Answer("A", "dupa", true);
            question.addAnswer(correctAnswer);
            question.removeAnswer("A");
            Assert.IsFalse(question.isAnswerCorrect(correctAnswer.getId()));
        }

        [TestMethod()]
        public void ChangeAnswerTest()
        {
            Question question = new Question(1, "ryba");
            string answerId = "A";
            Answer correctAnswer = new Answer(answerId, "dupa", true);
            Answer incorrectAnswer = new Answer(answerId, "dupa", false);
            question.addAnswer(correctAnswer);
            question.changeAnswer(incorrectAnswer);
            Assert.IsFalse(question.isAnswerCorrect(answerId));
        }
    }
}