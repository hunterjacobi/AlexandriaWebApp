using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Services.Comments;
using AlexandriaWebApp.Shared.Models.Comment;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexandriaWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        private string GetUserId()
        {
            string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

            if (userIdClaim == null) return null;

            return userIdClaim;
        }

        private bool SetUserIdInService()
        {
            var userId = GetUserId();
            if (userId == null) return false;

            _commentService.SetUserId(userId);
            return true;
        }
        // GET: api/values
        // GET ALL COMMENTS
        [HttpGet]
        public async Task<List<CommentListItem>> Index()
        {
            var comments = await _commentService.GetAllCommentsAsync();
            return comments.ToList();
        }

        // GET ALL USERS COMMENTS
        [HttpGet]
        public async Task<List<CommentListItem>> UserComments()
        {
            if (!SetUserIdInService()) return new List<CommentListItem>();

            var comments = await _commentService.GetAllUsersCommentAsync();
            return comments.ToList();
        }

        // GET api/values/5
        // GET COMMENT BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> Comment(int id)
        {
            var comment = await _commentService.GetCommentByIdAsync(id);

            if (comment == null) return NotFound();

            return Ok(comment);
        }

        // GET COMMENTS BY NOVEL ID
        [HttpGet("{id}")]
        public async Task<IActionResult> NovelComments(int id)
        {
            var comments = await _commentService.GetCommentByNovelIdAsync(id);
            if (comments == null) return NotFound();
            return Ok(comments.ToList());
        }


        // GET COMMENT IF IT IS A NOVEL REVIEW
        [HttpGet("{id}")]
        public async Task<IActionResult> NovelReviews(int id)
        {
            var comments = await _commentService.GetCommentIfTheyAreNovelReviewAsync(id);
            if (comments == null) return NotFound();
            return Ok(comments.ToList());
        }


        // POST api/values
        // CREATE A COMMENT
        [HttpPost]
        public async Task<IActionResult> Create(CommentCreate model)
        {
            if (model == null) return BadRequest();
            if (!SetUserIdInService()) return Unauthorized();

            bool wasSuccessful = await _commentService.CreateCommentAsync(model);

            if (wasSuccessful) return Ok();
            else return UnprocessableEntity();
        }

        // PUT api/values/5
        //UPDATE A COMMENT
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, CommentEdit model)
        {
            if (!SetUserIdInService()) return Unauthorized();
            if (model == null || !ModelState.IsValid) return BadRequest();

            if (model.Id != id) return BadRequest();

            bool wasSuccessful = await _commentService.UpdateCommentsAsync(model);

            if (wasSuccessful) return Ok();
            return BadRequest();
        }

        // DELETE api/values/5
        // DELETE A COMMENT
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();
            var comment = await _commentService.GetCommentByIdAsync(id);
            if (comment == null) return NotFound();

            bool wasSuccessful = await _commentService.DeleteCommentAsync(id);

            if (!wasSuccessful) return BadRequest();
            return Ok();
        }
    }
}
