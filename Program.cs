namespace letssee
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Print(s.FizzBuzz(15));
        }

        static void Print(IList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            Dictionary<int, string> map = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
            };

            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string output = "";
                foreach (var entry in map)
                {

                    if (i % entry.Key == 0)
                    {
                        output += entry.Value;
                    }
                }

                if (output == "")
                {
                    output += i.ToString();
                }

                result.Add(output);

            }

            return result;
        }
    }
}
