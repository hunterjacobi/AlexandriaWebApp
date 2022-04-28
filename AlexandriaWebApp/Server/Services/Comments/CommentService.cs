using System;
using AlexandriaWebApp.Server.Data;

namespace AlexandriaWebApp.Server.Services.Comments
{
    public class CommentService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
