public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> result = new List<int>();
        List<int> left = new List<int>();
        left.Add(1);
        List<int> right = new List<int>();
        right.Add(1);

        for(int i = 1; i < nums.Length; i++){
            left.Add(left[i - 1] * nums[i - 1]);
            right.Insert(0, right[right.Count - i] * nums[nums.Length - i]);
        }
        for(int i = 0; i < left.Count; i++){
            result.Add(left[i] * right[i]);
        }

        return result.ToArray();
    }
}
