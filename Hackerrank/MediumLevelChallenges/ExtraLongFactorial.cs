using System.Numerics;

namespace HackerRankProblemSolving.MediumLevelChallenges
{
    public class ExtraLongFactorial
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger nfactorial = n;

            while (n > 1)
            {
                nfactorial *= (n - 1);
                n -= 1;
            }

            Console.WriteLine(nfactorial.ToString());
        }


    }
}
