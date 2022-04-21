namespace LinqAssignment
{
    public static class Filter
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 23,4,1,2,10,15,18,3 };

            var numbersDivisibleByThree = numbers.Filter(number=>number%3==0);
            foreach(var num in numbersDivisibleByThree)
            {
                Console.WriteLine(num);
            }
        }
    }

    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var itm in items)
            {
                if (predicate(itm))
                {
                    yield return itm;
                }
            }
        }
    }
}
