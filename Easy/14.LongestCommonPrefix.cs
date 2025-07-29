public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = strs[0];
        for(int i = 1; i < strs.Length; i++){

            int lower;
            if(strs[i].Length <= result.Length){
                lower = strs[i].Length;
                result = result.Remove(strs[i].Length);
            }else{
                lower = result.Length;
            }

            for(int j = 0; j < lower; j++){
                string word = strs[i];
                if(result[j] != word[j]){
                    result = result.Remove(result.Length - (result.Length - j));
                    break;
                }
            }
        }
        return result;
    }
}
