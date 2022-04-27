using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Data;
using AlexandriaWebApp.Server.Models;
using AlexandriaWebApp.Shared.Models.Novel;
using Microsoft.EntityFrameworkCore;

namespace AlexandriaWebApp.Server.Services.Novels
{
    public class NovelService : INovelService
    { 
        private readonly ApplicationDbContext _context;
        private string _userId;
        public NovelService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateNovelAsync(NovelCreate model)
        {
            var novelEntity = new Novel
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            _context.Novels.Add(novelEntity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public Task<bool> DeleteNovelAsync(int novelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NovelListItem>> GetAllNovelsAsync()
        {
            // Dear future self, Below I queried the novels to get the novel id and store it
            // into a novelId var, I then plugged novelId into ratings Var to only select ratings
            // where the novelId is equal to the ratings NovelId, and pulled it into the
            // NovelListItem to calculate the average of the ratings.
            // I hope it returns a double and not a whole number!
            //var novelId = _context.Novels.Select(n => n.Id);
            //var ratings = (from r in _context.Ratings where r.NovelId.Equals(novelId) select r).ToList();

            // I do not even remember what i was trying, sorry.
            //var novelRating = from n in _context.Novels
            //                  join y in _context.Ratings on n.Id equals y.NovelId into z
              //                from r in z
                //              group r by r.NovelId into g
                  //            select new
                    //          {
                      //            AvgRating = g.Average(r=>r.Ratings)
                        //      };
            var novelQuery = _context.Novels.Select(n =>
            new NovelListItem
            {
                Id = n.Id,
                Title = n.Title,
                Author = n.Author,
                CategoryName = n.Category.Name,
                AverageRating = (from r in _context.Ratings where r.NovelId.Equals(n.Id) select r.Ratings).ToList().Average()
                //AverageRating = (from r in ratings select r.Ratings).Average()
                //AverageRating = AvgRating
            }) ;

            return await novelQuery.ToListAsync();
        }

        public Task<NovelDetail> GetNovelByIdAsync(int novelId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNovelAsync(NovelEdit model)
        {
            throw new NotImplementedException();
        }

        public void SetUserId(string userId) => _userId = userId;
    }

}
