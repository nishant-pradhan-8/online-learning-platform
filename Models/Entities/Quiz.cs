
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_learning_platform.Models.Entities
{
    [Table("Quizzes")]
    public class Quiz
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // --- Foreign Key ---
        [Required]
        public int CourseId { get; set; }

        // --- Question & Options ---
        [Required]
        [MaxLength(500)]
        public string Question { get; set; }

        [Required]
        [MaxLength(255)]
        public string OptionA { get; set; }

        [Required]
        [MaxLength(255)]
        public string OptionB { get; set; }

        [Required]
        [MaxLength(255)]
        public string OptionC { get; set; }

        [Required]
        [MaxLength(255)]
        public string OptionD { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression("^[ABCD]$", ErrorMessage = "CorrectOption must be one of: A, B, C, D.")]
        public string CorrectOption { get; set; }

        // --- Timestamps ---
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        // --- Navigation Property ---
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
