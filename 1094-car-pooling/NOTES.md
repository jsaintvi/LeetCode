# Thought process
Visualize it by building intervals and see at each point, how many passengers we have on board. If any point we have more than we can (`numPassengers > capacity`), then return false.

## Explanation
* When we onboard (from), we add `numPassengers` at that trip index.
* When we un-board (stop), we remove/subtract `numPassengers` at that trip index

### See example
trips = [[2,1,5],[3,3,7]], capacity = 5

`1-----------5
       3-----------7`

#### Below indicates a running count position at a station
* **Stop 1** -> 2
* **Stop 3** -> 5
* **Stop 5** -> 3
* **Stop 7** -> 0
