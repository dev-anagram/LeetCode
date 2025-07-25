public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int lowerLength = Math.Min(word1.Length, word2.Length);
        string result = "";
        for (int i = 0; i < lowerLength; i++){
            result += word1[i];
            result += word2[i];
        }
        if(word1.Length < word2.Length){
            for (int i = lowerLength; i < word2.Length; i++){
                result += word2[i];
            }
        }else if(word1.Length > word2.Length){
            for(int i = lowerLength; i < word1.Length; i++){
                result += word1[i];
            }
        }
        return result;
    }
}
