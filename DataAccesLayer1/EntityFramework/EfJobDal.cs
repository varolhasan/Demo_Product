using DataAccesLayer1.Abstract;
using DataAccesLayer1.Repositories;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer1.EntityFramework
{
    public class EfJobDal :GenericRepository<Job>, IJobDal
    {
    }
}
