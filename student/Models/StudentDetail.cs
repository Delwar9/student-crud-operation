using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student.Models
{
    [Table("StudentDetail")]
    public class StudentDetail
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(10)]
        public string RollNumber { get; set; } = null!;
        [MaxLength(25)]
        public string? Country { get; set; }
    }
}
