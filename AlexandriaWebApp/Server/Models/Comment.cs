using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Server.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public bool IsReview { get; set; }

        public int? Likes { get; set; }
        public double? UserRating { get; set; }

        public int NovelId { get; set; }
        public virtual Novel Novel { get; set; }
    }
}
