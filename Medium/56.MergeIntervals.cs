public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => {return a[0] - b[0];});
        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);

        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] <= result[result.Count - 1][1]){
                if(intervals[i][1] > result[result.Count - 1][1]){
                    result[result.Count - 1][1] = intervals[i][1];
                }
            }else{
                result.Add(intervals[i]);
            }
        }

        return result.ToArray();
    }
}
