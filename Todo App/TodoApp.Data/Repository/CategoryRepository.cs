﻿using Todo.App.Model.Models;
using TodoApp.Data.Data;
using TodoApp.Data.Repository.IRepository;

namespace TodoApp.Data.Repository;

public class CategoryRepository : Repository<Category> , ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    
    public CategoryRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Category obj)
    {
        _db.Update(obj);
    }
}