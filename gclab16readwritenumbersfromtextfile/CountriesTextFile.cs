using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab16readwritenumbersfromtextfile
{
    class CountriesTextFile
    { 
        private const string FileLocation = @"..\..\countries.txt";
        public static void CountryReader()
        {
            string countryName;
            using (FileStream fileStream =
                File.Create(FileLocation))
            using (StreamReader reader =
                new StreamReader(fileStream))
            {
                countryName = reader.ReadLine();
            }
            Console.WriteLine(countryName);
        }

        public static void CountryWriter()
        {
            //string writeCountryName;
            using (FileStream fileStream =
                File.Create(FileLocation))
            using (StreamWriter writer =
                new StreamWriter(fileStream))
            {
                writer.WriteLine();
            }
        }
    }
}
        
