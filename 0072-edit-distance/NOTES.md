# Thought process
We want to edit string x and transform it to y with minimum number of operations (replace, insert/delete). We need to explore all possible ways to perform the conversion and choose the one with the fewest number of operations.

## We starts by comparing all the characters, and there are scenarios we can encounter:
### Case 1: 
if last characters of strings match, if(X[m-1] == Y[n-1]), no operation is needed, we can ignore it and recursively solve the same subproblem for remaining strings of size m-1 and n-1. The problem in other words is reduced to finding the Edit distance of the remaining substrings of size m-1 and n-1 size. `EditDistance(X,Y, m-1, n-1)`
### Case 2:
When not equal, we have 3 possibilities (can consider all 3 operations)
1. [ ] **Possibility 1-Insert**: Suppose we insert a character that is equal to the last char of second string - the problem gets reduced to finding the editDistance between string X of size m and string Y of size n-1 i.e `EditDistance(X,Y, m, n-1)`
2. [ ] **Possibility 2-Delete**: If we delete the last char from first string, the problem gets reduced to finding the EditDistance between string X of size m-1 and string Y of size n i.e `EditDistance(X,Y,m-1,n)`
3. [ ] **Possibility 3-Replace**: If we replace the last char of first string with the last char of string Y, the problem gets reduced to finding the EditDistance of string Xf size m-1 and the string Y of size n-1 i.e `EditDistance(X,Y, m-1, n-1)`

Now Any of those 3 possibilities can give the solution with the minimum nnumber of operations, we need to take the one woth the min operations.

`EditDistance(m,n) = 1 + min(EditDistance(m,n-1), EditDistance(m-1, n), EditDistance(m-1, n-1))`. We add + 1 cause we did perform an operation at that step.