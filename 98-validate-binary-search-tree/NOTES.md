# Thought process
In BST, node stored in a subtree rooted at any node lies in a particular range - meaning there is an upper range and lower range limmit of values that lie in a specific subtree.

* The tree with root nodes lies in the range **(INT_MIN, INT_MAX)**
* The left subtree lies in the range **(INT_MIN, root.val -1)**
* Right subtree range lies in **(root.val, INT_MAX)**

## Approach
We traverse the tree recursively and keep track of min and max values allowed for subtree rooted at each node.