public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;

        int current = x;
        int reversed = 0;
        while (current != 0){
            int modX = current % 10;
            reversed = reversed * 10 + modX;
            current = current / 10;
        }
        return reversed == x;

        // string sX = x.ToString();
        // for (int i = 0; i < sX.Length / 2; i++){
        //     if(sX[i] != sX[sX.Length - 1 - i])
        //         return false;
        // }
        // return true;
    }
}
