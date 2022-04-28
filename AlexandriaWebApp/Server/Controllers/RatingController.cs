using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Services.Ratings;
using AlexandriaWebApp.Shared.Models.Rating;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexandriaWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
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

            _ratingService.SetUserId(userId);
            return true;
        }
        // GET: api/values
        // GET RATINGS BY USER
        [HttpGet]
        public async Task<List<RatingListItem>> UserRatings()
        {
            if (!SetUserIdInService()) return null;

            var ratings = await _ratingService.GetAllRatingsByUserAsync();
            return ratings.ToList();
        }

        // GET api/values/5
        //GET RATING BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> Rating(int id)
        {
            var rating = await _ratingService.GetRatingByIdAsync(id);

            if (rating == null) return NotFound();

            return Ok(rating);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
