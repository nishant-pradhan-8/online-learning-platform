
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_learning_platform.Models.Entities
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }  

        [MaxLength(255)]
        public string VideoUrl { get; set; }

        [MaxLength(255)]
        public string ThumbnailUrl { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseCategory> CourseCategories { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<QuizResult> QuizResults { get; set; }
        public ICollection<Review> Reviews { get; set; }

      
    }
}
