using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        //string input = Console.ReadLine();

        //StringBuilder output = new StringBuilder();

        //string[] text = input
        //    .Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None);

        //foreach (var word in text)
        //{
        //    int indexOfLink = word.IndexOf("=\"");

        //    if (indexOfLink >= 0)
        //    {
        //        int endIndex = word.IndexOf("\">");
        //        output.Append("[");
        //        output.Append(word.Substring(endIndex + 2, word.Length - endIndex - 2));
        //        output.Append("](");
        //        output.Append(word.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
        //        output.Append(")");
        //    }
        //    else
        //    {
        //        output.Append(word);
        //    }
        //}

        //if (output.Length == 0)
        //{
        //    Console.WriteLine(input);
        //}
        //else
        //{
        //    Console.WriteLine(output.ToString());
        //}

        string hTML = Console.ReadLine();
        string pattern = @"<a href=""(.*?)"">(.*?)</a>";
        string replacement = @"[$2]($1)";
        Console.WriteLine(Regex.Replace(hTML, pattern, replacement));


    }
}
