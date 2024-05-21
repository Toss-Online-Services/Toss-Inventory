﻿using Domain.Entities;
using Domain.Entities.Catalog;
using Domain.Infrastructure;

namespace Application.Infrastructure.Interfaces;

public interface IApplicationDbContext : IUnitOfWork
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Product> Products { get; }


}
