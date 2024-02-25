namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerl = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara" };
            Customer customer3 = new Customer(); customer3.Id = 3;
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public Customer()
        {
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}