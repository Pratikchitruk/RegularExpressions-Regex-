using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class EnterLastName
    {
        public static string Enter_Name = "[a-z]{3}";

        public bool ValidName(string name)
        {
            return Regex.IsMatch(name, Enter_Name);
        }
        public static void LastName()
        {
            EnterLastName enterlastname = new EnterLastName();


            Console.WriteLine("Enter the Last name");
            string value = Console.ReadLine();
            bool match = enterlastname.ValidName(value);

            if (match)
                Console.WriteLine("name match");
            else
                Console.WriteLine("name not math");

        }
    }

}
