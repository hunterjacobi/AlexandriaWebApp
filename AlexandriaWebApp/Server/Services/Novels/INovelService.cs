using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlexandriaWebApp.Shared.Models.Novel;

namespace AlexandriaWebApp.Server.Services.Novels
{
    public interface INovelService
    {
        Task<IEnumerable<NovelListItem>> GetAllNovelsAsync();
        Task<bool> CreateNovelAsync(NovelCreate model);
        Task<NovelDetail> GetNovelByIdAsync(int novelId);
        Task<IEnumerable<NovelListItem>> GetNovelsByCategoryIdAsync(int categoryId);
        Task<IEnumerable<NovelListItem>> GetNovelsByHighestRatingAsync();
        Task<bool> UpdateNovelAsync(NovelEdit model);
        Task<bool> DeleteNovelAsync(int novelId);
        void SetUserId(string userId);
    }
}
