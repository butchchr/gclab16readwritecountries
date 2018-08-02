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

        public string ReadCountriesFromFile()
        {
            string fileContents = string.Empty;
            if (File.Exists(FileLocation))
            {
                using (StreamReader reader = new StreamReader(FileLocation))
                {
                    fileContents = reader.ReadToEnd();
                }
            }
            return fileContents;
        }

        public void AddCountryToFile(string countryName)
        {
            File.AppendAllText(FileLocation, countryName + Environment.NewLine);
        }
    }
}

