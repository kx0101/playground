namespace letssee
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "listen";
            string word2 = "silent";

            Console.WriteLine("Are the words {0} and {1} anagrams? {2}", word1, word2, Anagram(word1, word2));
        }

        static bool Anagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            Dictionary<char, int> word1Dict = new Dictionary<char, int>();

            foreach (char letter in word1)
            {
                if (word1Dict.ContainsKey(letter))
                {
                    word1Dict[letter]++;
                }
                else
                {
                    word1Dict.Add(letter, 1);
                }
            }

            foreach (char letter in word2)
            {
                if (word1Dict.ContainsKey(letter))
                {
                    word1Dict[letter]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
