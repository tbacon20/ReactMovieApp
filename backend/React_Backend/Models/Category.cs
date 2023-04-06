using System.ComponentModel.DataAnnotations;

namespace React_Backend.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string? CategoryName { get; set; }
    }
}
