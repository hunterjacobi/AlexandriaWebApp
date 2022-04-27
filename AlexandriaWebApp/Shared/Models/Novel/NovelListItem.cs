using System;
namespace AlexandriaWebApp.Shared.Models.Novel
{
    public class NovelListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CategoryName { get; set; }
        public double? AverageRating { get; set; }
    }
}
