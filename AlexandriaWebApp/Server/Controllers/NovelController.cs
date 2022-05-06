using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Services.Novels;
using AlexandriaWebApp.Shared.Models.Novel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexandriaWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovelController : Controller
    {
        private readonly INovelService _novelService;

        public NovelController(INovelService novelService)
        {
            _novelService = novelService;
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

            _novelService.SetUserId(userId);
            return true;
        }
        // GET: api/values
        // GET ALL NOVELS
        [HttpGet]
        public async Task<List<NovelListItem>> Index()
        {
            var novels = await _novelService.GetAllNovelsAsync();
            return novels.ToList();
        }

        //GET NOVELS BY HIGHEST RATING
        /*
        [HttpGet]
        public async Task<List<NovelListItem>> HighestRated()
        {
            var novels = await _novelService.GetNovelsByHighestRatingAsync();
            return novels.ToList();
        }
        */
        // GET NOVELS BY CATEGORY

        /*
        [HttpGet("{categoryid}")]
        public async Task<List<NovelListItem>> NovelsInCategory(int categoryid)
        {
            var novels = await _novelService.GetNovelsByCategoryIdAsync(categoryid);
            return novels.ToList();
        }
        */

        // GET api/values/5
        // GET NOVEL BY NOVEL ID
        [HttpGet("{id}")]
        public async Task<IActionResult> Novel(int id)
        {
            var novel = await _novelService.GetNovelByIdAsync(id);

            if (novel == null) return NotFound();

            return Ok(novel);
        }

        // POST api/values
        // CREATE A NOVEL
        [HttpPost]
        public async Task<IActionResult> Create(NovelCreate model)
        {
            if (model == null || !ModelState.IsValid) return BadRequest();

            if (!SetUserIdInService()) return Unauthorized();

            bool wasSuccessful = await _novelService.CreateNovelAsync(model);

            if (wasSuccessful) return Ok();
            else return UnprocessableEntity();
        }

        // PUT api/values/5
        // UPDATE NOVEL
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, NovelEdit model)
        {
            if (!SetUserIdInService()) return Unauthorized();

            if (model == null || !ModelState.IsValid) return BadRequest();

            if (model.Id != id) return BadRequest();

            bool wasSuccessful = await _novelService.UpdateNovelAsync(model);

            if (wasSuccessful) return Ok();
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var novel = await _novelService.GetNovelByIdAsync(id);
            if (novel == null) return NotFound();

            bool wasSuccessful = await _novelService.DeleteNovelAsync(id);

            if (!wasSuccessful) return BadRequest();

            return Ok();
        }
    }
}
