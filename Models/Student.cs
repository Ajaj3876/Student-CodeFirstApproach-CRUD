using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore.Models
{
    public class Student
    {
        [Key]
        public  int Id { get; set; }

        [Column("Student Name", TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("Student Gender", TypeName = "varchar(30)")]
        [Required]
        public string Gender { get; set; }

        [Required]
        public int? Age { get; set; }

        [Required]
        public int? Standard { get; set; }

    }
}
