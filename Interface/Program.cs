namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());


        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {

        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {

            Console.WriteLine("çalışan eklendi");
        }

        public void Update()
        {
            Console.WriteLine("çalışan güncellendi");
        }
    }

    class InternManager : IPersonManager
    {

        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }


    class ProjectManager
    {

        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }



    }
}