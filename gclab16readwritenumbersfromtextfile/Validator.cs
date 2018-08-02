using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab16readwritenumbersfromtextfile
{
    class Validator
    {
        public static int? IsNumValid (string choiceFromUser)
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
