using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
  public class EnterFirstName
    {
        public static string Enter_Name = "[a-z]{3}";

        public bool ValidName(string name)
        {
            return Regex.IsMatch(name, Enter_Name);
        }

        public static void FirstName()
        {
            EnterFirstName entername = new EnterFirstName();


            Console.WriteLine("Enter the First name");
            string value = Console.ReadLine();
            bool match = entername.ValidName(value);

            if (match)
                Console.WriteLine("name match");
            else
                Console.WriteLine("name not math");


        }
    }
}
