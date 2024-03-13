using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;

namespace RegularExpressions
{
    internal class RegexMethod
    {
      public void PatternMatching()
        {
            string name = "Munisekhar@123";
            string patten = "^[A-Z]{1}[a-z]{1,}[@ + _ $ ]{1}[0-9]{1,}$";

            Regex regex = new Regex(patten);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Correct Password");
            }
            else {
                Console.WriteLine("Enter correct Password");
            }
        }
        public void DateOfBirth()
        {
            string date = "2002-04-27";
            string pattern = "^[0-9]{4}-[0-9]{2}-[0-9]{1,2}";
            Match result = Regex.Match("2003-05-23", pattern);
            if (result.Success)
            {
                //Console.WriteLine("valid dateofbirth");
                string year= result.Groups[1].Value;
                string month = result.Groups[2].Value;
                string day = result.Groups[3].Value;
                Console.WriteLine("year:{0}",year);
            } else
            {
                Console.WriteLine("invalid dateofbirth");
            }
        }

    }
}
