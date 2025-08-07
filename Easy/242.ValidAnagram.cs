public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        foreach(char c in s){
            if(!chars.ContainsKey(c))
                chars.Add(c, 1);
            else
                chars[c]++;
        }

        foreach(char c in t){
            if(!chars.ContainsKey(c))
                return false;
            chars[c]--;
        }
        foreach(var item in chars){
            if(item.Value != 0)
                return false;
        }
        return true;
    }
}
