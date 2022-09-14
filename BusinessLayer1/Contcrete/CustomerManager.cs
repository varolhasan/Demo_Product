using BusinessLayer1.Abstract;
using DataAccesLayer1.Abstract;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1.Contcrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _ICustomerDal;

        public CustomerManager(ICustomerDal ıCustomerDal)
        {
            _ICustomerDal = ıCustomerDal;
        }

        public Customer TGetById(int id)
        {
            return _ICustomerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _ICustomerDal.GetList();
        }

        public void TDelete(Customer t)
        {
            _ICustomerDal.Delete(t);
        }

        public void TInsert(Customer t)
        {
            _ICustomerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _ICustomerDal.Update(t);
        }

        public List<Customer> GetCustomersListWithJob()
        {
           return _ICustomerDal.GetCustomerListWithJob();
        }
    }
}
