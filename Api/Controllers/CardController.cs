using Common.DTOs.Card;
using Common.DTOs.Paging;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService cardService;

        public CardController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet]
        public async Task<PageResponseDto<CardDto>> GetCards([FromQuery] PageRequestDto pageRequestDto)
            => await cardService.GetCardsAsync(pageRequestDto, HttpContext.RequestAborted);

        [HttpPost]
        public async Task<object> CreateCard([FromBody] CardDto card)
        {
            int id = await cardService.CreateCardAsync(card, HttpContext.RequestAborted);
            return new { id };
        }

        [HttpDelete("{id}")]
        public async Task DeleteCard(int id)
        {
            await cardService.DeleteCardAsync(id, HttpContext.RequestAborted);
        }
    }
}
