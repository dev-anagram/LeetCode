public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> chars = new Dictionary<char, int>();

        if(s.Length != t.Length)
            return false;

        foreach(char c in s){
            if(!chars.ContainsKey(c))
                chars.Add(c, 1);
            else
                chars[c]++;
        }

        foreach(char c in t){
            if(!chars.ContainsKey(c) || chars[c] == 0)
                return false;
            chars[c]--;
        }

        return true;
    }
}
