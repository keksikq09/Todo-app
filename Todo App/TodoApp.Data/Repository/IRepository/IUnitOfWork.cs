namespace TodoApp.Data.Repository.IRepository;

public interface IUnitOfWork
{
    ITodoTaskRepository TodoTask { get; }
    
    void Save();
}