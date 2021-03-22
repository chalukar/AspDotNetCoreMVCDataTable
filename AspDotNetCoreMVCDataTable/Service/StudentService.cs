using AspDotNetCoreMVCDataTable.Data;
using AspDotNetCoreMVCDataTable.IService;
using AspDotNetCoreMVCDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreMVCDataTable.Service
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _db;

        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public string Delete(int Id)
        {
            var student = _db.Students.FirstOrDefault(x => x.Id == Id);
            if(student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();

            }
            return "Delete";
        }

        public Student GetById(int Id)
        {
            return _db.Students.SingleOrDefault(x => x.Id == Id);
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }

        public void Save(Student oStudent)
        {
            _db.Students.Add(oStudent);
            _db.SaveChanges();

        }

        public void Update(Student oStudent)
        {
            _db.Students.Update(oStudent);
            _db.SaveChanges();
        }
    }
}
