# Selection sort
**Selection sort** is a simple sorting algorithm that works by splitting collection into the sorted and unsorted part. It looks for the minimum (or maximum) in the unsorted part, and then swaps it with the left most element, this way it builds the sorted region.

This algoritm is inefficient and is not used in practice because its worst-case and average case time complexities are high.

## Complexity analysis
|            **Case**            |               **Complexity**               |
|:------------------------------:|:------------------------------------------:|
|    Worst-case<br>performance   | O(n<sup>2</sup>) comparisons<br>O(n) swaps |
|     Average<br>performance     | O(n<sup>2</sup>) comparisons<br>O(n) swaps |
|    Best-case<br>performance    | O(n<sup>2</sup>) comparisons<br>O(1) swaps |
| Worst-case<br>space complexity |                    O(1)                    |