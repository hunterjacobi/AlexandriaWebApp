using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Server.Models
{
    public class Novel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public double AverageRating { get; set; }
        public virtual Rating Rating { get; set; }

        public string Comments { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
