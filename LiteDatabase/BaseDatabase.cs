namespace LiteDatabase;

public abstract class BaseDatabase : IDatabase
{
    public void ExecuteNonQuery(IDbCommand command)
    {
        ExecuteNonQuery(command.GetExecutableCommand());
    }
    
    public void ExecuteNonQuery(ExecutableCommand command)
    {
        throw new NotImplementedException();
    }

    public DataTable ExecuteQuery(IDbCommand command)
    {
        return ExecuteQuery(command.GetExecutableCommand());
    }
    
    public DataTable ExecuteQuery(ExecutableCommand query)
    {
        throw new NotImplementedException();
    }
}