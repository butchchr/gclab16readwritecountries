using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab16readwritenumbersfromtextfile
{
    class CountriesApp
    {
        public string MenuPrompt()
        {
           return "Welcome to the Countries Mantenance Application!\n1 - See the list of countries\n2 - Add a country\n3- Exit";
        }
        
        public void Rename()
        {
            Validator.IsNumValid(choiceFromUser);
        }

        public void MenuActions(int i)
        {
            i = 3;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine(CountriesTextFile.CountryReader());
                    }
                case 2:
                    {
                        Console.WriteLine(CountriesTextFile.CountryWriter());
                    }
                case 3:
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
            }
        }
    }
}
