using NUnit.Framework;

namespace TestApp.Tests
{
    public class Tests
    {
        [TestCaseSource(nameof(FormatCases))]
        public void FormatTests(int seconds, string answer)
        {
            var result = HumanTimeFormat.formatDuration(seconds);
            Assert.AreEqual(answer, result);
        }


        static object[] FormatCases =
        { 
            new object[] { 0, "now" },
            new object[] { 12, "12 seconds" },
            new object[] { 120, "2 minutes" },
            new object[] { 1120, "18 minutes and 40 seconds" },
            new object[] { 594835, "6 days, 21 hours, 13 minutes and 55 seconds" }
        };


    }
}