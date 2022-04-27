using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlexandriaWebApp.Shared.Models.Novel;

namespace AlexandriaWebApp.Server.Services.Novels
{
    public interface INovelService
    {
        Task<IEnumerable<NovelListItem>> GetAllNovelsAsync();
        Task<bool> CreateNovelAsync(NovelCreate model);
        Task<NovelDetail> GetNovelByIdAsync(int novelId);
        Task<bool> UpdateNovelAsync(NovelEdit model);
        Task<bool> DeleteNovelAsync(int novelId);
        void SetUserId(string userId);
    }
}
