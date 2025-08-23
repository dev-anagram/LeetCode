public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> record = new Stack<int>();
        int result = 0;

        foreach(string op in operations){
            if(op == "+"){
                int t = record.Pop();
                int nt = t + record.Peek();
                record.Push(t);
                record.Push(nt);
            }else if(op == "D"){
                record.Push(record.Peek() * 2);
            }else if(op == "C"){
                record.Pop();
            }else{
                record.Push(Int32.Parse(op));
            }
        }
        while(record.Count() > 0){
            result += record.Pop();
        }
        return result;
    }
}
