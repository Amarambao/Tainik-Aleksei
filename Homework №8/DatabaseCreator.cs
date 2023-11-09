namespace Homework__8
{
    internal static class DatabaseCreator
    {
        public static IDatabase CreateDatabase()
        {
            IDatabase database = new InMemoryDatabase();
            return database;
        }
    }
}
