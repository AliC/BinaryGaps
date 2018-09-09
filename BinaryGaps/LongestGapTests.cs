using System;
using Xunit;

namespace BinaryGaps
{
    public class LongestGapTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1041, 5)]
        [InlineData(2147483647, 0)]
        [InlineData(1073741825, 29)]
        
        public void Binary_Gaps_Are_Detected_Correctly(int positiveInteger, int expectedLongestGap)
        {
            var longestGapFinder = new Solution();
            var actualLongestGap = longestGapFinder.solution(positiveInteger);

            Assert.Equal(expectedLongestGap, actualLongestGap);
        }
    }
}
