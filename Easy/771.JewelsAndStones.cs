public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> HSJewels = new HashSet<char>(jewels);
        int result = 0;

        for(int i = 0; i < stones.Length; i++){
            if(HSJewels.Contains(stones[i]))
                result += 1;
        }
        return result;
    }
}
