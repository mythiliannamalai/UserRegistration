﻿using System;
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
        public Regex LastNames = new Regex(@"^[A-z][A-Za-z]{3,}$");
        public Regex EmailReg = new Regex(@"^[a-z](.[a-z])+@[a-z]+.[a-z](.[a-z])$");
        public void Firstnamein(string Firstname)
        {
            Console.WriteLine("First name :" + Firstname);
            if (FirstNames.IsMatch(Firstname))
                Console.WriteLine(" Valid name..");
            else
                Console.WriteLine("invalid name...");
        }
        public void Lastenamein(string Lastname)
        {
            Console.WriteLine("Last name :" + Lastname);
            if (LastNames.IsMatch(Lastname))
                 Console.WriteLine(" Valid name..");
            else
                 Console.WriteLine("invalid name...");
        }
        public void Emails(string Email)
        {
            Console.WriteLine("Email id :" + Email);
            if (EmailReg.IsMatch(Email))
                Console.WriteLine(" Valid Email..");
            else
                Console.WriteLine("invalid Email...");
        }
    }
}
