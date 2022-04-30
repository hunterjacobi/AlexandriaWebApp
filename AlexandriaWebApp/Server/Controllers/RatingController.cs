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
        // CREATE A RATING
        [HttpPost]
        public async Task<IActionResult> Create(RatingCreate model)
        {
            if (model == null) return BadRequest();
            if (!SetUserIdInService()) return Unauthorized();

            bool wasSuccessful = await _ratingService.CreateRatingAsync(model);

            if (wasSuccessful) return Ok();
            else return UnprocessableEntity();
        }

        // PUT api/values/5
        //UPDATE A RATING
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, RatingEdit model)
        {
            if (!SetUserIdInService()) return Unauthorized();

            if (model == null || !ModelState.IsValid) return BadRequest();
            if (model.Id != id) return BadRequest();

            bool wasSuccessful = await _ratingService.UpdateRatingAsync(model);

            if (wasSuccessful) return Ok();
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var rating = await _ratingService.GetRatingByIdAsync(id);
            if (rating == null) return NotFound();

            bool wasSuccessful = await _ratingService.DeleteRatingAsync(id);

            if (!wasSuccessful) return BadRequest();
            return Ok();
        }
    }
}
