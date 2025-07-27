public class Solution {
    public bool IsSubsequence(string s, string t) {
        string result = "";
        int j = 0;

        for(int i = 0; i < t.Length; i++){
            if (j > s.Length - 1){
                break;
            }
            if(t[i] == s[j]){
                result += t[i];
                j++;
            }
        }

        return result == s;
    }
}
