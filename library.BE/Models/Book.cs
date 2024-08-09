using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace library.BE.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [DisplayName("Título del libro")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Fecha de publicación")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [Required]
        [DisplayName("Nombre del autor")]
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }

        [Required]
        [DisplayName("Categoría")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
