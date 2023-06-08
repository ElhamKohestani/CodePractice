namespace HackerRankProblemSolving.EasyLevelChallenges
{
    public class PdfViewer
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            var letters = new char[26]
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            var hights = new List<int>();

            foreach (var c in word)
            {
                hights.Add(h[Array.IndexOf(letters, c)]);
            }

            return hights.Max() * word.Length;
        }

        public static void TestDesignerPdfViewer()
        {
            var t = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var word = "abc";

            Console.WriteLine(designerPdfViewer(t, word));
        }
    }
}
