
namespace HackerRankProblemSolving.MediumLevelChallenges;

public static class ClimbingLeaderBoard
{
    private static Tuple<int, bool> CustomBinarySearch(int[] arr, int leftIndex, int rightIndex, int searchTerm)
    {
        if (rightIndex >= leftIndex)
        {
            int mid = leftIndex + (rightIndex - leftIndex) / 2;

            if (arr[mid] == searchTerm)
                return new Tuple<int, bool>(mid, true);

            if (arr[mid] > searchTerm)
                return CustomBinarySearch(arr, leftIndex, mid - 1, searchTerm);


            return CustomBinarySearch(arr, mid + 1, rightIndex, searchTerm);
        }

        return new Tuple<int, bool>(leftIndex, false);
    }
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        Dictionary<int, int> leaderboardScoresRanked = new Dictionary<int, int>();
        int lastScoreRanked = ranked[0];
        int lastRankAssignedToAnScore = 1;

        leaderboardScoresRanked.Add(lastScoreRanked, lastRankAssignedToAnScore);

        foreach (int score in ranked)
        {
            if (score == lastScoreRanked)
            {
                continue;
            }
            else
            {
                lastRankAssignedToAnScore += 1;
                leaderboardScoresRanked.Add(score, lastRankAssignedToAnScore);
                lastScoreRanked = score;
            }
        }
        int[] rankedScoresAsKeys = leaderboardScoresRanked.Keys.OrderBy(k => k).ToArray();
        int scoreBoardLength = rankedScoresAsKeys.Length;

        List<int> playerRankAfterEachGame = new List<int>();
        int gameRank = 0;
        Tuple<int, bool> result;

        foreach (int currentGameScore in player)
        {
            result = CustomBinarySearch(rankedScoresAsKeys, 0, scoreBoardLength - 1, currentGameScore);

            int scoreIndex = result.Item1;
            bool isExactMatch = result.Item2;

            if (scoreIndex > scoreBoardLength - 1)
            {
                scoreIndex -= 1;
                isExactMatch = true;
            }

            gameRank = leaderboardScoresRanked[rankedScoresAsKeys[scoreIndex]];

            //if not exact match
            if (!isExactMatch)
            {
                gameRank += 1;
            }

            playerRankAfterEachGame.Add(gameRank);
        }

        return playerRankAfterEachGame;
    }
}
