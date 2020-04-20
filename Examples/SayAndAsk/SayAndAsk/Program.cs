using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayAndAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hej";
            Say(s);
            Repeat("Er vejret godt i dag?");
        }

        static void Say(string sentence)
        {
            Console.WriteLine(sentence);
        }

        static string Ask(string question)
        {
            Say(question);
            return Console.ReadLine();
        }

        static void Repeat(string question)
        {
            string answer = Ask(question);
            Say($"Du svarede: {answer}");
        }
    }
}
