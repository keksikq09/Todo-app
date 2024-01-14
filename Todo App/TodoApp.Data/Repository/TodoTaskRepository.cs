using TodoApp.Data.Data;

namespace TodoApp.Data.Repository;

public class TodoTaskRepository<TodoTask> : Repository<TodoTask> where TodoTask : class
{
    private readonly ApplicationDbContext _db;
    
    public TodoTaskRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    
    public void Update(TodoTask obj)
    {
        _db.Update(obj);
    }
}