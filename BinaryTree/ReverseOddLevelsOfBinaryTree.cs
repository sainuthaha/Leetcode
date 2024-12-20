/**

 Given the root of a perfect binary tree, reverse the node values at each odd level of the tree.

For example, suppose the node values at level 3 are [2,1,3,4,7,11,29,18], then it should become [18,29,11,7,4,3,1,2].
Return the root of the reversed tree.

A binary tree is perfect if all parent nodes have two children and all leaves are on the same level.

The level of a node is the number of edges along the path between it and the root node.

https://leetcode.com/problems/reverse-odd-levels-of-binary-tree/description/?envType=daily-question&envId=2024-12-20
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {

    public void Dfs(TreeNode left,TreeNode right,int level)
    {
       if(left != null && right!=null)
       {
          if(level%2!=0)
          {
              int temp = left.val;
              left.val = right.val;
              right.val = temp;
          }  
          Dfs(left.left,right.right,level+1);
          Dfs(left.right,right.left,level+1);
       }
    }

    public TreeNode ReverseOddLevels(TreeNode root) {

        
       Dfs(root.left,root.right,1);  
       return root;
      
    }
}
