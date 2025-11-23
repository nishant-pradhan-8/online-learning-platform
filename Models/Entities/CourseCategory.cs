using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_learning_platform.Models.Entities
{
    [Table("CourseCategories")]
    public class CourseCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // --- Foreign Keys ---
        [Required]
        public int CourseId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // --- Navigation Properties ---
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
