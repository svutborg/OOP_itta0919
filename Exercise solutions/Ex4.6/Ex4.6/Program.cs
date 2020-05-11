using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._6
{
    class Program
    {
        /* 
         * Write a program that parses an URL in following format:
         * [protocol]://[server]/[resource]
         * It should extract from the URL the protocol, server and resource parts. 
         * For example, when http://www.cnn.com/video is passed, the result is:
         * 
         * [protocol]="http"
         * [server]="www.cnn.com"
         * [resource]="video"
         */
        static void Main(string[] args)
        {
            string inputURL = "http://www.cnn.com/video";
            string[] fragments = inputURL.Split(new char[] { '/', ':' }, StringSplitOptions.RemoveEmptyEntries);



            Console.WriteLine($"[protocol]=\"{fragments[0]}\"");
            Console.WriteLine($"[server]=\"{fragments[1]}\"");
            Console.WriteLine($"[resource]=\"{fragments[2]}\"");
        }
    }
}
