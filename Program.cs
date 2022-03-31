namespace patten
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
            userRegistration.Firstnamein(Firstname);
            userRegistration.Lastenamein(Lastname);
        }
    }
}