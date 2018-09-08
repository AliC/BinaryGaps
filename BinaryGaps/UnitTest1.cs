using System;
using Xunit;

namespace BinaryGaps
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var foo = new Solution();
            var answer = foo.solution(0);

            Assert.Equal(0, answer);
        }
    }
}
