namespace HackerRankProblemSolving.EasyLevelChallenges
{
    public static class TheHurdleRace
    {
        public static int hurdleRace(int k, List<int> height)
        {
            var max = height.Max() - k;
            return max > 0 ? max : 0;
        }
    }
}
