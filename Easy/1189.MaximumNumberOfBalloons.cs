public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        string word = "balloon";

        foreach(char c in text){
            if(word.Contains(c))
                if(chars.ContainsKey(c)){
                    chars[c]++;
                }else{
                    chars.Add(c, 1);
                }
        }

        if(!chars.ContainsKey('b') ||
           !chars.ContainsKey('a') ||
           !chars.ContainsKey('l') ||
           !chars.ContainsKey('o') ||
           !chars.ContainsKey('n'))
           return 0;
        else
            return Math.Min(Math.Min(chars['b'], chars['a']),
                            Math.Min(chars['l'] / 2,
                                     Math.Min(chars['o'] / 2, chars['n'])));
    }
}
