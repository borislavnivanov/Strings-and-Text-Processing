using System;
using System.Text;


namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int toUpper = -1;
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    i++;
                    toUpper = toUpper * -1;

                    while (input[i] != '>')
                    {
                        i++;
                    }
                }
                else
                {
                    if (toUpper == 1)
                    {
                        output.Append(input[i].ToString().ToUpper());
                    }
                    else
                    {
                        output.Append(input[i]);
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
