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
        public void CountryReader()
        {
            string countryName;
            using (FileStream fileStream =
                File.Create(@"C:\Users\lastm\source\repos\gclab16readwritenumbersfromtextfile\gclab16readwritenumbersfromtextfile\countries.txt"))
            using (StreamReader reader =
                new StreamReader(fileStream))
            {
                countryName = reader.ReadLine();
            }
            Console.WriteLine(countryName);

                //if (!File.Exists("countries.txt"))
                //{
                //else
                //{
                //    var CountryName = reader.ReadLine();
                //    Console.WriteLine(CountryName);
                //}
            }
        }

        public void CountryWriter()
        {
            using (StreamReader reader =
                new StreamReader(@"C:\Users\lastm\source\repos\gclab16readwritenumbersfromtextfile\gclab16readwritenumbersfromtextfile"))
            {
                if (!File.Exists("countries.txt"))
                {
                    using (StreamWriter writer =
                        new StreamWriter("countries.txt"))
                    {

                    }
                }
                else
                {
                    using (StreamWriter writer =
                        new StreamWriter("countries.txt"))
                    {
                        writer.Write("");
                        return;
                    }
                }
            }
        }
    }
}
        
