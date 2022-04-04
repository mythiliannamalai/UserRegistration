namespace patten
{
    class Program
    {
        static void Main(string[]args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the First name :");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Enter the Last name :");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Enter the Email id :");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter the Phone number :");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Password :");
            string PassWord = Console.ReadLine();
            Console.WriteLine("Enter the any email patten :");
            string AllEmail=Console.ReadLine();
            userRegistration.Firstnamein(Firstname);
            userRegistration.Lastenamein(Lastname);
            userRegistration.Emails(Email);
            userRegistration.PhoneNumbers(PhoneNumber);
            userRegistration.PassWords(PassWord);
            userRegistration.AllEmails(AllEmail);
        }
    }
}