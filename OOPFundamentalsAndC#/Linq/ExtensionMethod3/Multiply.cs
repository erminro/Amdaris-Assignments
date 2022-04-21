namespace LinqAssignment
{
    public static class Filter
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 23, 4, 1, 2, 10, 15, 18, 3 };

            var numbersMultypliedBy4 = numbers.Multiplycator(4);
            foreach(int number in numbersMultypliedBy4)
            {
                Console.WriteLine(number);
            }
        }
    }

    public static class FilterExtensions
    {
        public static IEnumerable<int> Multiplycator(this int[] items, int m)
        {
            foreach (var itm in items)
            {
                    yield return itm*m;
            }
        }
    }
}
