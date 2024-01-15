namespace TodoApp.Data.Repository.IRepository;

public interface IUnitOfWork
{
    ITodoTaskRepository TodoTask { get; }
    ICategoryRepository Category { get; }
    
    void Save();
}