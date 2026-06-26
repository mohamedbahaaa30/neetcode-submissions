class Solution {
    public boolean hasDuplicate(int[] nums) {
       HashSet<Integer> test=new HashSet<>();
       for(int item : nums){
        if(!test.add(item))
        {
            return true;
        }
       }
       return false;
    }
}