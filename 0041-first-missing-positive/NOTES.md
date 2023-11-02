# Thought process
In an array of length n, the max possible missing number is n + 1 (things of cases where all the elements are present [1,2,3,4]).

## Approach
Build a set of those numbers , since it allows us a O(1) lookup, then search from 1 to length of arr, and look for the value that is not in our set, if found then return that value. Else that is the case where all the numbers are present ([1,2,3,4,5]), so return length of array + 1, in this example 6

## Pseudocode
```c#
int FirstMissing(int[] nums) {
    len= len(nums)
    
    HashSet s = (nums)
    
    for(int i = 1; i <= n; i++) {
        if(i not in s)
            return i
    }
    
    return n + 1
}
```