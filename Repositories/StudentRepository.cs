using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Students> _student = new List<Students>
        {
            new Students { StudentId = 1, Name = "Bryan Nicholas", Email = "bryannicholas@gmail.com", BirthDate = new DateOnly(2003, 5, 9) },
            new Students { StudentId = 2, Name = "Bram Bishamon", Email = "bishamon@gmail,com", BirthDate = new DateOnly(1997,2,4) },
            new Students { StudentId = 3, Name = "Akiyoshi J Bishamon", Email = "akiyoshi@gmail.com", BirthDate = new DateOnly(1994,6,9) },
        };
        public IEnumerable<Students> GetAll()
        {
            return _student;
        }

        public Students GetById(int id)
        {
            return _student.First(s => s.StudentId == id);
        }
    }
}