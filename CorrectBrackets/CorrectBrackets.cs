using System;


namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];

                if (a == '(')
                {
                    counter++;
                }
                else if (a == ')')
                {
                    counter--;
                }
            }
            if (counter < 0 || counter > 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
