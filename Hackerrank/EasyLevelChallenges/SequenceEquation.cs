namespace HackerRankProblemSolving.EasyLevelChallenges
{
    public static class SequenceEquation
    {
        private static void Calcualte(List<int> p, int size, int x, ref List<int> res)
        {
            if (x <= size)
            {
                int locationOfX = p.FindIndex(a => a == x) + 1;
                int locationOfLocationOfX = p.FindIndex(a => a == locationOfX) + 1;


                if (p[p[locationOfLocationOfX - 1] - 1] == x)
                    res.Add(locationOfLocationOfX);


                Calcualte(p, size, x + 1, ref res);
            }
        }
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> res = new List<int>();
            Calcualte(p, p.Count, 1, ref res);
            return res;
        }
    }
}
