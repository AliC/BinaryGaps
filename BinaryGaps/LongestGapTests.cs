using System;
using Xunit;

namespace BinaryGaps
{
    public class LongestGapTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(9, 2)]
        public void Binary_Gaps_Are_Detected_Correctly(int positiveInteger, int expectedLongestGap)
        {
            var longestGapFinder = new Solution();
            var actualLongestGap = longestGapFinder.solution(positiveInteger);

            Assert.Equal(expectedLongestGap, actualLongestGap);
        }
    }
}
