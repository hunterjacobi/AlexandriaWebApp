using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Server.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1,5)]
        public double Ratings { get; set; }
        [Required]
        public int NovelId { get; set; }
        public virtual Novel Novel { get; set; }
    }
}
