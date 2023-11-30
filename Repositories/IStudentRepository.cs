using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Students> GetAll();
        Students GetById(int id);
    }
}