class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap <Integer,Integer> map =new HashMap<>();
        for(int i=0;i<nums.length;i++){
            map.put(nums[i],i);
        }
        for(int i=0;i<nums.length;i++){
            int target2=target-nums[i];
            if(map.containsKey(target2) && map.get(target2)!=i){
                return new int [] {i,map.get(target2)};
            }
        }
        return new int [0];
    }
}
// this condition : "&& map.get(target2)!=i" not to add the one number twice 