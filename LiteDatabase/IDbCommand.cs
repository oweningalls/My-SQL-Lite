namespace LiteDatabase;

public interface IDbCommand
{
    public ExecutableCommand GetExecutableCommand();
}