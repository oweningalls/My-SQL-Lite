using LiteDatabase;

namespace DatabaseTests;

public abstract class BaseDatabaseTests<T> where T : IDatabase
{
    protected T Database;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Database = InitializeDatabase();
    }

    protected abstract T InitializeDatabase();
}