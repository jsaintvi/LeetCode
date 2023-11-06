# Thought process
Sqrt of any number n is always less than n/2 and greater than 1. So we will search in the space of 0 to n/2 (binary search) , looking to see if mid elemt when squared equal to n.

If the squared value is greater than n, that means you want to look for potential answer on the left half as any value on the right (mid+1...) squared will always be greater than n. 