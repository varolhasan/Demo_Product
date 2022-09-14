using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer1.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
        List<Customer> GetCustomerListWithJob();
    }
}
