namespace Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
