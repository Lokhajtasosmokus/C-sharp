using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMEthod
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string al = "Greenfox";

            Console.WriteLine(Greet(al));
            Console.ReadLine();
        }

        public static string Greet(string name)
        {
            return ("Greatings dear, " + name);
        }
    }
}
