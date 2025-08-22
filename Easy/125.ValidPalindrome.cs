public class Solution {
    public bool IsPalindrome(string s) {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string digits = "0123456789";
        char [] alphas = (digits + alphabet + alphabet.ToLower()).ToCharArray();
        string phrase = "";
        for(int i = 0; i < s.Length; i++){
            if(alphas.Contains(s[i]))
                phrase += Char.ToLower(s[i]);
        }

        int l = 0;
        int r = phrase.Length - 1;
        while(l < r){
            if(phrase[l] != phrase[r])
                return false;
            else
                l++;
                r--;
        }
        return true;
    }
}
