using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Server.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OwnerId { get; set; }

        [Required]
        [Range(1,5)]
        public double Ratings { get; set; }

        public int NovelId { get; set; }
        public virtual Novel Novel { get; set; }
    }
}
