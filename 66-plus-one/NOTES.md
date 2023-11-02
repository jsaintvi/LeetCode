# THoughts process
That number is incremented by 1. When doing so, approach it as we typically do in math, where we add the least significant piece (i.e last digit) first, then so on.

## In our case
Lets look at some samples
### Case 1: Last digit is < 9
Ex: 11 -> 12, 114 -> 115 : we simply increment last digit and immediately return
### Case 2: Last digit is 9 but the most significant is not 9
Ex: 19 -> 20, 229 -> 230, when digit is 9, we set to 0, when digit is not 9, we increment by 1 and immediately return
### Case 3: all digits are 9
Ex: 99 -> 100, 999 -> 1000, we set digit to 0 and append 1 at the beginning (arr len is incremented by 1 and first position is set to 1)

