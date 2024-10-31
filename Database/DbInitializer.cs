namespace Database
{
    public static class DbInitializer
    {
        public static void Initialize(ENContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
