namespace letssee
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib = 9;
            Dictionary<int, int> fibDict = new Dictionary<int, int>();
            fibDict.Add(0, 0);
            fibDict.Add(1, 1);

            Console.WriteLine("Fibonacci of {0} is {1}", fib, Fibonacci(fib, fibDict));
        }

        static int Fibonacci(int n, Dictionary<int, int> fibDict)
        {
            if (fibDict.ContainsKey(n))
            {
                return fibDict[n];
            }

            for (int i = 2; i <= n; i++)
            {
                if (!fibDict.ContainsKey(i))
                    fibDict.Add(i, fibDict[i - 1] + fibDict[i - 2]);
            }

            return fibDict[n];
        }
    }
}
