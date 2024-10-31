using Common.DTOs.Card;
using Database;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

namespace Services.Implementation
{
    public class CardService : ICardService
    {
        private readonly ENContext context;

        public CardService(ENContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CardDto>> GetAllCardsAsync(CancellationToken cancellationToken)
            =>  await context.Card
                .AsNoTracking()
                .Select(x => new CardDto { Id = x.Id, Word = x.Word, Meaning = x.Meaning })
                .ToListAsync(cancellationToken);
        
    }
}
