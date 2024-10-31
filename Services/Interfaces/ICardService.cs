using Common.DTOs.Card;
using Common.DTOs.Paging;

namespace Services.Interfaces
{
    public interface ICardService
    {
        Task<int> CreateCardAsync(CardDto card, CancellationToken cancellationToken);
        Task DeleteCardAsync(int id, CancellationToken cancellation);
        Task<PageResponseDto<CardDto>> GetCardsAsync(PageRequestDto pageRequest, CancellationToken cancellation);
    }
}
