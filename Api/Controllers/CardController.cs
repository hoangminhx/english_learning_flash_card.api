using Common.DTOs.Card;
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
        public async Task<IEnumerable<CardDto>> GetAllCards()
        {
            IEnumerable<CardDto> cards = await cardService.GetAllCardsAsync(HttpContext.RequestAborted);
            return cards;
        }

        [HttpPost]
        public async Task CreateCard([FromBody] CardDto card)
        {
            await cardService.CreateCardAsync(card, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCard(int id)
        {
            await cardService.DeleteCardAsync(id, HttpContext.RequestAborted);
        }
    }
}
