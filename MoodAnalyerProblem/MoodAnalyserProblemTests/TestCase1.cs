using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyerProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyerProblem.Tests
{
    [TestClass()]
    public class TestCase1
    {
        [TestMethod()]
        public void GivenHappyMoodMassage_ShouldRetuenHappy()
        {
            // Arrange
            Mood mood = new Mood();
            string ExpectedMood = "Happy";

            //Act
            string ActualMood = mood.MoodAnalyser("Happy");

            //Asert
            Assert.AreEqual(ExpectedMood, ActualMood);
        }
        public void GivenHappyMoodMassage_ShouldRetuenSad()
        {
            // Arrange
            Mood mood = new Mood();
            string ExpectedMood = "Sad";

            //Act
            string ActualMood = mood.MoodAnalyser("Sad");

            //Asert
            Assert.AreEqual(ExpectedMood, ActualMood);

        }
    }
}