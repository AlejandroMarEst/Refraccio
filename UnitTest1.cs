using System;
using Xunit;
using ExerciseFive;

namespace ExerciseFive.Tests
{
    public class PersonaHelperTests
    {
        private readonly PersonaHelper _helper;
        public PersonaHelperTests()
        {
            _helper = new PersonaHelper();
        }
        [Theory]
        [InlineData(10, 0)] // Inf�ncia
        [InlineData(18, 1)] // Adulta (l�mit inferior)
        [InlineData(30, 1)] // Adulta
        [InlineData(65, 1)] // Adulta (l�mit superior)
        [InlineData(70, 2)] // Senesc�ncia
        public void ClassifyAgeTest(int age, int expected)
        {
            var result = _helper.ClassifyAge(age);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(99, false)]
        public void IsEvenTest(int age, bool expected)
        {
            var result = _helper.IsEven(age);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ana", true, true)] // Curt i pal�ndrom
        [InlineData("anna", false, true)] // No curt, per� pal�ndrom
        [InlineData("John", true, false)] // Curt per� no pal�ndrom
        [InlineData("Christopher", false, false)] // No curt ni pal�ndrom
        public void NameAnalyser_ShouldAnalyzeNameCorrectly(string name, bool expectedIsShort, bool expectedIsPalindrome)
        {
            var result = _helper.NameAnalyser(name);
            Assert.Equal(expectedIsShort, result.IsShort);
            Assert.Equal(expectedIsPalindrome, result.IsPalindrome);
        }

        [Fact]
        public void NameAnalyser_ShouldThrowExceptionForInvalidName()
        {
            Assert.Throws<ArgumentException>(() => _helper.NameAnalyser(""));
        }

        [Theory]
        [InlineData("blau", 0)] // Calmant
        [InlineData("verd", 0)] // Calmant
        [InlineData("vermell", 1)] // Exclusiu
        [InlineData("", -1)] // No v�lid
        public void VerifyColour_ShouldReturnCorrectCategory(string colour, int expected)
        {
            var result = _helper.VerifyColour(colour);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("mat�", 0)] // Matinal
        [InlineData("nit", 1)] // Nocturna
        [InlineData("tarda", 2)] // Imprevista
        [InlineData("diumenge", 2)] // Imprevista
        public void PersonalityTest_ShouldReturnCorrectType(string preference, int expected)
        {
            var result = _helper.PersonalityTest(preference);
            Assert.Equal(expected, result);
        }
    }
}