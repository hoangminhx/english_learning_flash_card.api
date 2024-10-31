using Common.DTOs.Card;

namespace Services.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<CardDto>> GetAllCardsAsync(CancellationToken cancellationToken);
    }
}
