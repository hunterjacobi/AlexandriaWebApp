using System;
namespace AlexandriaWebApp.Shared.Models.Comment
{
    public class CommentListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public bool IsReview { get; set; }
        public int? Likes { get; set; }
        public double? UserRating { get; set; }
        public string NovelName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
