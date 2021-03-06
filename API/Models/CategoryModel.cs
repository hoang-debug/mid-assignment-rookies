using System.ComponentModel.DataAnnotations;
using API.Models.Dtos;

namespace API.Models
{
    public class CategoryCreateModel
    {
        [Required, MaxLength(50)]
        public string? Name { get; set; }
        public IEnumerable<BookCreateDto>? Books { get; set; }

    }

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<BookViewDto>? Books { get; set; }
    }

    public class CategoryEditModel
    {
        [Required, MaxLength(50)]
        public string? Name { get; set; }

    }

}
