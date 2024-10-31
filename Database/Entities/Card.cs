namespace Database.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string? Word { get; set; }
        public string? Meaning { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
