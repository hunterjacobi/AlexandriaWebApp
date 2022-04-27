using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Shared.Models.Novel
{
    public class NovelCreate
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
