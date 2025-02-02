namespace LiteDatabase;

public interface IDatabase
{
    public void ExecuteNonQuery(ExecutableCommand command);
    public DataTable ExecuteQuery(ExecutableCommand query);
}