/* 769. Max Chunks To Make Sorted

https://leetcode.com/problems/max-chunks-to-make-sorted/

Solution:
To decide if we can make a chunk at index i, the maximum element in the current subarray (from the start to i) must be equal to i.
This ensures that all elements before i (inclusive) can independently form a valid sorted chunk.

*/

public class Solution {
    public int MaxChunksToSorted(int[] arr) {

       int max = 0;
       int count =0;
       for(int i =0;i<arr.Length;i++)
       {
          max = Math.Max(max,arr[i]);
          if(max==i) count++;
       }

       return count;
    }
}
