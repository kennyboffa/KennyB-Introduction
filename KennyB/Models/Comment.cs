using System.ComponentModel.DataAnnotations;

namespace KennyB.Models
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}