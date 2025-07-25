public class Solution {
    public int FindClosestNumber(int[] nums) {
        int result = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(Math.Abs(nums[i]) < Math.Abs(result)){
                result = nums[i];
            }else if(Math.Abs(nums[i]) == Math.Abs(result)){
                if(nums[i] > result){
                    result = nums[i];
                }
            }
        }
        return result;
    }
}
