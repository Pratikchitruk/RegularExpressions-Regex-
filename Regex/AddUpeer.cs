using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
   public class AddUpeer
    {
        public static string Enter_Password = "[0-9]{8}[@]{1}[A-Z]{1}";

        public bool ValidNo(string no)
        {
            return Regex.IsMatch(no, Enter_Password);


        }
        public static void AddUpperPassword()
        {
            MobileNo enterno = new MobileNo();


            Console.WriteLine("Enter the Password");
            string value = Console.ReadLine();
            bool match = enterno.ValidNo(value);

            if (match)
                Console.WriteLine("No match");
            else
                Console.WriteLine("No not match");
        }
    }
}
