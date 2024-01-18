using Oxer.Core.Entities;
using Oxer.Core.Repositories;
using Oxer.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IstudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
