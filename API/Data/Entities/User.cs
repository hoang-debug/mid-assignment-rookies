using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using API.Data.Entities;

namespace API.Data.Entities
{
   
        public class User : BaseEntity
    {
        [Required, MaxLength(50)]
        public string? Username { get; set; }= string.Empty;
        [Required]
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? Role { get; set; }
        public ICollection<BookBorrowingRequest>? BookBorrowingRequests { get; set; }
        public ICollection<BookBorrowingRequest>? ProcessedRequests { get; set; }
    }
}
