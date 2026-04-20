namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Content { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
