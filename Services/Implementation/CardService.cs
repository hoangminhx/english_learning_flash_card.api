using Common.DTOs.Card;
using Common.DTOs.Paging;
using Common.DTOs.Study;
using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Expressions;
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

        public async Task CreateCardAsync(CardDto card, CancellationToken cancellationToken)
        {
            Card newCard = new Card()
            {
                Word = card.Word,
                Meaning = card.Meaning,
            };

            context.Card.Add(newCard);

            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteCardAsync(int id, CancellationToken cancellation)
        {
            Card? card = await context.Card.FirstOrDefaultAsync(x => x.Id == id, cancellation);
            if (card != null)
            {
                context.Card.Remove(card);
                await context.SaveChangesAsync(cancellation);
            }
        }

        public async Task<IEnumerable<CardDto>> GetAllCardsAsync(CancellationToken cancellationToken)
            =>  await context.Card
                .AsNoTracking()
                .Select(CardExpressions.CardDtoMapper)
                .OrderByDescending(x => x.Id)
                .ToListAsync(cancellationToken);

        public async Task<StudyCardsDto> GetCardsAsync(PageRequestDto pageRequest, CancellationToken cancellation)
        {
            int skip = pageRequest.Page * pageRequest.PageSize;

            IEnumerable<CardDto> cards = await context.Card
                .AsNoTracking()
                .Select(CardExpressions.CardDtoMapper)
                .Skip(skip)
                .Take(pageRequest.PageSize)
                .OrderBy(x => x.Word)
                .ToListAsync(cancellation);

            int total = await context.Card.CountAsync(cancellation);

            return new StudyCardsDto
            { 
                Cards = cards,
                Total = total
            };
        }
    }
}
