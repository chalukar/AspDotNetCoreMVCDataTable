using AspDotNetCoreMVCDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreMVCDataTable.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        Student GetById(int Id);

        void Save(Student oStudent);

        void Update(Student oStudent);

        string Delete(int Id);
 
    }
}
