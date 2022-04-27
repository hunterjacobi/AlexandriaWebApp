using System;
namespace AlexandriaWebApp.Shared.Models.Rating
{
    public class RatingDetail
    {
        public int Id { get; set; }
        public double Ratings { get; set; }
        public int NovelId { get; set; }
        public string NovelName { get; set; }
    }
}
