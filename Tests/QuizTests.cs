using System;
using Xunit;
using MadeInEugene.Models;


namespace Tests
{
    public class QuizTests
    {
        [Fact]
        public void RightAnswerTest()
        {
            //Arrange
            var quiz = new QuizModel()
            {
                UserAnswer1 = "by hand",
                UserAnswer2 = "neither",
                UserAnswer3 = "false",
                UserAnswer4 = "false",
                UserAnswer5 = "10",
                UserAnswer6 = "30",
                UserAnswer7 = "false",
                UserAnswer8 = "false",
                UserAnswer9 = "5",
                UserAnswer10 = "all"
        };
            //Act
            quiz.CheckAnswers();

            //Assert
            Assert.True(
                "Right" == quiz.CorrectOrNot1 &&
                "Right" == quiz.CorrectOrNot2 &&
                "Right" == quiz.CorrectOrNot3 &&
                "Right" == quiz.CorrectOrNot4 &&
                "Right" == quiz.CorrectOrNot5 &&
                "Right" == quiz.CorrectOrNot6 &&
                "Right" == quiz.CorrectOrNot7 &&
                "Right" == quiz.CorrectOrNot8 &&
                "Right" == quiz.CorrectOrNot9 &&
                "Right" == quiz.CorrectOrNot10
                );


        }

        // Test when the user gives all wrong answers
        [Fact]
        public void WrongAnswerTest()
        {
            // Arrange
            var quiz = new QuizModel()
            {
                UserAnswer1 = "not by hand",
                UserAnswer2 = "not neither",
                UserAnswer3 = "true",
                UserAnswer4 = "true",
                UserAnswer5 = "1",
                UserAnswer6 = "3",
                UserAnswer7 = "false",
                UserAnswer8 = "false",
                UserAnswer9 = "1",
                UserAnswer10 = "not all"
            };

            // Act
            quiz.CheckAnswers();

            //Assert
            Assert.False(
                "Right" == quiz.CorrectOrNot1 &&
                "Right" == quiz.CorrectOrNot2 &&
                "Right" == quiz.CorrectOrNot3 &&
                "Right" == quiz.CorrectOrNot4 &&
                "Right" == quiz.CorrectOrNot5 &&
                "Right" == quiz.CorrectOrNot6 &&
                "Right" == quiz.CorrectOrNot7 &&
                "Right" == quiz.CorrectOrNot8 &&
                "Right" == quiz.CorrectOrNot9 &&
                "Right" == quiz.CorrectOrNot10
                );
        }
        }
}