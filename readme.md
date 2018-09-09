A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

---

T1: number 1 has binary representation of 1 and has no binary gaps.  This is a boundary test as 1 is the lowest possible positive integer.

T2: number 9 has binary representation 1001 and contains a binary gap of length 2.

T3: The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3.

T4: The number 20 has binary representation 10100 and contains one binary gap of length 1.

T5: The number 15 has binary representation 1111 and has no binary gaps.

T6: The number 32 has binary representation 100000 and has no binary gaps.

T7: given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.

T8: The number 2,147,483,647 has binary representation 1111111111111111111111111111111 and has no binary gaps.  This is a boundary test as 2,147,483,647 is the highest possible integer within the constraints of the problem.

T9: The number 1,073,741,825 has binary representation 1000000000000000000000000000001 and has a single binary gap of 29.  This is a boundary test as 1,073,741,825 contains the longest possible binary gap within the constraints of the problem.

---

Write a function:

  `class Solution { public int solution(int N); }`

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.


Write an efficient algorithm for the following assumptions:

- N is an integer within the range [1..2,147,483,647].
