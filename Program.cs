﻿namespace patten
{
    class Program
    {
        static void Main(string[]args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the First name :");
            string Firstname=Console.ReadLine();
            Console.WriteLine("Enter the Last name :");
            string Lastname=Console.ReadLine();
            Console.WriteLine("Enter the Email id :");
            string Email=Console.ReadLine();
            Console.WriteLine("Enter the Phone number :");
            string PhoneNumber = Console.ReadLine();
            userRegistration.Firstnamein(Firstname);
            userRegistration.Lastenamein(Lastname);
            userRegistration.Emails(Email);
            userRegistration.PhoneNumbers(PhoneNumber);
        }
    }
}