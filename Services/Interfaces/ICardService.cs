using Common.DTOs.Card;
using Common.DTOs.Paging;
using Common.DTOs.Study;

namespace Services.Interfaces
{
    public interface ICardService
    {
        Task CreateCardAsync(CardDto card, CancellationToken cancellationToken);
        Task DeleteCardAsync(int id, CancellationToken cancellation);
        Task<IEnumerable<CardDto>> GetAllCardsAsync(CancellationToken cancellationToken);
        Task<StudyCardsDto> GetCardsAsync(PageRequestDto pageRequest, CancellationToken cancellation);
    }
}
