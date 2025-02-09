﻿namespace MockGameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<String> Genre { get; set; } = [];
        public DateOnly ReleaseDate { get; set; }

    }
}
