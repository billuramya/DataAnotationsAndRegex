using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;
using RegularExpressions;
 namespace FunctonCall
{
    class ProgramCalling
    {
        public static void Main(string[] args)
        {
            RegexMethod r = new RegexMethod();
            r.PatternMatching();
            r.DateOfBirth();
            UserDetails userDetails = new UserDetails();
            userDetails.FirstName();
            userDetails.LastName();
            userDetails.EmailId();
            userDetails.MobileNumber();
            userDetails.Password();
        }   

    }
}