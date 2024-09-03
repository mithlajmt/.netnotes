using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.contexts
{
    public class EmpContext :DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }

    }
}
