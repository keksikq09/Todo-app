using TodoApp.Data.Data;
using TodoApp.Data.Repository.IRepository;

namespace TodoApp.Data.Repository;

public class UnitOfWork : IUnitOfWork
{
    public ITodoTaskRepository TodoTask { get; }
    
    private readonly ApplicationDbContext _db;

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void Save()
    {
        _db.SaveChanges();
    }
}