using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Oxer.Business.Exceptions;
using Oxer.Business.FileManger;
using Oxer.Business.Services.Interfaces;
using Oxer.Core.Entities;
using Oxer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IstudentRepository _studentRepository;
        private readonly IWebHostEnvironment _env;

        public StudentService(IstudentRepository studentRepository,IWebHostEnvironment env)
        {
            _studentRepository = studentRepository;
            _env = env;
        }
        public async Task CreateAsync(Student student)
        {
            if (student == null) throw new NullReferenceException();
            if (student.ImageFile.ContentType!="image/jpeg" && student.ImageFile.ContentType!="image/png")
            {
                throw new StudentInvalidImage("ImageFile","Image must be jpeg or png");
            }
            if (student.ImageFile.Length>2077574)
            {
                throw new StudentInvalidImage("ImageFile","Image must be lower 2 mb");
            }
            student.ImageUrl =student.ImageFile.SaveFile(_env.WebRootPath, "uploads/students");
          
            student.CreatedTime = DateTime.UtcNow;
            student.UpdatedTime = DateTime.UtcNow;
            await _studentRepository.CreateAsync(student);
            await _studentRepository.CommitAsync();

        }

        public async Task DeleteAsync(int Id)
        {
            if (Id<0) throw new NullReferenceException();
            var student = await _studentRepository.GetSingleAsync(x=>x.Id==Id);
            if (student is null) 
            {
                throw new StudentNotFound();
            }
            _studentRepository.Delete(student);
            await _studentRepository.CommitAsync();
        }

        public async Task<List<Student>> GetAllAsync(Expression<Func<Student, bool>>? expression = null, params string[]? includes)
        {
            return await _studentRepository.GetAllWhere(expression, includes).ToListAsync();
         }

       

        public async Task<Student> GetByExpressionAsync(Expression<Func<Student, bool>>? expression = null, params string[]? includes)
        {
           return await _studentRepository.GetSingleAsync(expression,includes);
        }

        

        public async Task UpdateAsync(Student student)
        {
            if (student == null) throw new NullReferenceException();
            var existstudent=await _studentRepository.GetSingleAsync(x=>x.Id==student.Id);
            if (student.ImageFile.ContentType != "image/jpeg" && student.ImageFile.ContentType != "image/png")
            {
                throw new StudentInvalidImage("ImageFile", "Image must be jpeg or png");
            }
            if (student.ImageFile.Length > 2077574)
            {
                throw new StudentInvalidImage("ImageFile", "Image must be lower 2 mb");
            }
            Helper.DeleteFile(_env.WebRootPath,"uploads/students",existstudent.ImageUrl);
            existstudent.ImageUrl = student.ImageFile.SaveFile(_env.WebRootPath,"uploads/students");


            existstudent.Description = student.Description;
            existstudent.ImageUrl = student.ImageUrl;
            existstudent.Name = student.Name;
            existstudent.UpdatedTime = DateTime.UtcNow;
            await _studentRepository.CommitAsync();

        }
    }
}
