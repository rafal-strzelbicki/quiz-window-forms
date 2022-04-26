using Microsoft.VisualStudio.TestTools.UnitTesting;
using quiz;
using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Tests
{
    [TestClass()]
    public class QuizTests
    {
        [TestMethod()]
        public void CreateEmptyQuiz()
        {
            Quiz quiz = new Quiz();
            Assert.IsTrue(quiz.IsEmpty());
        }

        [TestMethod()]
        public void CreateEmptyQuizFromEmptyFileTest()
        {
            Quiz quiz = new Quiz("quizes/EmptyQuizFile.txt");
            Assert.IsTrue(quiz.IsEmpty());
        }

        [TestMethod()]
        public void CreateQuizWithTwoQuestionsFromFileTest()
        {
            Quiz quiz = new Quiz("quizes/QuizWithTwoQuestions.txt");
            Assert.IsFalse(quiz.IsEmpty());
        }

        [TestMethod()]
        public void CheckCorrectAnsersTest()
        {
            Quiz quiz = new Quiz("quizes/QuizWithTwoQuestions.txt");
            int questionOneId = 1;
            string[] questionOneCorrectAnswers = { "A" };
            int questionTwoId = 2;
            string[] questionTwoCorrectAnswers = { "C", "D" };
            Assert.IsTrue(quiz.checkAnswers(questionOneId, questionOneCorrectAnswers));
            Assert.IsTrue(quiz.checkAnswers(questionTwoId, questionTwoCorrectAnswers));
        }
    }
}