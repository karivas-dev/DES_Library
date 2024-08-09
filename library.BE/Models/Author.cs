using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace library.BE.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Apellido")]
        public string Lastname { get; set; }
    }
}
