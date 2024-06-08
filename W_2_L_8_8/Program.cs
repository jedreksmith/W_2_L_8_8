namespace W_2_L_8_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter;
            Console.WriteLine("Give me a word");
            string word = Console.ReadLine();

            for (int i = 0; i<word.Length; i++) 
            Console.Write(word[word.Length - i - 1]); 
        }
    }
}
