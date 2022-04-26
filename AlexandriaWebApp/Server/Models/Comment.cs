using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Server.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public bool IsReview { get; set; }

        public int Likes { get; set; }

        public double UserRating { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
