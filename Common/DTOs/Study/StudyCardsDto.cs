using Common.DTOs.Card;

namespace Common.DTOs.Study
{
    public class StudyCardsDto
    {
        public IEnumerable<CardDto>? Cards { get; set; }
        public int Total { get; set; }
    }
}
