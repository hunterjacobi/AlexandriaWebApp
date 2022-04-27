using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Shared.Models.Rating
{
    public class RatingEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(1, 5)]
        public double Ratings { get; set; }

        public int NovelId { get; set; }
    }
}
