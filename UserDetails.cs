using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegularExpressions
{
    internal class UserDetails
    {
        public void FirstName() 
        {
            string firstName = "Munisekhar";
            string partten = "^[A-Z]{1}[a-z]{2,}$";
            var result = Regex.IsMatch(firstName, partten);
            if (result)
            {
                Console.WriteLine("Valid FirstName");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }
        }
        public void LastName()
        {
            string lastName = "Billu";
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            var result = Regex.IsMatch(lastName, pattern);
            if (result)
            {
                Console.WriteLine("Valid lastName");
            }
            else
            {
                Console.WriteLine("Invalid lastName");
            }
        }
        public void EmailId()
        {
            string email = "abc.xyz@b1.co.in";
            string patterns = "^[A-Za-z]+[.]?[A-Za-z]?[A-Za-z0-9]+[.][A-Za-z]{2}[.]?[a-zA-Z]?$";
            //string pattern1 = " ^([a - zA - Z] +)\.([a - zA - Z0 - 9] +)@([a - zA - Z0 - 9] +)\.([a - zA - Z] +)$";
            var result = Regex.IsMatch(email, patterns);
            if (result)
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
        }
        public void MobileNumber()
        {
            string number= "91 6304796656";
            string pattern = "^[9][1][ ][986]{1}[0-9]{9}$";
            var result = Regex.IsMatch(number, pattern);
            if (result)
            {
                Console.WriteLine("Valid Number");
            }
            else
            { 
                 Console.WriteLine("Invalid number");
            }

        }
        public void Password()
        {
            string password = "Munisekhar@123";
            string pattern = "^[A-Z][A-Za-z]{2,}[@][1-9]{2,}$";

            var result = Regex.IsMatch(password, pattern);
            if (result)
            {
                Console.WriteLine("Valid passward");
            }
            else
            {
                Console.WriteLine("Invalid passward");
            }


        }
    }
}
