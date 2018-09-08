using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinaryGaps
{
    class Solution
    {
        public int solution(int N)
        {
            var binaryRepresentation = GetRepresentation(N);
            var longestGap = GetLongestGap(binaryRepresentation);

            return longestGap;
        }

        private string GetRepresentation(int n)
        {
            var map = new[] { 16, 8, 4, 2, 1 };
            var value = new Queue();

            //TODO ADC: try this collection out at some point - not seen it before
            //System.Collections.BitArray

            foreach (var place in map)
            {
                if (n >= place)
                {
                    value.Enqueue("1");
                    n -= place;
                }
                else
                {
                    value.Enqueue("0");
                }
            }

            return string.Join("", value.Cast<string>());
        }

        private int GetLongestGap(string binaryRepresentation)
        {
            int longestGap = 0;
            List<int> indices = new List<int>();

            int index = binaryRepresentation.IndexOf("1", 0);
            while (index >= 0)
            {
                indices.Add(index);

                index = binaryRepresentation.IndexOf("1", index + 1);
            }

            IEnumerable<int> pair;
            int skipThisMany = 0;

            while ((pair = indices.Skip(skipThisMany).Take(2)).Count() == 2)
            {
                int gap = pair.Last() - pair.First() - 1;
                if (gap > longestGap)
                {
                    longestGap = gap;
                }

                skipThisMany++;
            }

            return longestGap;
        }
    }
}