public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romans = new Dictionary<char, int>();
        romans.Add('I', 1);
        romans.Add('V', 5);
        romans.Add('X', 10);
        romans.Add('L', 50);
        romans.Add('C', 100);
        romans.Add('D', 500);
        romans.Add('M', 1000);

        int result = 0;

        for(int i = 0; i < s.Length; i++){
            if(i < s.Length - 1 && romans[s[i]] < romans[s[i + 1]]){
                result -= romans[s[i]];
            }else{
                result += romans[s[i]];
            }
        }
        return result;
    }
}
