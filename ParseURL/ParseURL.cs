using System;


namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int indexOfProtocol = input.IndexOf("://");
            string protocol = input.Substring(0, indexOfProtocol);
            int indexOfServer = input.IndexOf("/", indexOfProtocol + 3);
            string server = input.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);
            string resource = input.Substring(indexOfServer);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
