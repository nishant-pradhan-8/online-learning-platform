using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_learning_platform.Models.Entities
{
    [Table("Enrollments")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // --- Foreign Keys ---
        [Required]
        public int UserId { get; set; }

        [Required]
        public int CourseId { get; set; }

        // --- Other Columns ---
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateEnrolled { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        // --- Navigation Properties ---
        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
