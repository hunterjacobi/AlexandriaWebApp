using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlexandriaWebApp.Shared.Models.Comment;

namespace AlexandriaWebApp.Server.Services.Comment
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentListItem>> GetAllCommentsAsync();
        Task<bool> CreateCommentAsync(CommentCreate model);
        Task<CommentDetail> GetCommentByIdAsync(int commentId);
        Task<bool> UpdateCommentsAsync(CommentEdit model);
        Task<bool> DeleteCommentAsync(int commentId);
        void SetUserId(string userId);
    }
}
