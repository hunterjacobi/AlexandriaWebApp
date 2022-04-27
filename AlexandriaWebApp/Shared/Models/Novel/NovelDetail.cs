using System;
using System.Collections.Generic;
using AlexandriaWebApp.Shared.Models.Comment;

namespace AlexandriaWebApp.Shared.Models.Novel
{
    public class NovelDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double? AverageRating { get; set; }
        public List<CommentListItem>? Comments { get; set; }
    }
}
