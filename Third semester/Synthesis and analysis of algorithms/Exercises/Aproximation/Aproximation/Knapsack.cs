namespace Aproximation
{
    public static class Knapsack
    {
        public static void KnapsackBB(
            Item[] items,
            int itemIdx,
            string solution,
            double weight,
            double profit,
            ref double profitLowerBound,
            ref string bestSolution)
        {
            if (itemIdx == 0 || weight < 0)
            {
                if (weight >= 0 && profit > profitLowerBound)
                {
                    profitLowerBound = profit;
                    bestSolution = solution;
                }

                return;
            }

            var restWeight = weight;
            var restFullProfit = 0.0;
            var restPartialProfit = 0.0;

            for (var i = itemIdx - 1; i >= 0; i--)
            {
                if (items[i].Weight < restWeight)
                {
                    restWeight -= items[i].Weight;
                    restFullProfit += items[i].Value;
                }
                else
                {
                    restPartialProfit = (items[i].Value / items[i].Weight) * restWeight;
                    break;
                }
            }

            if (profitLowerBound >= profit + restFullProfit + restPartialProfit)
            {
                return;
            }

            KnapsackBB(
                items,
                itemIdx - 1,
                solution + (itemIdx - 1),
                weight - items[itemIdx - 1].Weight,
                profit + items[itemIdx - 1].Value,
                ref profitLowerBound,
                ref bestSolution);

            if (profitLowerBound >= profit + restFullProfit + restPartialProfit)
            {
                return;
            }

            KnapsackBB(
                items,
                itemIdx - 1,
                solution,
                weight,
                profit,
                ref profitLowerBound,
                ref bestSolution);
        }
    }
}
