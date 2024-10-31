using Common.DTOs.Paging;
using Common.DTOs.Study;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api.Controllers
{
    [Route("api/study")]
    [ApiController]
    public class StudyController : ControllerBase
    {
        private readonly ICardService cardService;

        public StudyController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet("cards")]
        public async Task<StudyCardsDto> GetCards([FromQuery] PageRequestDto pageRequest)
            => await cardService.GetCardsAsync(pageRequest, HttpContext.RequestAborted);
    }
}
