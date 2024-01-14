using Todo.App.Model.Models;

namespace TodoApp.Data.Repository.IRepository;

public interface ITodoTaskRepository : IRepository<TodoTask>
{
    void Update(TodoTask obj);
}