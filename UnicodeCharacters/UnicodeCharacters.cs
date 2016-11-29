using System;

using System.Text;


namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder unicode = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                unicode.AppendFormat("\\u{0:X4}", (int)input[i]);
                
            }
            Console.WriteLine(unicode.ToString());
        }
    }
}
