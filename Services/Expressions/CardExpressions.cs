using Common.DTOs.Card;
using Database.Entities;
using System.Linq.Expressions;

namespace Services.Expressions
{
    public class CardExpressions
    {
        public static readonly Expression<Func<Card, CardDto>> CardDtoMapper = c => new CardDto
        {
            Id = c.Id,
            Word = c.Word,
            Meaning = c.Meaning,
        };
    }
}
