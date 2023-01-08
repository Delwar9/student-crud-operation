using Microsoft.EntityFrameworkCore;

namespace student.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        { 
            
        }
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentDetail> StudentDetails { get; set; } = null!;
    }
}
