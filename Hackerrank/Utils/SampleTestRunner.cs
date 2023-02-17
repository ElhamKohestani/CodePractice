using HackerRankProblemSolving.EasyLevelChallenges;
using HackerRankProblemSolving.MediumLevelChallenges;
using System.Diagnostics;

namespace HackerRankProblemSolving.Utils
{
    public static class SampleTestRunner
    {
        public static void ClimbingLeaderBoardTest()
        {
            List<int> scoreBoard = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };
            List<int> playerScores = new List<int>() { 5, 25, 50, 120 };

            Stopwatch watcher = new Stopwatch();
            watcher.Start();

            var playerRankAfterEachGame = ClimbingLeaderBoard.climbingLeaderboard(scoreBoard, playerScores);
            foreach (var i in playerRankAfterEachGame)
            {
                Console.WriteLine(i);
            }

            watcher.Stop();

            Console.WriteLine($"Running test for Climbing LeaderBoard Test. Time elapsed {watcher.ElapsedMilliseconds} ms");

        }

        public static void SequenceEquationTest()
        {
            int[] p = new[] { 5, 2, 1, 3, 4 };
            var res = SequenceEquation.permutationEquation(p.ToList());

            foreach (var r in res)
                Console.WriteLine(r);
        }
    }
}
