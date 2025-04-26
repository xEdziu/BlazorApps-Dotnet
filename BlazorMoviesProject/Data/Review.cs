﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorMoviesProject.Data
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        [Range(0, 5)]
        public float Rating { get; set; }

        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        [Required]
        public Movie Movie { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}
