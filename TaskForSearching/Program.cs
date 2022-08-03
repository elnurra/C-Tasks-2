using System;

namespace TaskForSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "My name is Gustavo but you can call me Gus";
            bool condition = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    condition = true;
                }
            }
            if (condition) 
            {
                Console.WriteLine("The symbol 'a' exists in the given context");
            }
            else
            {
                Console.WriteLine("The symbol 'a' unfortunately does not exist in this context");
            }
            
        }
    }
}
