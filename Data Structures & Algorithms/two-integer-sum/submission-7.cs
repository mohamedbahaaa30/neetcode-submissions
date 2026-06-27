public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new  Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
           dict[nums[i]]=i;
        }
        for(int j=0;j<nums.Length;j++){
            int required = target-nums[j];
            if(dict.ContainsKey(required) && dict[required] != j) {
                return new int[]{j,dict[required]};
            }
        }
        return new int [0];

    }
}
