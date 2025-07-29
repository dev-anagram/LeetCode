public class Solution {
    public int MaxProfit(int[] prices) {
        int bestDeal = 0;
        int minStock = Int32.MaxValue;

        for(int i = 0; i < prices.Length; i++){
            if(minStock > prices[i]){
                minStock = prices[i];
                continue;
            }
            if(prices[i] - minStock > bestDeal){
                bestDeal = prices[i] - minStock;
            }
        }
        return bestDeal;
    }
}
