using System;

namespace letssee
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "Hello how are you doing damn this is quite a long text isnt it hahah blah blah blah";
            var shortenedPost = post.Shorten(3);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 10, 18, 22 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Max());

            Console.WriteLine(shortenedPost);
        }
    }
}
