namespace MockGameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Genre> Genre { get; set; }
        public DateOnly ReleaseDate { get; set; }

    }
}
