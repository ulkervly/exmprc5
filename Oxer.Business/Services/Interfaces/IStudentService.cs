using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oxer.Core.Entities;
using Oxer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.Services.Interfaces
{
    public interface IStudentService
    {
        Task CreateAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int Id);
        Task<Student> GetByExpressionAsync(Expression<Func<Student,bool>>?expression=null,params string[]? includes);
        Task<List<Student>> GetAllAsync(Expression<Func<Student, bool>>? expression = null, params string[]? includes);
        

    }
}
