public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dic.ContainsKey(nums[i])){
                dic.Add(nums[i], i);
            }
        }

        for(int i = 0; i < nums.Length; i++){
            int x = target - nums[i];
            if(dic.ContainsKey(x) && dic[x] != i){
                return [i, dic[x]];
            }
        }
        return [0, 0];
    }
}
