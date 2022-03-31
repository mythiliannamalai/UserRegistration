namespace patten
{
    class Program
    {
        static void Main(string[]args)
        {
            UserRegistration patten = new UserRegistration();
            Console.WriteLine("Enter the First name :");
            string Firstname=Console.ReadLine();
            patten.Firstnamein(Firstname);           
        }
    }
}