public class Solution {
    public int[] SortedSquares(int[] nums) {
        List<int> temp = new List<int>();
        List<int> result = new List<int>();

        for(int i = 0; i < nums.Length; i++){
            nums[i] *= nums[i];
        }

        int l = 0;
        int r = nums.Length - 1;
        while(l <= r){
            if(nums[l] >= nums[r]){
                result.Add(nums[l]);
                l++;
            }else{
                result.Add(nums[r]);
                r--;
            }
        }

        l = 0;
        r = result.Count - 1;

        while(l < r){
            (result[l], result[r]) = (result[r], result[l]);
            l++;
            r--;
        }

        return result.ToArray();
    }
}
