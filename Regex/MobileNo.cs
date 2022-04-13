using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class MobileNo
    {
        public static string Enter_MobileNo = "[0-9]{10}";

        public bool ValidNo(string no)
        {
            return Regex.IsMatch(no, Enter_MobileNo);


        }
        public static void MyNo()
        {
            MobileNo enterno = new MobileNo();


            Console.WriteLine("Enter the number");
            string value = Console.ReadLine();
            bool match = enterno.ValidNo(value);

            if (match)
                Console.WriteLine("No match");
            else
                Console.WriteLine("No not match");
        }
    }
}
