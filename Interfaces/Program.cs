namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interfacesintro();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());            


        }
        //private static void Interfacesintro()
        //{
        //    PersonManager manager = new PersonManager();
        //    Customer customer = new Customer
        //    {
        //        Id = 1,
        //        FirstName = "Engin",
        //        LastName = "Demirog",
        //        Address = "Ankara"
        //    };


        //    Student student = new Student
        //    {
        //        Id = 1,
        //        FirstName = "Derin",
        //        LastName = "Demirog",
        //        Departmant = "Computer Sciences"
        //    };

        //    manager.Add(student);
        //    manager.Add(customer);


        //}



    }
    // Interface : Soyut Nesne
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    // class : Somut Nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}