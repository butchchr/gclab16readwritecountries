using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab16readwritenumbersfromtextfile
{
    class Program
    {
        static void Main(string[] args)
        {
            CountriesApp countriesApp = new CountriesApp();
            Console.WriteLine(countriesApp.MenuPrompt());
            string choiceFromUser = Console.ReadLine();
        }
    }
}
