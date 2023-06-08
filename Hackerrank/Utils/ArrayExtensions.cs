namespace HackerRankProblemSolving.Utils
{
    public static class ArrayExtensions
    {
        public static T[] SliceByIndex<T>(this T[] array, int fromIndex, int toIndex)
        {
            int offset = fromIndex;
            int length = (toIndex - fromIndex) + 1;

            return array
                .Skip(offset)
                .Take(length)
                .ToArray<T>();
        }
    }
}
