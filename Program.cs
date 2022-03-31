namespace patten
{
    class Program
    {
        static void Main(string[]args)
        {
            Patten patten = new Patten();
            Console.WriteLine("Enter the First name :");
            string Firstname=Console.ReadLine();
            patten.Firstnamein(Firstname);           
        }
    }
}