using System;
using System.Linq;


namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();
            string textInput = Console.ReadLine();

            string[] sentences = textInput.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = NonLetters(textInput);

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (word.Trim() == search)
                    {
                        Console.Write(sentence.Trim() + ". ");
                        break;
                    }
                }
            }
        }
        private static char[] NonLetters (string input)
        {
            char[] symbols = input.Where(ch => !char.IsLetter(ch)).Distinct().ToArray();
            return symbols;
        }

    }
}
