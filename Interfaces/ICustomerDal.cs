using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
        
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql deleted");

        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sql updated");

        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle deleted");

        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle updated");

        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
