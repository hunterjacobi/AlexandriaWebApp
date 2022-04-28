using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlexandriaWebApp.Shared.Models.Comment;

namespace AlexandriaWebApp.Server.Services.Comments
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentListItem>> GetAllCommentsAsync();
        Task<IEnumerable<CommentListItem>> GetAllUsersCommentAsync();
        Task<bool> CreateCommentAsync(CommentCreate model);
        Task<CommentDetail> GetCommentByIdAsync(int commentId);
        Task<IEnumerable<CommentListItem>> GetCommentByNovelIdAsync(int novelId);
        Task<IEnumerable<CommentListItem>> GetCommentIfTheyAreNovelReviewAsync(int novelId);
        Task<bool> UpdateCommentsAsync(CommentEdit model);
        Task<bool> DeleteCommentAsync(int commentId);
        void SetUserId(string userId);
    }
}
