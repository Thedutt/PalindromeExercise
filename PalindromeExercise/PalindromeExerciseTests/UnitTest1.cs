using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello",false)]
        [InlineData("Racecar",true)]
        public void Test1(string word, bool expected)
        {
            var test = new WordSmith();
            bool actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);

        }
    }
}
