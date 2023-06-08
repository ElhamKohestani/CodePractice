using System.Text;

namespace HackerRankProblemSolving.MediumLevelChallenges
{
    public class Encryption
    {
        public static string encryption(string s)
        {
            s = s.Replace(" ", "");
            var sLooper = 0;
            var sLength = s.Length;

            var squareRootOfLength = Math.Sqrt(sLength);

            var rows = Math.Floor(squareRootOfLength);
            var columns = Math.Ceiling(squareRootOfLength);


            // Ensure rows * columns >= replacedStringLength
            while (rows * columns <= sLength)
            {
                rows += 1;
            }

            char[,] matrix = new char[(int)rows, (int)columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (sLooper < sLength)
                    {
                        matrix[row, column] = s[sLooper];
                        sLooper += 1;
                    }
                    else
                    {
                        matrix[row, column] = '_';
                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    stringBuilder.Append(matrix[row, column]);
                }
                stringBuilder.Append(" ");
            }

            return stringBuilder.ToString().Replace("_", "");
        }

        internal static void TestEncryption()
        {
            Console.WriteLine(encryption("feedthedog"));
        }
    }
}
