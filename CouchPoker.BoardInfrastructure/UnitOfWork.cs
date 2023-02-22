namespace CouchPoker.Infrastructure;

public class UnitOfWork : IDisposable
{
    public UnitOfWork(PokerGameContext context)
    {
        Context = context;
    }

    public PokerGameContext Context { get; }
    
    public void Save()
    {
        Context.SaveChanges();
    }
    
    public void Dispose()
    {
        Context.Dispose();
    }
}