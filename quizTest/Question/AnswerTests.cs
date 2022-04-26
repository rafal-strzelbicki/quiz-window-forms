using Microsoft.VisualStudio.TestTools.UnitTesting;
using quiz.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace quiz.Question.Tests
{
    [TestClass()]
    public class AnswerTests
    {
        [TestMethod()]
        public void CorrectAnswerTest()
        {
            // tworzymy obiekt klasy Answer
            Answer correctAnswer = new Answer("A", "dupa", true);
            // robimy asercje czy metoda IsCorrect zwraca oczekiwany wynik
            Assert.IsTrue(correctAnswer.IsCorrect());
        }
        
        [TestMethod()]
        public void IncorrectAnswerTest()
        {
            Answer incorrectAnswer = new Answer("B", "cycki", false);
            // robimy asercje czy metoda IsCorrect zwraca oczekiwany wynik
            Assert.IsFalse(incorrectAnswer.IsCorrect());
        }

        [TestMethod()]
        public void CreateAnswerFromStringTest()
        {
            Answer correctAnswer = new Answer("A Answer A Text 1");
            Answer incorrectAnswer = new Answer("B Answer B Text 0");
            Assert.AreEqual("A", correctAnswer.getId());
            Assert.AreEqual("B", incorrectAnswer.getId());
            Assert.AreEqual("Answer A Text", correctAnswer.getText());
            Assert.AreEqual("Answer B Text", incorrectAnswer.getText());
            Assert.IsTrue(correctAnswer.IsCorrect());
            Assert.IsFalse(incorrectAnswer.IsCorrect());
        }
    }
}