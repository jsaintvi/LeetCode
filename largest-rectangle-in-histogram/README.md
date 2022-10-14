<h2>  Largest Rectangle in Histogram</h2><hr><div><p>Given an array of integers <code>heights</code> representing the histogram's bar height where the width of each bar is <code>1</code>, return <em>the area of the largest rectangle in the histogram</em>.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>
<img alt="" src="https://assets.leetcode.com/uploads/2021/01/04/histogram.jpg" style="width: 522px; height: 242px;">
<pre><strong>Input:</strong> heights = [2,1,5,6,2,3]
<strong>Output:</strong> 10
<strong>Explanation:</strong> The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.
</pre>

<p><strong class="example">Example 2:</strong></p>
<img alt="" src="https://assets.leetcode.com/uploads/2021/01/04/histogram-1.jpg" style="width: 202px; height: 362px;">
<pre><strong>Input:</strong> heights = [2,4]
<strong>Output:</strong> 4
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= heights.length &lt;= 10<sup>5</sup></code></li>
	<li><code>0 &lt;= heights[i] &lt;= 10<sup>4</sup></code></li>
</ul>
</div>

## Solution explanation
1. Idea is, we will consider every element a[i] to be a candidate for the area calculation. That is, if a[i] is the minimum element then what is the maximum area possible for all such rectangles? We can easily figure out that it's a[i]*(R-L+1-2) or a[i] * (R-L-1), where a[R] is first subsequent element(R>i) in the array just smaller than a[i], similarly a[L] is first previous element just smaller than a[i]. makes sense? (or take a[i] as a center and expand it to left and right and stop when first just smaller elements are found on both the sides). But how to implement it efficiently?
2. We add the element a[i] directly to the stack if it's greater than the peak element (or a[i-1] ), because we are yet to find R for this. Can you tell what's L for this? Exactly, it's just the previous element in stack. (We will use this information later when we will pop it out).
3. What if we get an element a[i] which is smaller than the peak value, it is the R value for all the elements present in stack which are greater than a[i]. Pop out the elements greater than a[i], we have their R value and L value(point 2). and now push a[i] and repeat..