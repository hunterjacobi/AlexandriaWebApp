using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Shared.Models.Comment
{
    public class CommentEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public bool IsReview { get; set; }
        public int NovelId { get; set; }
    }
}
