using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace library.BE.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Nombre de la categoría")]
        public string Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
