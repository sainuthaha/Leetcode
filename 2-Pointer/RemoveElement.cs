/*
27. Remove Element
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.

https://leetcode.com/problems/remove-element/description/?envType=study-plan-v2&envId=top-interview-150
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
    
        int j =0;
        for(int i =0;i<nums.Length;i++)
        {
            if(nums[i]!=val)
            {
              nums[j] =nums[i];
              j++;
            }      
        }
        return j;
    }
}
