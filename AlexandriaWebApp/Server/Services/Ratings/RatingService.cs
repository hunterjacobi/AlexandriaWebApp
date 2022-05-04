using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Data;
using AlexandriaWebApp.Server.Models;
using AlexandriaWebApp.Shared.Models.Rating;
using Microsoft.EntityFrameworkCore;

namespace AlexandriaWebApp.Server.Services.Ratings
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;

        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateRatingAsync(RatingCreate model)
        {
            var ratingEntity = new Rating
            {
                OwnerId = _userId,
                Ratings = model.Ratings
            };

            _context.Ratings.Add(ratingEntity);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<bool> DeleteRatingAsync(int ratingId)
        {
            var entity = await _context.Ratings.FindAsync(ratingId);
            if (entity?.OwnerId != _userId)
                return false;

            _context.Ratings.Remove(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<RatingListItem>> GetAllRatingsByUserAsync()
        {
            var ratingQuery = _context
                .Ratings
                .Where(r => r.OwnerId == _userId)
                .Select(r =>
                new RatingListItem
                {
                    Id = r.Id,
                    Ratings = r.Ratings,
                    NovelName = r.Novel.Title
                });

            return await ratingQuery.ToListAsync();
        }

        public async Task<RatingDetail> GetRatingByIdAsync(int ratingId)
        {
            var ratingEntity = await _context
                .Ratings
                .Include(nameof(Novel))
                .FirstOrDefaultAsync(r => r.Id == ratingId);

            if (ratingEntity is null)
                return null;

            var detail = new RatingDetail
            {
                Id = ratingEntity.Id,
                Ratings = ratingEntity.Ratings,
                NovelId = ratingEntity.Novel.Id,
                NovelName = ratingEntity.Novel.Title
            };

            return detail;
        }

        public async Task<bool> UpdateRatingAsync(RatingEdit model)
        {
            if (model == null) return false;

            var entity = await _context.Ratings.FindAsync(model.Id);
            if (entity?.OwnerId != _userId) return false;

            entity.Ratings = model.Ratings;
            entity.NovelId = model.NovelId;
            entity.Novel.Title = model.NovelName;

            return await _context.SaveChangesAsync() == 1;
        }

        public void SetUserId(string userId) => _userId = userId;
    }
}
