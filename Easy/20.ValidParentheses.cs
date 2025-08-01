public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0 || s.Length % 2 != 0) return false;

        Hashtable pairs = new Hashtable();
        pairs.Add(')','(');
        pairs.Add('}','{');
        pairs.Add(']','[');

        string order = "";

        for(int i = 0; i < s.Length; i++){
            if(pairs.ContainsValue(s[i])){
                order += s[i];
            }else if(pairs.ContainsKey(s[i])){
                if(order.Length != 0){
                    if(order[order.Length - 1] == (char)pairs[s[i]]){
                        order = order.Remove(order.Length - 1);
                    }else{
                        return false;
                    }
                }else{
                    return false;
                }
            }
        }
        if(order.Length == 0) return true;
        else return false;
    }
}
