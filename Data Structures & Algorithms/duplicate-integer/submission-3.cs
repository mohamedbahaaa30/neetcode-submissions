public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
     foreach(int x in nums){
        if (set.Add(x) == false)
            return true ;
     }   
     return false  ;
    }
}
//time complexity O(n)