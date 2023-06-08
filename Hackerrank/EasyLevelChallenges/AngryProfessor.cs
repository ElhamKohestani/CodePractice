namespace HackerRankProblemSolving.EasyLevelChallenges
{
    public static class AngryProfessorStudents
    {
        public static string AngryProfessor(int k, List<int> a)
        {


            int totalOnTimeStudents = a.Where(a => a <= 0).ToList().Count;

            return totalOnTimeStudents >= k ? "NO" : "YES";
        }

        public static void TestAngryProfessor()
        {
            List<int> arrivals = new List<int>() { -1, -3, 4, 2 };
            int threshold = 3;

            List<int> arrivals2 = new List<int>() { 0, -1, 2, 1 };
            int threshold2 = 2;






            Console.WriteLine(AngryProfessor(threshold, arrivals));
            Console.WriteLine(AngryProfessor(threshold2, arrivals2));

        }
    }
}
