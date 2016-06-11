using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string protocol = string.Empty, server = string.Empty, resource = string.Empty;
            int possition = 0;
            
            //protokol
            while (url[possition] != ':')
            {
                protocol += url[possition];
                possition++;
            }
            possition += 3;
            //server
            while (url[possition] != '/')
            {
                server += url[possition];
                possition++;
            }
            //resource
            for (; possition < url.Length; possition++)
            {
                resource += url[possition];
            }


            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
