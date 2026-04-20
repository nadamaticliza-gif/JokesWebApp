using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JokesWebApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Text { get; set; } = string.Empty;

        public DateTime PostedDate { get; set; } = DateTime.Now;

        public string? UserName { get; set; }

        // Foreign key to Joke
        public int JokeId { get; set; }
        public Joke? Joke { get; set; }
    }
}