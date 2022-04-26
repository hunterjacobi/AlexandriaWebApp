using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlexandriaWebApp.Shared.Models.Rating;

namespace AlexandriaWebApp.Server.Services.Rating
{
    public interface IRatingService
    {
        Task<IEnumerable<RatingListItem>> GetAllRatingsAsync();
        Task<bool> CreateRatingAsync(RatingCreate model);
        Task<RatingDetail> GetRatingByIdAsync(int ratingId);
        Task<bool> UpdateRatingAsync(RatingEdit model);
        Task<bool> DeleteRatingAsync(int ratingId);
        void SetUserId(string userId);
    }
}
