using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Data;
using AlexandriaWebApp.Server.Models;
using AlexandriaWebApp.Shared.Models.Comment;
using Microsoft.EntityFrameworkCore;

namespace AlexandriaWebApp.Server.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCommentAsync(CommentCreate model)
        {
            var commentEntity = new Comment
            {
                OwnerId = _userId,
                Name = model.Name,
                Comments = model.Comments,
                IsReview = model.IsReview,
                NovelId = model.NovelId,
                CreatedUtc = DateTimeOffset.Now,
                UserRating = (from r in _context.Ratings where r.NovelId.Equals(model.NovelId) && r.OwnerId.Equals(_userId) select r.Ratings).ToList().Average()
            };

            _context.Comments.Add(commentEntity);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<bool> DeleteCommentAsync(int commentId)
        {
            var entity = await _context.Comments.FindAsync(commentId);
            if (entity?.OwnerId != _userId)
                return false;

            _context.Comments.Remove(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<CommentListItem>> GetAllCommentsAsync()
        {
            var commentQuery = _context
                .Comments
                .Select(n =>
                    new CommentListItem
                    {
                        Id = n.Id,
                        Name = n.Name,
                        Comments = n.Comments,
                        IsReview = n.IsReview,
                        Likes = n.Likes,
                        UserRating = (from r in _context.Ratings where r.NovelId.Equals(n.NovelId) && r.OwnerId.Equals(n.OwnerId) select r.Ratings).ToList().Average(),
                        NovelName = n.Novel.Title,
                        CreatedUtc = n.CreatedUtc,
                        ModifiedUtc = n.ModifiedUtc
                    });

            return await commentQuery.ToListAsync();
        }

        public async Task<IEnumerable<CommentListItem>> GetAllUsersCommentAsync()
        {
            var commentQuery = _context
                .Comments
                .Where(n => n.OwnerId == _userId)
                .Select(n =>
                    new CommentListItem
                    {
                        Id = n.Id,
                        Name = n.Name,
                        Comments = n.Comments,
                        IsReview = n.IsReview,
                        Likes = n.Likes,
                        UserRating = (from r in _context.Ratings where r.NovelId.Equals(n.NovelId) && r.OwnerId.Equals(n.OwnerId) select r.Ratings).ToList().Average(),
                        NovelName = n.Novel.Title,
                        CreatedUtc = n.CreatedUtc,
                        ModifiedUtc = n.ModifiedUtc
                    });

            return await commentQuery.ToListAsync();
        }

        public async Task<CommentDetail> GetCommentByIdAsync(int commentId)
        {
            var commentEntity = await _context
                .Comments
                .Include(nameof(Novel))
                .FirstOrDefaultAsync(c => c.Id == commentId);

            if (commentEntity is null)
                return null;

            var detail = new CommentDetail
            {
                Id = commentEntity.Id,
                Name = commentEntity.Name,
                Comments = commentEntity.Comments,
                IsReview = commentEntity.IsReview,
                Likes = commentEntity.Likes,
                UserRating = (from r in _context.Ratings where r.NovelId.Equals(commentEntity.NovelId) && r.OwnerId.Equals(commentEntity.OwnerId) select r.Ratings).ToList().Average(),
                NovelId = commentEntity.Novel.Id,
                NovelName = commentEntity.Novel.Title,
                CreatedUtc = commentEntity.CreatedUtc,
                ModifiedUtc = commentEntity.ModifiedUtc
            };

            return detail;
        }

        public Task<CommentDetail> GetCommentByNovelIdAsync(int novelId)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDetail> GetCommentIfTheyAreNovelReviewAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCommentsAsync(CommentEdit model)
        {
            if (model == null) return false;

            var entity = await _context.Comments.FindAsync(model.Id);

            if (entity?.OwnerId != _userId) return false;

            entity.Comments = model.Comments;
            entity.IsReview = model.IsReview;
            entity.ModifiedUtc = DateTimeOffset.Now;

            return await _context.SaveChangesAsync() == 1;
        }

        public void SetUserId(string userId) => _userId = userId;
    }
}
