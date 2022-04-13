using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
   public class Email
    {
        public static string Enter_Email = "[a-z]{6}[.]{1}[a-z]{7}[@]{1}[a-z]{5}[.]{1}[a-z]{3}";

        public bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, Enter_Email);


        }
        public static void MyEmail()
        {
            Email enteremail = new Email();


            Console.WriteLine("Enter the Email");
            string value = Console.ReadLine();
            bool match = enteremail.ValidEmail(value);

            if (match)
                Console.WriteLine("email match");
            else
                Console.WriteLine("email not math");

        }
    }
}
