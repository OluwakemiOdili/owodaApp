namespace owodaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Owoda");
            Console.WriteLine();

            Owoda app = new Owoda();
            Admin admin = new Admin();

            app.PricePerTrip();

            Console.WriteLine("The below calculate for 10 Random Drivers");
            Console.WriteLine();
            admin.TotalAmountForTenDrivers();
        }
    }
}