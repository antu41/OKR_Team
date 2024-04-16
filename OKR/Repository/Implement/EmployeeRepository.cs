using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class EmployeeRepository : MainRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
