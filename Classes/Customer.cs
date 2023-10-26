

namespace Classes
{
    internal class Customer
    {
        //Property
        public int Id { get; set; }

        private string _firstname ;
        public string FirstName
        {
            get{ return "Mr." + _firstname; }
            set{ _firstname = value; }
        }
        public string LastName { get; set; }
        public string City {  get; set; }
    }
}
