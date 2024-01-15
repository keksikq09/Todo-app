using Todo.App.Model.Models;
using TodoApp.Data.Data;
using TodoApp.Data.Repository.IRepository;

namespace TodoApp.Data.Repository;

public class TodoTaskRepository : Repository<TodoTask> , ITodoTaskRepository
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