using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Shared.Models.Rating
{
    public class RatingCreate
    {
        [Required]
        [Range(1, 5)]
        public double Ratings { get; set; }
        [Required]
        public int NovelId { get; set; }
    }
}
