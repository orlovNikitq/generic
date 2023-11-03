using System;
using System.ComponentModel;

namespace MyApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string text = "Вот дом, Который построил Джек. А это пшеница, хранится которая в темном чулане дом хранится.";
            string[] wordArray = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordArray)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }

            int i = 1;
            foreach (var el in words)
            {
                Console.Write(i + " ");
                Console.WriteLine($"Значение: \"{el.Key}\"  кол-во повторов: {el.Value}");
                i++;
            }
        }
    }
}