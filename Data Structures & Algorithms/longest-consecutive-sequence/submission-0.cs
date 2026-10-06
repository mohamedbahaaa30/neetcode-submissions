public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length==0) return 0 ;
        int count =1;
        int longest =1 ;
        Array.Sort(nums); // O(nlog(n))
        for(int k = 1 ; k <nums.Length ; k++)
        {
            if(nums[k] == nums[k-1]) continue ;  // dublicated
            if(nums[k] - nums[k-1] == 1)
            {
                count++;
                longest= Math.Max(longest , count);
            }
            else 
                count =1  ;  //reset the counter 

        }
        return longest;
    }
}
