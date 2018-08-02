using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab16readwritenumbersfromtextfile
{
    class CountriesApp
    {
        private CountriesTextFile countriesTextFile;

        private Validator validator;

        public CountriesApp()
        {
            validator = new Validator();
            countriesTextFile = new CountriesTextFile();
        }

        public void ExecuteOrder66()
        {
            bool jedi = true;
            while (jedi)
            {
                int? userchoice;
                do
                {
                    Console.WriteLine("Welcome to the Countries Mantenance Application!\n1 - See the list of countries\n2 - Add a country\n3 - Exit");
                    userchoice = GetUserInput(Console.ReadLine());
                }
                while (!userchoice.HasValue);

                switch (userchoice.Value)
                {
                    case 1:
                        Console.WriteLine(countriesTextFile.ReadCountriesFromFile());
                        break;
                    case 2:
                        string countryName;
                        do
                        {
                            Console.WriteLine("Please enter a country name:");
                            countryName = Console.ReadLine().Trim();
                        }
                        while (validator.IsValidCountry(countryName));

                        countriesTextFile.AddCountryToFile(countryName);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye");
                        jedi = false;
                        break;
                }
            }
        }

        public int? GetUserInput(string choiceFromUser)
        {
            if (!string.IsNullOrWhiteSpace(choiceFromUser))
            {
                int numFromUser;
                bool num1 = int.TryParse(choiceFromUser, out numFromUser);
                if (numFromUser > 0 && numFromUser < 4)
                {
                    return numFromUser;
                }
            }
            return null;
        }
    }
}
