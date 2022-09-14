using DataAccesLayer1.Abstract;
using DataAccesLayer1.Concrete;
using DataAccesLayer1.Repositories;
using EntityLayer1.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer1.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (var c = new Context())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}
