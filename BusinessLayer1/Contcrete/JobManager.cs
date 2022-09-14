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
    public class JobManager : IJobService
    {
        IJobDal _IJobDal;

        public JobManager(IJobDal ıJobDal)
        {
            _IJobDal = ıJobDal;
        }

        public void TDelete(Job t)
        {
            _IJobDal.Delete(t);
        }

        public Job TGetById(int id)
        {
            return _IJobDal.GetById(id);
        }

        public List<Job> TGetList()
        {
            return _IJobDal.GetList();
        }

        public void TInsert(Job t)
        {
            _IJobDal.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _IJobDal.Update(t);
        }
    }
}
