using System.Numerics;

namespace HackerRankProblemSolving.EasyLevelChallenges
{
    public static class PickingNumbers
    {


        public static IEnumerable<IEnumerable<T>> Subsets<T>(IEnumerable<T> source)
        {
            List<T> list = source.ToList();
            BigInteger length = list.Count;
            BigInteger max = (BigInteger)Math.Pow(2, list.Count);

            for (int count = 0; count < max; count++)
            {
                List<T> subset = new List<T>();
                uint rs = 0;
                while (rs < length)
                {
                    if ((count & (1u << (int)rs)) > 0)
                    {
                        subset.Add(list[(int)rs]);
                    }
                    rs++;
                }
                yield return subset;
            }
        }
        public static int pickingNumbers(List<int> a)
        {
            var maxCount = 0;
            var sortedList = a.OrderBy((x) => { return x; }).ToList();

            for (int i = 0; i < sortedList.Count; i++)
            {
                var currentCount = 1;
                if (i > 0 && (sortedList[i] == sortedList[i - 1]))
                    continue;

                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(sortedList[j] - sortedList[i]) <= 1)
                        currentCount++;
                    else
                        break;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            return maxCount;
        }

        public static void TestPickingNumbers()
        {
            List<int> list = new List<int>() { 4, 6, 5, 3, 3, 1, };
            List<int> list2 = new List<int>() { 1, 2, 2, 3, 1, 2 };
            //List<int> list3 = new List<int>() { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };

            //Console.WriteLine(pickingNumbers(list2));
            Console.WriteLine(pickingNumbers(list));

        }
    }
}
