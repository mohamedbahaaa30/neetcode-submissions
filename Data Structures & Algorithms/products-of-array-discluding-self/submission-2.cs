public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = 1;
        var output = new int[nums.Length];
        for(int i=0 ; i<nums.Length; i++){
            for(int j=0;j<nums.Length;j++){
                if (i==j)
                    continue ;
                result = result * nums[j] ;
            }
        output[i]=result;
        result=1 ;
        }
        return output;
    }
}
