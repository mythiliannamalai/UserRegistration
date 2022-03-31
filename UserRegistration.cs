using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace patten
{
    internal class UserRegistration
    {
        public Regex FirstNames = new Regex(@"^[A-Z][A-Za-z]{3,}$");
        public void Firstnamein(string Firstname)
        {
            Console.WriteLine("First name :" + Firstname);
            if (FirstNames.IsMatch(Firstname))
            {
                Console.WriteLine(" Valid name..");
            }
            else
            {
                Console.WriteLine("invalid name...");
            }
        }
    }
}
