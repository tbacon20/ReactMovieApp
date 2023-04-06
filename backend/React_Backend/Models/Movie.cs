﻿using System.ComponentModel.DataAnnotations;

namespace React_Backend.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }

        //public static readonly string[] Options = new string[] { "G", "PG", "PG-13", "R"};
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1900, 2023, ErrorMessage = "The year must be between 1900 and 2023.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        [DataType(DataType.Text, ErrorMessage = "The Director must be the name of the director.")]
        public string? Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [RegularExpression(@"^(G|PG|PG-13|R)$", ErrorMessage = "Please select a rating")]
        public string? Rating { get; set; }

        [RegularExpression(@"^(Yes|No)$", ErrorMessage = "Please select a rating")]
        public string? Edited { get; set; }

        public string? Lent { get; set; }

        [StringLength(25, ErrorMessage = "The string must be 25 characters or less.")]
        public string? Notes { get; set; }


        // Connecting to the Categories Model
        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
