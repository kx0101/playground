namespace letssee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 1, 3, 5, 6, 8 };

            var result = Intersect(list1, list2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // This is the optimal approach - O(n) and O(1) space excluding the result list ofc
        static List<int> Intersect(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            HashSet<int> set = new HashSet<int>(list1);

            foreach (var item in list2)
            {
                if (set.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        // This is the naive approach - O(n^2)
        /* static List<int> Intersect(List<int> list1, List<int> list2) */
        /* { */
        /*     List<int> result = new List<int>(); */
        /*  */
        /*     foreach (var item in list1) */
        /*     { */
        /*         if (list2.Contains(item)) */
        /*         { */
        /*             result.Add(item); */
        /*         } */
        /*     } */
        /*  */
        /*     return result; */
        /* } */
    }
}
