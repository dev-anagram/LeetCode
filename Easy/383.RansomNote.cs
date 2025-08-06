public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> letters = new Dictionary<char,int>();

        foreach(char c in magazine){
            if(letters.ContainsKey(c))
                letters[c]++;
            else
                letters[c] = 1;
        }

        foreach(char c in ransomNote){
            if(!letters.ContainsKey(c) || letters[c] == 0)
                return false;
            else
                letters[c]--;
        }
        return true;
    }
}
