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
        public Regex LastNames = new Regex(@"^[A-z][A-Za-z]{3,}$");
        public Regex EmailReg = new Regex(@"^[a-z](.[a-z])+@[a-z]+.[a-z]{3}(.[a-z]{2})$");
        public Regex PhoneNumberReg = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PassWordReg = new Regex(@"^[A-Z]@[0-9][A-Za-z]{8,}$");
        public Regex AllEmailReg = new Regex(@"^[a-z]((.-+){1})([0-9]{3})+@([0-9]{1})([a-z]{,5})+.[a-z]{3}(.[a-z]{2,})$");
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
        public void PhoneNumbers(string PhoneNumber)
        {
            Console.WriteLine("Email id :" + PhoneNumber);
            if (PhoneNumberReg.IsMatch(PhoneNumber))
                Console.WriteLine(" Valid Phone number..");
            else
                Console.WriteLine("invalid Phone number...");
        }
        public void PassWords(string PassWord)
        {
            Console.WriteLine("Password :" + PassWord);
            if (PassWordReg.IsMatch(PassWord))
                Console.WriteLine(" Valid Password..");
            else
                Console.WriteLine("invalid Password...");
        }
        public void AllEmails(string AllEmail)
        {
            Console.WriteLine("All patten Email id :" + AllEmail);
            if (AllEmailReg.IsMatch(AllEmail))
                Console.WriteLine(" Valid Emali patten..");
            else
                Console.WriteLine("invalid Email patten...");
        }
    }
}
